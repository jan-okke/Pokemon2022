using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon2022.Game.Extensions
{
    public static class BattleExtension
    {
        public static void Init(this Battle battle)
        {
            battle.PlayerCurrentPokemon = battle.PlayerParty.GetFirstAlivePokemon();
            battle.EnemyCurrentPokemon = battle.EnemyParty.GetFirstAlivePokemon();
            battle.Turn = 0;
        }
        public static int GetTurn(this Battle battle)
        {
            return battle.Turn;
        }
        public static List<Hazard> GetPlayerSideHazards(this Battle battle)
        {
            return battle.PlayerSide.Hazards;
        }
        public static List<Hazard> GetOpponentSideHazards(this Battle battle)
        {
            return battle.EnemySide.Hazards;
        }
        public static bool IsBattleOngoing(this Battle battle)
        {
            return battle.PlayerParty.IsAlive() && battle.EnemyParty.IsAlive();
        }
        public static void EndTurn(this Battle battle)
        {
            if (!battle.IsBattleOngoing()) return;
            // Weather
            if (battle.EnemyCurrentPokemon.DoesTakeDamageFromWeather(battle.Weather)) battle.EnemyCurrentPokemon.TakeDamage((int)(battle.EnemyCurrentPokemon.Stats.HP * battle.Weather.GetDamagePercentageValue()));
            if (battle.PlayerCurrentPokemon.DoesTakeDamageFromWeather(battle.Weather)) battle.PlayerCurrentPokemon.TakeDamage((int)(battle.PlayerCurrentPokemon.Stats.HP * battle.Weather.GetDamagePercentageValue()));
            // Status
            if (battle.EnemyCurrentPokemon.IsAlive() && battle.EnemyCurrentPokemon.DoesTakeDamageFromStatus(battle.EnemyCurrentPokemon.Status)) battle.EnemyCurrentPokemon.TakeDamage((int)(battle.EnemyCurrentPokemon.Stats.HP * battle.EnemyCurrentPokemon.Status.GetDamagePercentageValue(battle.EnemyCurrentPokemon.StatusTurn)));
            if (battle.PlayerCurrentPokemon.IsAlive() && battle.PlayerCurrentPokemon.DoesTakeDamageFromStatus(battle.PlayerCurrentPokemon.Status)) battle.PlayerCurrentPokemon.TakeDamage((int)(battle.PlayerCurrentPokemon.Stats.HP * battle.PlayerCurrentPokemon.Status.GetDamagePercentageValue(battle.PlayerCurrentPokemon.StatusTurn)));
            // SecondaryStatus
            foreach (PokemonStatusSecondary secondary in battle.EnemyCurrentPokemon.SecondaryStatusList)
            {
                if (battle.EnemyCurrentPokemon.IsAlive() && battle.EnemyCurrentPokemon.DoesTakeDamageFromStatus(secondary))
                {
                    int damage = (int)(battle.EnemyCurrentPokemon.Stats.HP * secondary.GetDamagePercentageValue());
                    battle.EnemyCurrentPokemon.TakeDamage(damage);
                    if (secondary == PokemonStatusSecondary.LeechSeed) battle.PlayerCurrentPokemon.HealHP(damage);
                }
            }
            foreach (PokemonStatusSecondary secondary in battle.PlayerCurrentPokemon.SecondaryStatusList)
            {
                if (battle.PlayerCurrentPokemon.IsAlive() && battle.PlayerCurrentPokemon.DoesTakeDamageFromStatus(secondary))
                {
                    int damage = (int)(battle.PlayerCurrentPokemon.Stats.HP * secondary.GetDamagePercentageValue());
                    battle.PlayerCurrentPokemon.TakeDamage(damage);
                    if (secondary == PokemonStatusSecondary.LeechSeed) battle.EnemyCurrentPokemon.HealHP(damage);
                }
            }
            // Items
            double itemRestoreEnemy = battle.EnemyCurrentPokemon.HeldItem.GetEndOfTurnRestorePercentageValue();
            if (itemRestoreEnemy > 0 && battle.EnemyCurrentPokemon.IsAlive()) battle.EnemyCurrentPokemon.HealHP((int)(battle.EnemyCurrentPokemon.Stats.HP * itemRestoreEnemy));
            if (itemRestoreEnemy < 0) battle.EnemyCurrentPokemon.TakeDamage((int)(battle.EnemyCurrentPokemon.Stats.HP * itemRestoreEnemy));
            double itemRestorePlayer = battle.PlayerCurrentPokemon.HeldItem.GetEndOfTurnRestorePercentageValue();
            if (itemRestorePlayer > 0 && battle.EnemyCurrentPokemon.IsAlive()) battle.PlayerCurrentPokemon.HealHP((int)(battle.PlayerCurrentPokemon.Stats.HP * itemRestorePlayer));
            if (itemRestorePlayer < 0) battle.PlayerCurrentPokemon.TakeDamage((int)(battle.PlayerCurrentPokemon.Stats.HP * itemRestorePlayer));
            // End Weather
            battle.WeatherTurns--;
            if (battle.WeatherTurns <= 0) battle.Weather = Weather.None;
            // End Terrain
            battle.TerrainTurns--;
            if (battle.TerrainTurns <= 0) battle.Terrain = Terrain.None;
            // Increment Turn Counter
            battle.Turn++;
            // Increment Status Turn Counter
            if (battle.PlayerCurrentPokemon.Status != PokemonStatus.None && battle.PlayerCurrentPokemon.IsAlive()) battle.PlayerCurrentPokemon.StatusTurn++;
            if (battle.EnemyCurrentPokemon.Status != PokemonStatus.None && battle.EnemyCurrentPokemon.IsAlive()) battle.EnemyCurrentPokemon.StatusTurn++;
            // Update current battlers.
            if (!battle.IsBattleOngoing()) return;
            battle.PlayerCurrentPokemon = battle.PlayerParty.GetFirstAlivePokemon();
            battle.EnemyCurrentPokemon = battle.EnemyParty.GetFirstAlivePokemon();
        }
        
        private static bool BattleAct(Battle battle, Pokemon attackingPokemon, Pokemon defendingPokemon, Move moveUsed)
        {
            int damage = Calculations.CalculateDamage(battle, attackingPokemon, defendingPokemon, moveUsed);
            defendingPokemon.TakeDamage(damage);
            return !defendingPokemon.IsAlive();
        }
        private static bool IsFaster(Pokemon pokemon, Pokemon otherPokemon, Move move, Move otherMove)
        {
            if (move.IsFaster(otherMove)) return true;
            if (otherMove.IsFaster(move)) return false;
            if (pokemon.IsFaster(otherPokemon)) return true;
            if (otherPokemon.IsFaster(pokemon)) return false;
            return Convert.ToBoolean(new Random().Next(0, 2));
        }
        private static BattleState MakeState(Battle battle)
        {
            //Console.WriteLine(battle.EnemyCurrentPokemon.CurrentHP);
            battle.EndTurn();
            return new BattleState(battle.PlayerCurrentPokemon.Clone(), battle.EnemyCurrentPokemon.Clone(), battle.Clone(), new());
        }
        public static List<BattleState> BattleTurn(this Battle battle, Move playerMove, Move enemyMove)
        {
            List<BattleState> states = new();
            if (IsFaster(battle.PlayerCurrentPokemon, battle.EnemyCurrentPokemon, playerMove, enemyMove))
            {
                if (BattleAct(battle, battle.PlayerCurrentPokemon, battle.EnemyCurrentPokemon, playerMove))
                {
                    states.Add(MakeState(battle));
                    return states;
                }
                states.Add(MakeState(battle));
                BattleAct(battle, battle.EnemyCurrentPokemon, battle.PlayerCurrentPokemon, enemyMove);
                states.Add(MakeState(battle));
                return states;
            }
            if (BattleAct(battle, battle.EnemyCurrentPokemon, battle.PlayerCurrentPokemon, enemyMove))
            {
                states.Add(MakeState(battle));
                return states;
            }
            BattleAct(battle, battle.PlayerCurrentPokemon, battle.EnemyCurrentPokemon, playerMove);
            states.Add(MakeState(battle));
            return states;
        }
    }
}

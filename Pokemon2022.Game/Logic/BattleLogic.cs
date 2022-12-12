using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Entities.Exceptions;
using Pokemon2022.Game.Extensions;

namespace Pokemon2022.Game.Logic
{
    public class BattleLogic
    {
        public static bool CheckWildBattleFlee(Pokemon playerPokemon, Pokemon opponent)
        {
            return false;
        }
        public static bool Coinflip()
        {
            Random random = new();
            switch (random.Next(0, 2))
            {
                case 0: return true;
                case 1: return false;
            }
            throw new Exception("random.Next(0,2) didnt return 0 or 1");
        }
        public static bool IsFaster(Pokemon pokemon1, Pokemon pokemon2, Move move1, Move move2)
        {
            if (move1.Priority > move2.Priority) return true;
            if (move2.Priority > move1.Priority) return false;
            if (pokemon1.Stats.Speed * Calculations.CalculateStatStageMod((int)pokemon1.StatStages.Speed) > pokemon2.Stats.Speed * Calculations.CalculateStatStageMod((int)pokemon2.StatStages.Speed))
            {
                return true;
            }
            if (pokemon2.Stats.Speed * Calculations.CalculateStatStageMod((int)pokemon2.StatStages.Speed) > pokemon1.Stats.Speed * Calculations.CalculateStatStageMod((int)pokemon1.StatStages.Speed))
            {
                return false;
            }
            return Coinflip();
        }
        private static List<string> OnFaint(Pokemon killer, Pokemon fainted, PokemonParty faintedParty)
        {
            List<string> text = new();
            fainted.IsAlive = false;
            int experience = Calculations.CalculateExpGain(killer, fainted);
            text.Add(TextHelper.GetExpGainString(killer, experience));
            killer.Experience += experience;
            int oldLevel = killer.Level;
            killer.Level = Calculations.CalculateLevel(killer.Experience);
            if (killer.Level > oldLevel) // Leveled up 
            {
                for (int level = oldLevel; level <= killer.Level; level++)
                {
                    text.Add(TextHelper.GetLevelUpString(killer, level));
                    foreach (int key in killer.LevelUpLearnset.Keys)
                    {
                        if (level == key)
                        {
                            List<Move> moves = killer.LevelUpLearnset[key];
                            foreach (Move m in moves)
                            {
                                foreach (string s in TextHelper.GetMoveLearnString(killer, m)) text.Add(s);
                            }
                        }
                    }
                }
            }
            killer.CalculateStats();
            try
            {
                faintedParty.GetFirstAlivePokemon();
            }
            catch (NoPokemonAliveException e)
            {
                text.Add(e.Message);
            }
            return text;
        }
        private static bool BattleAction(Pokemon attacker, Pokemon defender, Move move, Battle battle, bool playerAction)//, UIController ui)
        {
            int damage = Calculations.CalculateDamage(battle, attacker, defender, move);
            //ui.AddActionData(new($"{attacker.Name} used {move.Name}!", 600));
            if (damage >= defender.CurrentHP)
            {
                defender.CurrentHP = 0;
                if (playerAction)
                {
                    OnFaint(attacker, defender, battle.EnemyParty);
                }
                else
                {
                    OnFaint(attacker, defender, battle.PlayerParty);
                }
                //ui.AddActionData(new($"{defender.Name} fainted!", 600));
                return true;
            }
            defender.CurrentHP -= damage;
            return false;
        }
        public static List<BattleState> BattleTurn(Pokemon attacker, Pokemon defender, Move attackerMove, Move defenderMove, Battle battle)//, UIController ui)
        {
            List<BattleState> states = new();
            if (IsFaster(attacker, defender, attackerMove, defenderMove))
            {
                if (BattleAction(attacker, defender, attackerMove, battle, true))
                {
                    states.Add(new BattleState(attacker.Clone(), defender.Clone(), battle.Clone(), TextHelper.GetMoveUseString(attacker, defender, battle.IsWildBattle, attackerMove, (double)Calculations.GetEffMod(defender, attackerMove), false, false, true)));
                    return states;
                }
                states.Add(new BattleState(attacker.Clone(), defender.Clone(), battle.Clone(), TextHelper.GetMoveUseString(attacker, defender, battle.IsWildBattle, attackerMove, (double)Calculations.GetEffMod(defender, attackerMove), false, false, false)));
                BattleAction(defender, attacker, defenderMove, battle, false);
                states.Add(new BattleState(attacker.Clone(), defender.Clone(), battle.Clone(), TextHelper.GetMoveUseString(defender, attacker, battle.IsWildBattle, defenderMove, (double)Calculations.GetEffMod(attacker, defenderMove), false, false, false)));
                return states;
            }
            else
            {
                if (BattleAction(defender, attacker, defenderMove, battle, false))
                {
                    states.Add(new BattleState(attacker.Clone(), defender.Clone(), battle.Clone(), TextHelper.GetMoveUseString(defender, attacker, battle.IsWildBattle, attackerMove, (double)Calculations.GetEffMod(attacker, defenderMove), false, false, true)));
                    return states;
                }
                states.Add(new BattleState(attacker.Clone(), defender.Clone(), battle.Clone(), TextHelper.GetMoveUseString(defender, attacker, battle.IsWildBattle, attackerMove, (double)Calculations.GetEffMod(attacker, defenderMove), false, false, false)));
                BattleAction(attacker, defender, attackerMove, battle, true);
                states.Add(new BattleState(attacker.Clone(), defender.Clone(), battle.Clone(), TextHelper.GetMoveUseString(attacker, defender, battle.IsWildBattle, attackerMove, (double)Calculations.GetEffMod(defender, attackerMove), false, false, false)));
                return states;
            }
        }

        public static bool IsMultiTargetBattle(Battle battle)
        {
            return battle.BattleType == BattleType.MultiBattle || battle.BattleType == BattleType.DoubleBattle || battle.BattleType == BattleType.TripleBattle;
        }

        public static bool IsMultiTargetMove(Move move)
        {
            return move.Target == MoveTarget.AllNearFoes || move.Target == MoveTarget.AllFoes;
        }
    }
}

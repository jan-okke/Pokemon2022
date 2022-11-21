using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;

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
        private static void OnFaint(Pokemon killer, Pokemon fainted)
        {
            fainted.IsAlive = false;
        }
        private static bool BattleAction(Pokemon attacker, Pokemon defender, Move move, Battle battle)//, UIController ui)
        {
            int damage = Calculations.CalculateDamage(battle, attacker, defender, move);
            //ui.AddActionData(new($"{attacker.Name} used {move.Name}!", 600));
            if (damage > defender.CurrentHP)
            {
                defender.CurrentHP = 0;
                OnFaint(attacker, defender);
                //ui.AddActionData(new($"{defender.Name} fainted!", 600));
                return true;
            }
            defender.CurrentHP -= damage;
            return false;
        }
        public static void BattleTurn(Pokemon attacker, Pokemon defender, Move attackerMove, Move defenderMove, Battle battle)//, UIController ui)
        {
            if (IsFaster(attacker, defender, attackerMove, defenderMove))
            {
                if (BattleAction(attacker, defender, attackerMove, battle)) return;
                BattleAction(defender, attacker, defenderMove, battle);
            }
            else
            {
                if (BattleAction(defender, attacker, defenderMove, battle)) return;
                BattleAction(attacker, defender, attackerMove, battle);
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

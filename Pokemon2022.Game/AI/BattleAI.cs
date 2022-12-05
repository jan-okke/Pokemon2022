using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using Pokemon2022.Game.Logic;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon2022.Game.AI
{
    public class BattleAI
    {
        // Singles
        public static bool CanKill(Battle battle)
        {
            Pokemon pokemon = battle.EnemyParty.GetFirstAlivePokemon().Clone();
            Pokemon opponent = battle.PlayerParty.GetFirstAlivePokemon().Clone();

            foreach (Move m in pokemon.Moves)
            {
                if (Calculations.CalculateDamage(battle, pokemon, opponent, m) > opponent.CurrentHP)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool CheckMoveKill(Battle battle, Move m)
        {
            Pokemon pokemon = battle.EnemyParty.GetFirstAlivePokemon().Clone();
            Pokemon opponent = battle.PlayerParty.GetFirstAlivePokemon().Clone();

            return (Calculations.CalculateDamage(battle, pokemon, opponent, m) > opponent.CurrentHP);
        }

        public static bool Can2HKO(Battle battle)
        {
            Pokemon pokemon = battle.EnemyParty.GetFirstAlivePokemon().Clone();
            Pokemon opponent = battle.PlayerParty.GetFirstAlivePokemon().Clone();

            foreach (Move m in pokemon.Moves)
            {
                if (Calculations.CalculateDamage(battle, pokemon, opponent, m) > opponent.CurrentHP / 2)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool CanKillAfterHealing(Battle battle, int healing)
        {
            Pokemon pokemon = battle.EnemyParty.GetFirstAlivePokemon().Clone();
            Pokemon opponent = battle.PlayerParty.GetFirstAlivePokemon().Clone();

            foreach (Move m in pokemon.Moves)
            {
                if (Calculations.CalculateDamage(battle, pokemon, opponent, m) * 2 > opponent.CurrentHP + healing)
                {
                    return true;
                }
            }
            return false;
        }

        public static Move? GetHighestPriorityThenHighestAccuracyMove(Battle battle)
        {
            Pokemon pokemon = battle.EnemyParty.GetFirstAlivePokemon().Clone();
            Pokemon opponent = battle.PlayerParty.GetFirstAlivePokemon().Clone();

            int OpponentHasPrioMove = 0;
            List<Move> FasterCheckPassedMoves = new();

            if (BattleLogic.IsFaster(pokemon, opponent, MoveFactory.Tackle, MoveFactory.Tackle))
            {
                foreach (Move m in opponent.Moves)
                {
                    if (m.Priority > 0 && m.Category != MoveCategory.Status)
                    {
                        OpponentHasPrioMove = Math.Max(OpponentHasPrioMove, m.Priority);
                    }
                }
                if (OpponentHasPrioMove > 0)
                {
                    foreach (Move m in pokemon.Moves)
                    {
                        if (m.Priority >= OpponentHasPrioMove && CheckMoveKill(battle, m))
                        {
                            FasterCheckPassedMoves.Add(m);
                        }
                    }
                }
                else
                {
                    FasterCheckPassedMoves.AddRange(pokemon.Moves);
                }
            }
            else
            {
                foreach (Move m in opponent.Moves)
                {
                    if (m.Priority > 0 && m.Category != MoveCategory.Status)
                    {
                        OpponentHasPrioMove = Math.Max(OpponentHasPrioMove, m.Priority);
                    }
                }
                foreach (Move m in pokemon.Moves)
                {
                    if (m.Priority > OpponentHasPrioMove && CheckMoveKill(battle, m))
                    {
                        FasterCheckPassedMoves.Add(m);
                    }
                }
            }

            if (FasterCheckPassedMoves.Count == 0) return null;
            FasterCheckPassedMoves.Sort((x, y) => x.Accuracy.CompareTo(y.Accuracy));
            FasterCheckPassedMoves.Reverse();
            return FasterCheckPassedMoves[0];
        }
    }
}

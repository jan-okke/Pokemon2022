using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon2022.Console
{
    public class Analyzer
    {
        private static string GetIndexString(int index)
        {
            string ret = $"{index%1000}";
            while (index > 1000)
            {
                index -= index % 1000;
                index = index / 1000;
                ret = $"{index%1000}.{ret}";
            }
            return ret;
        }
        public static Dictionary<long, string> Analyze(Pokemon attacker, Pokemon defender, Battle battle, int depth)
        {
            Dictionary<long, string> result = new Dictionary<long, string>();
            List<State> States = new();
            List<State> _States = new();
            int index = 0;
            int atkWinCount = 0;
            int oppWinCount = 0;
            int total = 0;
            foreach (Move attMove in attacker.Moves)
            {
                foreach (Move oppMove in defender.Moves)
                {
                    index++;
                    Pokemon att = attacker.Clone();
                    Pokemon opp = defender.Clone();
                    Move atMove = attMove.Clone();
                    Move opMove = oppMove.Clone();
                    Battle bat = battle.Clone();
                    //Console.WriteLine($"{att.GetHashCode()} | {opp.GetHashCode()}");
                    BattleLogic.BattleTurn(att, opp, atMove, opMove, bat);
                    string before = $"Outcome [{index}] {attMove.Name} | {oppMove.Name}\n" +
                        $"Attacker: {att.CurrentHP} / {att.Stats.HP}\n" +
                        $"Defender: {opp.CurrentHP} / {opp.Stats.HP}";
                    result.Add(index * 1000, before);
                    if (att.IsAlive && opp.IsAlive) States.Add(new(att, opp, bat, atMove, opMove, index));
                    if (att.IsAlive && !opp.IsAlive) atkWinCount++;
                    if (!att.IsAlive && opp.IsAlive) oppWinCount++;
                    total++;
                }
            }
            for (int i = 1; i < depth; i++)
            {
                if (i % 2 == 0)
                {
                    foreach (State state in _States)
                    {
                        index = 0;
                        foreach (Move attMove in state.PlayerPokemon.Moves)
                        {
                            foreach (Move oppMove in state.OpponentPokemon.Moves)
                            {
                                index++;
                                Pokemon att = state.PlayerPokemon.Clone();
                                Pokemon opp = state.OpponentPokemon.Clone();
                                Move atMove = attMove.Clone();
                                Move opMove = oppMove.Clone();
                                Battle bat = state.Battle.Clone();
                                //Console.WriteLine($"{att.GetHashCode()} | {opp.GetHashCode()}");
                                BattleLogic.BattleTurn(att, opp, atMove, opMove, bat);
                                result.Add(state.Index * 1000*i + index, $"Outcome [{GetIndexString(state.Index)}.{index}] {state.AttackerMove.Name} | {state.OpponentMove.Name} | {attMove.Name} | {oppMove.Name}\n" +
                                    $"Attacker: {att.CurrentHP} / {att.Stats.HP}\n" +
                                    $"Defender: {opp.CurrentHP} / {opp.Stats.HP}");
                                if (att.IsAlive && !opp.IsAlive) atkWinCount++;
                                if (!att.IsAlive && opp.IsAlive) oppWinCount++;
                                if (att.IsAlive && opp.IsAlive) States.Add(new(att, opp, bat, atMove, opMove, state.Index * 1000*i + index));
                                total++;
                            }
                        }
                    }
                }
                else
                {
                    foreach (State state in States)
                    {
                        index = 0;
                        foreach (Move attMove in state.PlayerPokemon.Moves)
                        {
                            foreach (Move oppMove in state.OpponentPokemon.Moves)
                            {
                                index++;
                                Pokemon att = state.PlayerPokemon.Clone();
                                Pokemon opp = state.OpponentPokemon.Clone();
                                Move atMove = attMove.Clone();
                                Move opMove = oppMove.Clone();
                                Battle bat = state.Battle.Clone();
                                //Console.WriteLine($"{att.GetHashCode()} | {opp.GetHashCode()}");
                                BattleLogic.BattleTurn(att, opp, atMove, opMove, bat);
                                result.Add(state.Index * 1000*i + index, $"Outcome [{GetIndexString(state.Index)}.{index}] {state.AttackerMove.Name} | {state.OpponentMove.Name} | {attMove.Name} | {oppMove.Name}\n" +
                                    $"Attacker: {att.CurrentHP} / {att.Stats.HP}\n" +
                                    $"Defender: {opp.CurrentHP} / {opp.Stats.HP}");
                                if (att.IsAlive && !opp.IsAlive) atkWinCount++;
                                if (!att.IsAlive && opp.IsAlive) oppWinCount++;
                                if (att.IsAlive && opp.IsAlive) _States.Add(new(att, opp, bat, atMove, opMove, state.Index * 1000*i + index));
                                total++;
                            }
                        }
                    }
                }
            }
            return result;
        }
    }
}

using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
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
        public static Dictionary<int, List<BattleState>> Analyze(Pokemon attacker, Pokemon defender, Battle battle, int depth)
        {
            /*
            List<BattleState> states = new();
            foreach (Move am in attacker.Moves)
            {
                foreach (Move dm in defender.Moves)
                {
                    states.Add(BattleLogic.BattleTurn(attacker.Clone(), defender.Clone(), am, dm, battle.Clone()).Last());
                }
            }
            List<BattleState> subStates = new();
            foreach (BattleState state in states)
            {
                if (state.Winner != null)
                {
                    System.Console.WriteLine("Early winner");
                    continue;
                }
                foreach (Move am in state.Attacker.Moves)
                {
                    foreach (Move dm in state.Defender.Moves)
                    {
                        subStates.Add(BattleLogic.BattleTurn(state.Attacker.Clone(), state.Defender.Clone(), am, dm, state.Battle.Clone()).Last());
                    }
                }
            }
            foreach (BattleState state in subStates)
            {
                System.Console.WriteLine($"And the winner is {state.Winner}");
            }
            */
            attacker.Stats.HP = 10000;
            attacker.CurrentHP = 10000;
            defender.Stats.HP = 10000;
            defender.CurrentHP = 10000;

            List<Thread> Threads = new List<Thread>();
            Dictionary<int, List<BattleState>> fullData = new();
            fullData.Add(0, new());
            foreach (Move am in attacker.Moves)
            {
                foreach (Move dm in defender.Moves)
                {
                    fullData[0].Add(BattleLogic.BattleTurn(attacker.Clone(), defender.Clone(), am, dm, battle.Clone()).Last());
                }
            }
            for (int i = 1; i < depth; i++)
            {
                Thread t = new Thread(() => Ana(i));
                t.Start();
                Threads.Add(t);
                while (t.ThreadState == ThreadState.Running)
                {
                    Thread.Sleep(100);
                }
            }
            return fullData;

            void Ana(int i)
            {
                System.Console.WriteLine($"[{DateTime.Now}] - Checking Turn {i}");
                fullData.Add(i, new());
                if (fullData[i - 1].Count == 0) return; // return fullData;
                foreach (BattleState state in fullData[i - 1])
                {
                    if (state.Winner != null)
                    {
                        System.Console.WriteLine($"[{DateTime.Now}] - {state.Winner.Name} won Turn {i}");
                        continue;
                    }
                    foreach (Move am in state.Attacker.Moves)
                    {
                        foreach (Move dm in state.Defender.Moves)
                        {
                            fullData[i].Add(BattleLogic.BattleTurn(state.Attacker.Clone(), state.Defender.Clone(), am, dm, state.Battle.Clone()).Last());
                        }
                    }
                }
            }
        }
    }
}

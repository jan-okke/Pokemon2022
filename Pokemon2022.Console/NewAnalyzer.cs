using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Extensions;
using Pokemon2022.Game.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon2022.Console
{
    public class NewAnalyzer
    {
        public static void Analyze(Battle battle)
        {
            battle.Init();
            var states = battle.BattleTurn(battle.PlayerCurrentPokemon.Moves[1], battle.EnemyCurrentPokemon.Moves[1]);
            battle.EndTurn();
            System.Console.WriteLine(battle);
        }
        public static Dictionary<int, List<BattleState>> AnalyzeBattle(Battle battle, int depth)
        {
            battle.Init();
            var attacker = battle.PlayerCurrentPokemon;
            var defender = battle.EnemyCurrentPokemon;
            Dictionary<int, List<BattleState>> fullData = new();
            fullData.Add(0, new());
            foreach (Move am in attacker.Moves)
            {
                foreach (Move dm in defender.Moves)
                {
                    var _battle = battle.Copy();
                    fullData[0].Add(_battle.BattleTurn(am, dm).Last());
                }
            }
            for (int i = 1; i < depth; i++)
            {
                System.Console.WriteLine($"Checking Turn {i}");
                fullData.Add(i, new());
                if (fullData[i - 1].Count == 0) return fullData;
                foreach (BattleState state in fullData[i - 1])
                {
                    if (!state.Battle.IsBattleOngoing()) { System.Console.WriteLine("Battle over"); continue; }
                    if (state.Winner != null)
                    {
                        System.Console.WriteLine($"{state.Winner.Name} won Turn {i + 1}");
                        continue;
                    }
                    foreach (Move am in state.Battle.PlayerCurrentPokemon.Moves)
                    {
                        foreach (Move dm in state.Battle.EnemyCurrentPokemon.Moves)
                        {
                            var _battle = state.Battle.Copy();
                            fullData[i].Add(_battle.BattleTurn(am, dm).Last());
                        }
                    }
                }
            }
            return fullData;
        }
    }
}

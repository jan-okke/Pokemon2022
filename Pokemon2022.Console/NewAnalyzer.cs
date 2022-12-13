using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Extensions;
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
            // todo, states.battle not correctly cloned? mhm
            battle.EndTurn();
            System.Console.WriteLine(battle);
        }
    }
}

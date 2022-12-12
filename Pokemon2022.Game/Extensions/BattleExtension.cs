using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon2022.Game.Extensions
{
    public static class BattleExtension
    {
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
            if (battle.EnemyCurrentPokemon.DoesTakeDamageFromWeather(battle.Weather)) battle.EnemyCurrentPokemon.Tak
        }
    }
}

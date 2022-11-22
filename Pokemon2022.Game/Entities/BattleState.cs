using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon2022.Game.Entities
{
    public class BattleState
    {
        public Pokemon Attacker;
        public Pokemon Defender;
        public Battle Battle;
        public List<string> DisplayText;

        public BattleState(Pokemon attacker, Pokemon defender, Battle battle, List<string> displayText)
        {
            Attacker = attacker;
            Defender = defender;
            Battle = battle;
            DisplayText = displayText;
        }
    }
}

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
        public Pokemon? Winner;

        public BattleState(Pokemon attacker, Pokemon defender, Battle battle, List<string> displayText)
        {
            Attacker = attacker;
            Defender = defender;
            Battle = battle;
            DisplayText = displayText;
            if (Attacker.CurrentHP > 0 && Defender.CurrentHP > 0) Winner = null;
            if (Attacker.CurrentHP <= 0 && Defender.CurrentHP > 0) Winner = Defender.Clone();
            if (Attacker.CurrentHP > 0 && Defender.CurrentHP <= 0) Winner = Attacker.Clone();
            if (Attacker.CurrentHP <= 0 && Defender.CurrentHP <= 0) throw new Exception("Both Pokemon fainted in a state");
        }
    }
}

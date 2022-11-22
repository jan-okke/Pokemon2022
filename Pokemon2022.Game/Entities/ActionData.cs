using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon2022.Game.Entities
{
    public class ActionData
    {
        public string Text;
        public int Delay;
        public BattleState State;

        public ActionData(string text, int delay, BattleState state)
        {
            Text = text;
            Delay = delay;
            State = state;
        }
    }
}

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

        public ActionData(string text, int delay)
        {
            Text = text;
            Delay = delay;
        }
    }
}

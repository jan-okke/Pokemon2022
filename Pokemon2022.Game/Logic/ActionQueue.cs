using Pokemon2022.Game.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon2022.Game.Logic
{
    public class ActionQueue
    {
        private List<ActionData> Data;
        public ActionQueue()
        {
            Data = new();
        }
        public void Add(ActionData action)
        {
            Data.Add(action);
        }
        public ActionData? Next()
        {
            if (Data.Count == 0) return null;
            ActionData data = Data[0];
            Data.RemoveAt(0);
            return data;
        }
    }
}

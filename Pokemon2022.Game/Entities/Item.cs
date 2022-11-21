using Pokemon2022.Game.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon2022.Game.Entities
{
    public class Item
    {
        public string Name;
        public string Description;
        public BattleTrigger Trigger;

        public Item()
        {
            Name = string.Empty;
            Description = string.Empty;
        }
        public Item Clone()
        {
            return new()
            {
                Name = Name,
                Description = Description
            };
        }
        public override string ToString()
        {
            return Name;
        }
    }
}

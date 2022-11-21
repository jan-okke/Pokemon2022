using Pokemon2022.Game.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon2022.Game.Entities
{
    public class Ability
    {
        public string Name;
        public string Description;

        public Ability()
        {
            Name = string.Empty;
            Description = string.Empty;
        }
        public Ability Clone()
        {
            return new()
            {
                Name = Name,
                Description = Description,
            };
        }
        public override string ToString()
        {
            return Name;
        }
    }
}

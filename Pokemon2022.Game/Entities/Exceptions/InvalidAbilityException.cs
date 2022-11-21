using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon2022.Game.Entities.Exceptions
{
    public class InvalidAbilityException : Exception
    {
        public InvalidAbilityException(string name)
            : base($"Invalid Ability: {name}")
        { }
    }
}

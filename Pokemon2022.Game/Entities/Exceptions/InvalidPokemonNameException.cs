using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon2022.Game.Entities.Exceptions
{
    public class InvalidPokemonNameException : Exception
    {
        public InvalidPokemonNameException(string name)
            : base($"No pokemon with name {name} found")
        { }
    }
}

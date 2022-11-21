using Pokemon2022.Game.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon2022.Game.Entities.Exceptions
{
    public class InvalidPokemonTypeException : Exception
    {
        public InvalidPokemonTypeException(PokemonType type)
            :base($"Invalid Type: {type}")
        { }
    }
}

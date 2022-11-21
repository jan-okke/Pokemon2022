using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon2022.Game.Entities.Exceptions
{
    public class NoPokemonAliveException : Exception
    {
        public NoPokemonAliveException()
            :base("No Pokemon Alive")
        { }
    }
}

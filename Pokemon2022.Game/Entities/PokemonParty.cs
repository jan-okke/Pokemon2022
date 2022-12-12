using Pokemon2022.Game.Entities.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon2022.Game.Entities
{
    public class PokemonParty
    {
        public List<Pokemon> Pokemons;
        
        public PokemonParty()
        {
            Pokemons = new List<Pokemon>();
        }
        
        public override string ToString()
        {
            return "Pokemon Party";
        }
    }
}

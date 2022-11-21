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
        public Pokemon GetFirstAlivePokemon()
        {
            foreach (Pokemon p in Pokemons)
            {
                if (p.IsAlive) return p;
            }
            throw new NoPokemonAliveException();
        }
        public bool IsAlive()
        {
            foreach (Pokemon p in Pokemons)
            {
                if (p.IsAlive) return true;
            }
            return false;
        }
        public override string ToString()
        {
            return "Pokemon Party";
        }
    }
}

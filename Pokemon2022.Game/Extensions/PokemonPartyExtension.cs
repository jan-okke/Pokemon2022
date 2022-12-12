using Pokemon2022.Game.Entities.Exceptions;
using Pokemon2022.Game.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon2022.Game.Extensions
{
    public static class PokemonPartyExtension
    {
        public static Pokemon GetFirstAlivePokemon(this PokemonParty party)
        {
            foreach (Pokemon p in party.Pokemons)
            {
                if (p.IsAlive) return p;
            }
            throw new NoPokemonAliveException();
        }
        public static bool IsAlive(this PokemonParty party)
        {
            foreach (Pokemon p in party.Pokemons)
            {
                if (p.IsAlive) return true;
            }
            return false;
        }
        public static void AddPokemon(this PokemonParty party, Pokemon pokemon)
        {
            if (party.Pokemons.Count == 6) throw new FullPartyException();
            party.Pokemons.Add(pokemon);
        }
        public static void RemovePokemon(this PokemonParty party, int index)
        {
            party.Pokemons.RemoveAt(index);
        }
        public static void RemovePokemon(this PokemonParty party, Pokemon pokemon)
        {
            throw new NotImplementedException();
        }
    }
}

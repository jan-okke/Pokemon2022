using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Extensions;
using Pokemon2022.Game.Factory;
using Pokemon2022.Game.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon2022.Console
{
    internal class PBSMaker
    {
        private static T GetObj<T>(List<T> values)
        {
            if (values.Count == 0) throw new ArgumentException(nameof(values));
            return values[new Random().Next(0, values.Count)];
        }
        private static List<Pokemon>? GeneratePokemon(PokemonType t, int level, int generation, int minBST, int maxBST)
        {
            List<Pokemon> pokemons = new List<Pokemon>();
            //foreach (Pokemon p in PokemonFactory.Pokemons)
            //{
            //    if (p.Types.Contains(t) && p.Generation == generation && p.GetBST() >= minBST && p.GetBST() <= maxBST) {
            //        pokemons.Add(GameController.NewPokemon(p.Name, level));
            //    }
            //}
            if (pokemons.Count == 0) { return null; }
            return pokemons;
        }
        public static void GenerateTrainer(string trainerClass, string name, List<PokemonType> pokemonTypes, int minLevel, int maxLevel, int pokemonCount, List<int> generation, int minBST, int maxBST)
        {
            System.Console.WriteLine("# ------------------------------");
            System.Console.WriteLine($"[{trainerClass.ToUpper()},{name}]");
            System.Console.WriteLine("LoseText = ...");
            var party = new PokemonParty();
            for (int i = 0; i < pokemonCount; i++)
            {
                Pokemon pokemon;
                while (true)
                {
                    var list = GeneratePokemon(GetObj(pokemonTypes), new Random().Next(minLevel, maxLevel), GetObj(generation), minBST, maxBST);
                    if (list is null) continue;
                    pokemon = GetObj(list);
                    break;
                }
                party.AddPokemon(pokemon);
            }
            foreach (Pokemon p in party.Pokemons)
            {
                System.Console.WriteLine($"Pokemon = {p.Name},{p.Level}");
            }
            
        }
    }
}

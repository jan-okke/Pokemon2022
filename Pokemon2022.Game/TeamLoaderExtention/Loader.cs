using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Extensions;
using Pokemon2022.Game.Logic;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon2022.Game.TeamLoaderExtention
{
    public class Loader
    {
        public static PokemonParty LoadFromFile(string path)
        {
            Pokemon pokemon;
            PokemonParty party = new();
            string[] data = File.ReadAllLines(path);
            Ability? ability = null;
            int? level = null;
            PokemonNature? nature = null;
            string? name = null;
            List<Move> moves = new();
            Item? item = null;
            foreach (string line in data)
            {
                if (line.StartsWith("Ability: ")) ability = GameController.GetAbility(line.Split(new[] { ": " }, StringSplitOptions.None)[1]);
                else if (line.StartsWith("Level: ")) level = Convert.ToInt32(line.Split(new[] { ": " }, StringSplitOptions.None)[1]);
                else if (line.Contains(" Nature")) nature = (PokemonNature)Enum.Parse(typeof(PokemonNature), line.Split(new[] { " Nature" }, StringSplitOptions.None)[0]);
                else if (line.StartsWith("- ")) moves.Add(GameController.GetMove(line.Split(new[] { "- " }, StringSplitOptions.None)[1]));
                else if (line.StartsWith("IVs: ")) { }
                else if (line == string.Empty)
                {
                    if (name is null || level is null) continue;
                    pokemon = Pokemon.NewPokemon(name);
                    pokemon.Level = (int)level;
                    if (ability != null) pokemon.Ability = ability;
                    if (nature != null) pokemon.Nature = (PokemonNature)nature;
                    if (item != null) pokemon.HeldItem = item;
                    pokemon.Moves = new();
                    foreach (Move m in moves) pokemon.Moves.Add(m);
                    pokemon.CalculateStats();
                    pokemon.CurrentHP = (int)pokemon.Stats.HP;
                    party.Pokemons.Add(pokemon);
                    moves = new();
                    name = null;
                    ability = null;
                    nature = null;
                    item = null;
                }
                else
                {
                    if (line.Contains(" @ "))
                    {
                        item = GameController.GetItem(line.Split(new[] { " @ " }, StringSplitOptions.None)[1]);
                        name = line.Split(new[] { " @ " }, StringSplitOptions.None)[0];
                    }
                    else name = line;
                }
            }
            if (name is null || level is null) return party;
            pokemon = Pokemon.NewPokemon(name);
            pokemon.Level = (int)level;
            if (ability != null) pokemon.Ability = ability;
            if (nature != null) pokemon.Nature = (PokemonNature)nature;
            if (item != null) pokemon.HeldItem = item;
            pokemon.Moves = new();
            foreach (Move m in moves) pokemon.Moves.Add(m);
            pokemon.CalculateStats();
            pokemon.CurrentHP = (int)pokemon.Stats.HP;
            party.Pokemons.Add(pokemon);
            return party;
        }
    }
}

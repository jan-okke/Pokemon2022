using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Exceptions;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon2022.Game.Logic
{
    public class GameController
    {
        public static List<Move> GetMovesAtLevel(Pokemon pokemon, int level)
        {
            List<Move> moves = new();
            foreach (int key in pokemon.LevelUpLearnset.Keys)
            {
                if (key <= level)
                {
                    foreach (Move m in pokemon.LevelUpLearnset[key])
                    {
                        moves.Add(m);
                    }
                }
            }
            return moves;
        }
        public static Item GetItem(string name)
        {
            return new()
            {
                Name = name,
                Description = "not implemented."
            };
        }
        public static Move GetMove(string name)
        {
            foreach (Move m in MoveFactory.Moves)
            {
                if (m.Name == name)
                {
                    Move move = m.Clone();
                    move.PowerPointsLeft = move.PowerPoints;
                    return move;
                }
            }
            throw new InvalidMoveException(name);
        }
        public static Ability GetAbility(string name)
        {
            foreach (Ability a in AbilityFactory.Abilities)
            {
                if (a.Name == name)
                {
                    return a.Clone();
                }
            }
            throw new InvalidAbilityException(name);
        }
        public static Pokemon NewPokemon(string name, int level)
        {
            foreach (Pokemon p in PokemonFactory.Pokemons)
            {
                if (p.Name == name)
                {
                    Pokemon pokemon = p.Clone();
                    pokemon.Level = level;
                    pokemon.CalculateStats();
                    pokemon.CurrentHP = (int)pokemon.Stats.HP;
                    pokemon.IsAlive = true;
                    if (pokemon.Types.Length == 1)
                    {
                        pokemon.Types = new PokemonType[] { pokemon.Types[0], PokemonType.None };
                    }
                    return pokemon;
                }
            }
            throw new InvalidPokemonNameException(name);
        }
        public static Pokemon NewPokemon(string name, int level, List<Move> moves)
        {
            Pokemon pokemon = NewPokemon(name, level);
            pokemon.Moves = moves;
            return pokemon;
        }
        public static Battle StartWildBattle(PokemonParty playerParty, string name, int level)
        {
            return new Battle() {
                PlayerParty = playerParty,
                EnemyParty = new() { Pokemons = new() { NewPokemon(name, level) } },
                IsWildBattle = true,
                IsTrainerBattle = false,
                Turn = 0,
                BattleType = BattleType.SingleBattle
            };
        }
        public static Battle StartTrainerBattle(PokemonParty playerParty, PokemonParty enemyParty)
        {
            return new Battle()
            {
                PlayerParty = playerParty,
                EnemyParty = enemyParty,
                IsWildBattle = false,
                IsTrainerBattle = true,
                Turn = 0,
                BattleType = BattleType.SingleBattle
            };
        }

        public static Move RandomMove(Pokemon pokemon)
        {
            Random random = new();
            return pokemon.Moves[random.Next(0, pokemon.Moves.Count)];
        }
    }
}

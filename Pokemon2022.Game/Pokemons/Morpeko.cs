using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Morpeko : Pokemon
	{
		public override string Name => "Morpeko";
		public override int Generation => 8;
		public override string PokedexEntry => "As it eats the seeds stored up in its pocket-like pouches, this Pokémon is not just satisfying its constant hunger. It's also generating electricity.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Electric, PokemonType.Dark };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.HungerSwitch, };
		public override Stats BaseStats => new Stats() {
			HP = 58,
			Attack = 95,
			Defense = 58,
			SpecialAttack = 70,
			SpecialDefense = 58,
			Speed = 97
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.ThunderShock, MoveFactory.TailWhip, },
			[5] = new List<Move>() { MoveFactory.Leer, },
			[10] = new List<Move>() { MoveFactory.PowerTrip, },
			[15] = new List<Move>() { MoveFactory.QuickAttack, },
			[20] = new List<Move>() { MoveFactory.Flatter, },
			[25] = new List<Move>() { MoveFactory.Bite, },
			[30] = new List<Move>() { MoveFactory.Spark, },
			[35] = new List<Move>() { MoveFactory.Torment, },
			[40] = new List<Move>() { MoveFactory.Agility, },
			[45] = new List<Move>() { MoveFactory.BulletSeed, },
			[50] = new List<Move>() { MoveFactory.Crunch, },
			[55] = new List<Move>() { MoveFactory.AuraWheel, },
			[60] = new List<Move>() { MoveFactory.Thrash, },
		};
	}
}

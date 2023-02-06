using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Charjabug : Pokemon
	{
		public override string Name => "Charjabug";
		public override int Generation => 7;
		public override string PokedexEntry => "It buries itself in fallen leaves and barely moves, munching away on humus. If you accidentally step on one, you'll get a shock!";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Bug, PokemonType.Electric };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Battery, };
		public override Stats BaseStats => new Stats() {
			HP = 57,
			Attack = 82,
			Defense = 95,
			SpecialAttack = 55,
			SpecialDefense = 75,
			Speed = 36
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[0] = new List<Move>() { MoveFactory.Charge, },
			[1] = new List<Move>() { MoveFactory.Charge, MoveFactory.ViseGrip, MoveFactory.MudSlap, MoveFactory.StringShot, MoveFactory.BugBite, },
			[15] = new List<Move>() { MoveFactory.Bite, },
			[23] = new List<Move>() { MoveFactory.Spark, },
			[29] = new List<Move>() { MoveFactory.StickyWeb, },
			[36] = new List<Move>() { MoveFactory.XScissor, },
			[43] = new List<Move>() { MoveFactory.Crunch, },
			[50] = new List<Move>() { MoveFactory.Dig, },
			[57] = new List<Move>() { MoveFactory.IronDefense, },
			[64] = new List<Move>() { MoveFactory.Discharge, },
		};
	}
}

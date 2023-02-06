using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Vikavolt : Pokemon
	{
		public override string Name => "Vikavolt";
		public override int Generation => 7;
		public override string PokedexEntry => "It zips around, on sharp lookout for an opening. It concentrates electrical energy within its large jaws and uses it to zap its enemies.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Bug, PokemonType.Electric };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Levitate, };
		public override Stats BaseStats => new Stats() {
			HP = 77,
			Attack = 70,
			Defense = 90,
			SpecialAttack = 145,
			SpecialDefense = 75,
			Speed = 43
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[0] = new List<Move>() { MoveFactory.Thunderbolt, },
			[1] = new List<Move>() { MoveFactory.Thunderbolt, MoveFactory.Charge, MoveFactory.XScissor, MoveFactory.Crunch, MoveFactory.Dig, MoveFactory.IronDefense, MoveFactory.Discharge, MoveFactory.ViseGrip, MoveFactory.MudSlap, MoveFactory.StringShot, MoveFactory.BugBite, },
			[15] = new List<Move>() { MoveFactory.Bite, },
			[23] = new List<Move>() { MoveFactory.Spark, },
			[29] = new List<Move>() { MoveFactory.StickyWeb, },
			[36] = new List<Move>() { MoveFactory.BugBuzz, },
			[43] = new List<Move>() { MoveFactory.Guillotine, },
			[50] = new List<Move>() { MoveFactory.Fly, },
			[57] = new List<Move>() { MoveFactory.Agility, },
			[64] = new List<Move>() { MoveFactory.ZapCannon, },
		};
	}
}

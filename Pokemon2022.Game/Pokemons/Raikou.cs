using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Raikou : Pokemon
	{
		public override string Name => "Raikou";
		public override int Generation => 2;
		public override string PokedexEntry => "Raikou embodies the speed of lightning. Its roars send shock waves shuddering through the air and ground as if lightning bolts were crashing down.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Electric };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Pressure, };
		public override Ability AvailableHiddenAbility => AbilityFactory.InnerFocus;
		public override Stats BaseStats => new Stats() {
			HP = 90,
			Attack = 85,
			Defense = 75,
			SpecialAttack = 115,
			SpecialDefense = 100,
			Speed = 115
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.ExtremeSpeed, MoveFactory.ThunderShock, MoveFactory.Leer, MoveFactory.Charge, MoveFactory.QuickAttack, },
			[6] = new List<Move>() { MoveFactory.Spark, },
			[12] = new List<Move>() { MoveFactory.Bite, },
			[18] = new List<Move>() { MoveFactory.CalmMind, },
			[24] = new List<Move>() { MoveFactory.Roar, },
			[30] = new List<Move>() { MoveFactory.ThunderFang, },
			[36] = new List<Move>() { MoveFactory.Howl, },
			[42] = new List<Move>() { MoveFactory.Crunch, },
			[48] = new List<Move>() { MoveFactory.Extrasensory, },
			[54] = new List<Move>() { MoveFactory.Discharge, },
			[60] = new List<Move>() { MoveFactory.Reflect, },
			[66] = new List<Move>() { MoveFactory.RainDance, },
			[72] = new List<Move>() { MoveFactory.Thunder, },
			[78] = new List<Move>() { MoveFactory.ZapCannon, },
		};
	}
}

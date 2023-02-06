using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Dracozolt : Pokemon
	{
		public override string Name => "Dracozolt";
		public override int Generation => 8;
		public override string PokedexEntry => "In ancient times, it was unbeatable thanks to its powerful lower body, but it went extinct anyway after it depleted all its plant-based food sources.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Electric, PokemonType.Dragon };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.VoltAbsorb, AbilityFactory.Hustle, };
		public override Ability AvailableHiddenAbility => AbilityFactory.SandRush;
		public override Stats BaseStats => new Stats() {
			HP = 90,
			Attack = 100,
			Defense = 90,
			SpecialAttack = 80,
			SpecialDefense = 70,
			Speed = 75
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Tackle, MoveFactory.ThunderShock, },
			[7] = new List<Move>() { MoveFactory.Charge, },
			[14] = new List<Move>() { MoveFactory.AerialAce, },
			[21] = new List<Move>() { MoveFactory.AncientPower, },
			[28] = new List<Move>() { MoveFactory.Pluck, },
			[35] = new List<Move>() { MoveFactory.DragonTail, },
			[42] = new List<Move>() { MoveFactory.Stomp, },
			[49] = new List<Move>() { MoveFactory.Slam, },
			[56] = new List<Move>() { MoveFactory.Discharge, },
			[63] = new List<Move>() { MoveFactory.BoltBeak, },
			[70] = new List<Move>() { MoveFactory.DragonPulse, },
			[77] = new List<Move>() { MoveFactory.DragonRush, },
		};
	}
}

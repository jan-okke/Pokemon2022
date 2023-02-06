using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Zapdos : Pokemon
	{
		public override string Name => "Zapdos";
		public override int Generation => 1;
		public override string PokedexEntry => "Zapdos is a legendary bird Pokémon that has the ability to control electricity. It usually lives in thunderclouds. It gains power if it is stricken by lightning bolts.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Electric, PokemonType.Flying };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Pressure, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Static;
		public override Stats BaseStats => new Stats() {
			HP = 90,
			Attack = 90,
			Defense = 85,
			SpecialAttack = 125,
			SpecialDefense = 90,
			Speed = 100
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Peck, MoveFactory.ThunderWave, },
			[5] = new List<Move>() { MoveFactory.ThunderShock, },
			[10] = new List<Move>() { MoveFactory.LightScreen, },
			[15] = new List<Move>() { MoveFactory.Pluck, },
			[20] = new List<Move>() { MoveFactory.Agility, },
			[25] = new List<Move>() { MoveFactory.AncientPower, },
			[30] = new List<Move>() { MoveFactory.Charge, },
			[35] = new List<Move>() { MoveFactory.DrillPeck, },
			[40] = new List<Move>() { MoveFactory.Roost, },
			[45] = new List<Move>() { MoveFactory.Discharge, },
			[50] = new List<Move>() { MoveFactory.RainDance, },
			[55] = new List<Move>() { MoveFactory.Thunder, },
			[60] = new List<Move>() { MoveFactory.Detect, },
			[65] = new List<Move>() { MoveFactory.MagneticFlux, },
			[70] = new List<Move>() { MoveFactory.ZapCannon, },
		};
	}
}

using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Luxray : Pokemon
	{
		public override string Name => "Luxray";
		public override int Generation => 4;
		public override string PokedexEntry => "It has eyes that can see through anything. It spots and captures prey hiding behind objects.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Electric };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Rivalry, AbilityFactory.Intimidate, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Guts;
		public override Stats BaseStats => new Stats() {
			HP = 80,
			Attack = 120,
			Defense = 79,
			SpecialAttack = 95,
			SpecialDefense = 79,
			Speed = 70
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.ElectricTerrain, MoveFactory.Tackle, MoveFactory.Leer, MoveFactory.ThunderShock, MoveFactory.Charge, },
			[12] = new List<Move>() { MoveFactory.Bite, },
			[18] = new List<Move>() { MoveFactory.Spark, },
			[24] = new List<Move>() { MoveFactory.Roar, },
			[33] = new List<Move>() { MoveFactory.VoltSwitch, },
			[40] = new List<Move>() { MoveFactory.ScaryFace, },
			[48] = new List<Move>() { MoveFactory.ThunderWave, },
			[56] = new List<Move>() { MoveFactory.Crunch, },
			[64] = new List<Move>() { MoveFactory.Discharge, },
			[72] = new List<Move>() { MoveFactory.Swagger, },
			[80] = new List<Move>() { MoveFactory.WildCharge, },
		};
	}
}

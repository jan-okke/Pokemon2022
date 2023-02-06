using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Pincurchin : Pokemon
	{
		public override string Name => "Pincurchin";
		public override int Generation => 8;
		public override string PokedexEntry => "It stores electricity in each spine. Even if one gets broken off, it still continues to emit electricity for at least three hours.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Electric };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.LightningRod, };
		public override Ability AvailableHiddenAbility => AbilityFactory.ElectricSurge;
		public override Stats BaseStats => new Stats() {
			HP = 48,
			Attack = 101,
			Defense = 95,
			SpecialAttack = 91,
			SpecialDefense = 85,
			Speed = 15
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Peck, MoveFactory.ThunderShock, },
			[5] = new List<Move>() { MoveFactory.WaterGun, },
			[10] = new List<Move>() { MoveFactory.Charge, },
			[15] = new List<Move>() { MoveFactory.FuryAttack, },
			[20] = new List<Move>() { MoveFactory.Spark, },
			[25] = new List<Move>() { MoveFactory.BubbleBeam, },
			[30] = new List<Move>() { MoveFactory.Recover, },
			[35] = new List<Move>() { MoveFactory.Curse, },
			[40] = new List<Move>() { MoveFactory.ElectricTerrain, },
			[45] = new List<Move>() { MoveFactory.PoisonJab, },
			[50] = new List<Move>() { MoveFactory.ZingZap, },
			[55] = new List<Move>() { MoveFactory.Acupressure, },
			[60] = new List<Move>() { MoveFactory.Discharge, },
		};
	}
}

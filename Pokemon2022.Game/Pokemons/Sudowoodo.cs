using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Sudowoodo : Pokemon
	{
		public override string Name => "Sudowoodo";
		public override int Generation => 2;
		public override string PokedexEntry => "It mimics a tree to avoid being attacked by enemies. But since its forelegs remain green throughout the year, it is easily identified as a fake in the winter.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Rock };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Sturdy, AbilityFactory.RockHead, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Rattled;
		public override Stats BaseStats => new Stats() {
			HP = 70,
			Attack = 100,
			Defense = 115,
			SpecialAttack = 30,
			SpecialDefense = 65,
			Speed = 30
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[0] = new List<Move>() { MoveFactory.Slam, },
			[1] = new List<Move>() { MoveFactory.Slam, MoveFactory.StoneEdge, MoveFactory.HammerArm, MoveFactory.WoodHammer, MoveFactory.FakeTears, MoveFactory.Copycat, MoveFactory.Flail, MoveFactory.RockThrow, },
			[12] = new List<Move>() { MoveFactory.Block, },
			[16] = new List<Move>() { MoveFactory.Mimic, },
			[20] = new List<Move>() { MoveFactory.RockTomb, },
			[24] = new List<Move>() { MoveFactory.TearfulLook, },
			[28] = new List<Move>() { MoveFactory.SuckerPunch, },
			[32] = new List<Move>() { MoveFactory.RockSlide, },
			[36] = new List<Move>() { MoveFactory.LowKick, },
			[40] = new List<Move>() { MoveFactory.Counter, },
			[44] = new List<Move>() { MoveFactory.DoubleEdge, },
			[48] = new List<Move>() { MoveFactory.HeadSmash, },
		};
	}
}

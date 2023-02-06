using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Lairon : Pokemon
	{
		public override string Name => "Lairon";
		public override int Generation => 3;
		public override string PokedexEntry => "When two Lairon meet in the wild, they fight for territory by bashing into each other with their steel bodies. The sound of their collision carries for miles.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Steel, PokemonType.Rock };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Sturdy, AbilityFactory.RockHead, };
		public override Ability AvailableHiddenAbility => AbilityFactory.HeavyMetal;
		public override Stats BaseStats => new Stats() {
			HP = 60,
			Attack = 90,
			Defense = 140,
			SpecialAttack = 50,
			SpecialDefense = 50,
			Speed = 40
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Tackle, MoveFactory.Harden, MoveFactory.MetalClaw, MoveFactory.RockTomb, },
			[12] = new List<Move>() { MoveFactory.Roar, },
			[16] = new List<Move>() { MoveFactory.Headbutt, },
			[20] = new List<Move>() { MoveFactory.Protect, },
			[24] = new List<Move>() { MoveFactory.RockSlide, },
			[28] = new List<Move>() { MoveFactory.IronHead, },
			[35] = new List<Move>() { MoveFactory.MetalSound, },
			[40] = new List<Move>() { MoveFactory.TakeDown, },
			[46] = new List<Move>() { MoveFactory.Autotomize, },
			[52] = new List<Move>() { MoveFactory.IronTail, },
			[58] = new List<Move>() { MoveFactory.IronDefense, },
			[64] = new List<Move>() { MoveFactory.HeavySlam, },
			[70] = new List<Move>() { MoveFactory.DoubleEdge, },
			[76] = new List<Move>() { MoveFactory.MetalBurst, },
		};
	}
}

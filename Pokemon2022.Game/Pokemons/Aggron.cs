using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Aggron : Pokemon
	{
		public override string Name => "Aggron";
		public override int Generation => 3;
		public override string PokedexEntry => "Its iron horns grow longer a little at a time. They are used to determine the Aggron's age. The gouges in its armor are worn with pride as mementos from battles.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Steel, PokemonType.Rock };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Sturdy, AbilityFactory.RockHead, };
		public override Ability AvailableHiddenAbility => AbilityFactory.HeavyMetal;
		public override Stats BaseStats => new Stats() {
			HP = 70,
			Attack = 110,
			Defense = 180,
			SpecialAttack = 60,
			SpecialDefense = 60,
			Speed = 50
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
			[48] = new List<Move>() { MoveFactory.Autotomize, },
			[56] = new List<Move>() { MoveFactory.IronTail, },
			[64] = new List<Move>() { MoveFactory.IronDefense, },
			[72] = new List<Move>() { MoveFactory.HeavySlam, },
			[80] = new List<Move>() { MoveFactory.DoubleEdge, },
			[88] = new List<Move>() { MoveFactory.MetalBurst, },
		};
	}
}

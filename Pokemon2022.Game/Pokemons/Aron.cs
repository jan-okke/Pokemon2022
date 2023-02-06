using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Aron : Pokemon
	{
		public override string Name => "Aron";
		public override int Generation => 3;
		public override string PokedexEntry => "A Pokémon that is clad in steel armor. A new suit of armor is made when it evolves. The old, discarded armor is salvaged as metal for making iron products.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Steel, PokemonType.Rock };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Sturdy, AbilityFactory.RockHead, };
		public override Ability AvailableHiddenAbility => AbilityFactory.HeavyMetal;
		public override Stats BaseStats => new Stats() {
			HP = 50,
			Attack = 70,
			Defense = 100,
			SpecialAttack = 40,
			SpecialDefense = 40,
			Speed = 30
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Tackle, MoveFactory.Harden, },
			[4] = new List<Move>() { MoveFactory.MetalClaw, },
			[8] = new List<Move>() { MoveFactory.RockTomb, },
			[12] = new List<Move>() { MoveFactory.Roar, },
			[16] = new List<Move>() { MoveFactory.Headbutt, },
			[20] = new List<Move>() { MoveFactory.Protect, },
			[24] = new List<Move>() { MoveFactory.RockSlide, },
			[28] = new List<Move>() { MoveFactory.IronHead, },
			[33] = new List<Move>() { MoveFactory.MetalSound, },
			[36] = new List<Move>() { MoveFactory.TakeDown, },
			[40] = new List<Move>() { MoveFactory.Autotomize, },
			[44] = new List<Move>() { MoveFactory.IronTail, },
			[48] = new List<Move>() { MoveFactory.IronDefense, },
			[52] = new List<Move>() { MoveFactory.HeavySlam, },
			[56] = new List<Move>() { MoveFactory.DoubleEdge, },
			[60] = new List<Move>() { MoveFactory.MetalBurst, },
		};
	}
}

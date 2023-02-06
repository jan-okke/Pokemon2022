using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Registeel : Pokemon
	{
		public override string Name => "Registeel";
		public override int Generation => 3;
		public override string PokedexEntry => "Its body is harder than any other kind of metal. The body metal is composed of a mysterious substance. Not only is it hard, it shrinks and stretches flexibly.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Steel };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.ClearBody, };
		public override Ability AvailableHiddenAbility => AbilityFactory.LightMetal;
		public override Stats BaseStats => new Stats() {
			HP = 80,
			Attack = 75,
			Defense = 150,
			SpecialAttack = 75,
			SpecialDefense = 150,
			Speed = 50
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.ChargeBeam, MoveFactory.MetalClaw, },
			[6] = new List<Move>() { MoveFactory.Bulldoze, },
			[12] = new List<Move>() { MoveFactory.AncientPower, },
			[18] = new List<Move>() { MoveFactory.Stomp, },
			[24] = new List<Move>() { MoveFactory.IronHead, MoveFactory.FlashCannon, },
			[30] = new List<Move>() { MoveFactory.Curse, },
			[36] = new List<Move>() { MoveFactory.IronDefense, MoveFactory.Amnesia, },
			[42] = new List<Move>() { MoveFactory.HammerArm, },
			[48] = new List<Move>() { MoveFactory.HeavySlam, },
			[54] = new List<Move>() { MoveFactory.Superpower, },
			[60] = new List<Move>() { MoveFactory.LockOn, },
			[66] = new List<Move>() { MoveFactory.ZapCannon, },
			[72] = new List<Move>() { MoveFactory.HyperBeam, },
			[78] = new List<Move>() { MoveFactory.Explosion, },
		};
	}
}

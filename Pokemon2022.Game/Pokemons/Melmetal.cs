using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Melmetal : Pokemon
	{
		public override string Name => "Melmetal";
		public override int Generation => 7;
		public override string PokedexEntry => "Revered long ago for its capacity to create iron from nothing, for some reason it has come back to life after 3,000 years.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Steel };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.IronFist, };
		public override Stats BaseStats => new Stats() {
			HP = 135,
			Attack = 143,
			Defense = 143,
			SpecialAttack = 80,
			SpecialDefense = 65,
			Speed = 34
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[0] = new List<Move>() { MoveFactory.ThunderPunch, },
			[1] = new List<Move>() { MoveFactory.ThunderPunch, MoveFactory.ThunderShock, MoveFactory.Harden, MoveFactory.TailWhip, MoveFactory.Headbutt, },
			[24] = new List<Move>() { MoveFactory.ThunderWave, },
			[32] = new List<Move>() { MoveFactory.AcidArmor, },
			[40] = new List<Move>() { MoveFactory.FlashCannon, },
			[48] = new List<Move>() { MoveFactory.MegaPunch, },
			[56] = new List<Move>() { MoveFactory.Protect, },
			[64] = new List<Move>() { MoveFactory.Discharge, },
			[72] = new List<Move>() { MoveFactory.DynamicPunch, },
			[80] = new List<Move>() { MoveFactory.Superpower, },
			[88] = new List<Move>() { MoveFactory.DoubleIronBash, },
			[96] = new List<Move>() { MoveFactory.HyperBeam, },
		};
	}
}

using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Klinklang : Pokemon
	{
		public override string Name => "Klinklang";
		public override int Generation => 5;
		public override string PokedexEntry => "The gear with the red core is rotated at high speed for a rapid energy charge.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Steel };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Plus, AbilityFactory.Minus, };
		public override Ability AvailableHiddenAbility => AbilityFactory.ClearBody;
		public override Stats BaseStats => new Stats() {
			HP = 60,
			Attack = 100,
			Defense = 115,
			SpecialAttack = 70,
			SpecialDefense = 85,
			Speed = 90
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.GearUp, MoveFactory.MagneticFlux, MoveFactory.ThunderShock, MoveFactory.ViseGrip, MoveFactory.Bind, MoveFactory.Charge, },
			[12] = new List<Move>() { MoveFactory.ChargeBeam, },
			[16] = new List<Move>() { MoveFactory.MetalSound, },
			[20] = new List<Move>() { MoveFactory.Autotomize, },
			[24] = new List<Move>() { MoveFactory.Discharge, },
			[28] = new List<Move>() { MoveFactory.Screech, },
			[32] = new List<Move>() { MoveFactory.GearGrind, },
			[36] = new List<Move>() { MoveFactory.LockOn, },
			[42] = new List<Move>() { MoveFactory.ShiftGear, },
			[48] = new List<Move>() { MoveFactory.ZapCannon, },
			[56] = new List<Move>() { MoveFactory.HyperBeam, },
			[64] = new List<Move>() { MoveFactory.ElectricTerrain, },
		};
	}
}

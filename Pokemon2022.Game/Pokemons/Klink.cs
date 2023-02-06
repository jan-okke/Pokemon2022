using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Klink : Pokemon
	{
		public override string Name => "Klink";
		public override int Generation => 5;
		public override string PokedexEntry => "Interlocking two bodies and spinning around generates the energy they need to live.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Steel };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Plus, AbilityFactory.Minus, };
		public override Ability AvailableHiddenAbility => AbilityFactory.ClearBody;
		public override Stats BaseStats => new Stats() {
			HP = 40,
			Attack = 55,
			Defense = 70,
			SpecialAttack = 45,
			SpecialDefense = 60,
			Speed = 30
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.ThunderShock, MoveFactory.ViseGrip, },
			[4] = new List<Move>() { MoveFactory.Bind, },
			[8] = new List<Move>() { MoveFactory.Charge, },
			[12] = new List<Move>() { MoveFactory.ChargeBeam, },
			[16] = new List<Move>() { MoveFactory.MetalSound, },
			[20] = new List<Move>() { MoveFactory.Autotomize, },
			[24] = new List<Move>() { MoveFactory.Discharge, },
			[28] = new List<Move>() { MoveFactory.Screech, },
			[32] = new List<Move>() { MoveFactory.GearGrind, },
			[36] = new List<Move>() { MoveFactory.LockOn, },
			[40] = new List<Move>() { MoveFactory.ShiftGear, },
			[44] = new List<Move>() { MoveFactory.ZapCannon, },
			[48] = new List<Move>() { MoveFactory.HyperBeam, },
		};
	}
}

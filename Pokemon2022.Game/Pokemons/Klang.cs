using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Klang : Pokemon
	{
		public override string Name => "Klang";
		public override int Generation => 5;
		public override string PokedexEntry => "Spinning minigears are rotated at high speed and repeatedly fired away. It is dangerous if the gears don't return.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Steel };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Plus, AbilityFactory.Minus, };
		public override Ability AvailableHiddenAbility => AbilityFactory.ClearBody;
		public override Stats BaseStats => new Stats() {
			HP = 60,
			Attack = 80,
			Defense = 95,
			SpecialAttack = 70,
			SpecialDefense = 85,
			Speed = 50
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.ThunderShock, MoveFactory.ViseGrip, MoveFactory.Bind, MoveFactory.Charge, },
			[12] = new List<Move>() { MoveFactory.ChargeBeam, },
			[16] = new List<Move>() { MoveFactory.MetalSound, },
			[20] = new List<Move>() { MoveFactory.Autotomize, },
			[24] = new List<Move>() { MoveFactory.Discharge, },
			[28] = new List<Move>() { MoveFactory.Screech, },
			[32] = new List<Move>() { MoveFactory.GearGrind, },
			[36] = new List<Move>() { MoveFactory.LockOn, },
			[42] = new List<Move>() { MoveFactory.ShiftGear, },
			[48] = new List<Move>() { MoveFactory.ZapCannon, },
			[54] = new List<Move>() { MoveFactory.HyperBeam, },
		};
	}
}

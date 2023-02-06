using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Electivire : Pokemon
	{
		public override string Name => "Electivire";
		public override int Generation => 4;
		public override string PokedexEntry => "It pushes the tips of its two tails against the foe, then lets loose with over 20,000 volts of power.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Electric };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.MotorDrive, };
		public override Ability AvailableHiddenAbility => AbilityFactory.VitalSpirit;
		public override Stats BaseStats => new Stats() {
			HP = 75,
			Attack = 123,
			Defense = 67,
			SpecialAttack = 95,
			SpecialDefense = 85,
			Speed = 95
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.WildCharge, MoveFactory.QuickAttack, MoveFactory.Leer, MoveFactory.ThunderShock, MoveFactory.Charge, },
			[12] = new List<Move>() { MoveFactory.Swift, },
			[16] = new List<Move>() { MoveFactory.ShockWave, },
			[20] = new List<Move>() { MoveFactory.ThunderWave, },
			[24] = new List<Move>() { MoveFactory.Screech, },
			[28] = new List<Move>() { MoveFactory.ThunderPunch, },
			[34] = new List<Move>() { MoveFactory.Discharge, },
			[40] = new List<Move>() { MoveFactory.LowKick, },
			[46] = new List<Move>() { MoveFactory.Thunderbolt, },
			[52] = new List<Move>() { MoveFactory.LightScreen, },
			[58] = new List<Move>() { MoveFactory.Thunder, },
			[64] = new List<Move>() { MoveFactory.GigaImpact, },
		};
	}
}

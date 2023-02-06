using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Elekid : Pokemon
	{
		public override string Name => "Elekid";
		public override int Generation => 2;
		public override string PokedexEntry => "If it touches metal and discharges the electricity it has stored in its body, an Elekid begins swinging its arms in circles to recharge itself.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Electric };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Static, };
		public override Ability AvailableHiddenAbility => AbilityFactory.VitalSpirit;
		public override Stats BaseStats => new Stats() {
			HP = 45,
			Attack = 63,
			Defense = 37,
			SpecialAttack = 65,
			SpecialDefense = 55,
			Speed = 95
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.QuickAttack, MoveFactory.Leer, },
			[4] = new List<Move>() { MoveFactory.ThunderShock, },
			[8] = new List<Move>() { MoveFactory.Charge, },
			[12] = new List<Move>() { MoveFactory.Swift, },
			[16] = new List<Move>() { MoveFactory.ShockWave, },
			[20] = new List<Move>() { MoveFactory.ThunderWave, },
			[24] = new List<Move>() { MoveFactory.Screech, },
			[28] = new List<Move>() { MoveFactory.ThunderPunch, },
			[32] = new List<Move>() { MoveFactory.Discharge, },
			[36] = new List<Move>() { MoveFactory.LowKick, },
			[40] = new List<Move>() { MoveFactory.Thunderbolt, },
			[44] = new List<Move>() { MoveFactory.LightScreen, },
			[48] = new List<Move>() { MoveFactory.Thunder, },
		};
	}
}

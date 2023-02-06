using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Electabuzz : Pokemon
	{
		public override string Name => "Electabuzz";
		public override int Generation => 1;
		public override string PokedexEntry => "When a storm approaches, it competes with others to scale heights that are likely to be stricken by lightning. Some towns use Electabuzz as lightning rods.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Electric };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Static, };
		public override Ability AvailableHiddenAbility => AbilityFactory.VitalSpirit;
		public override Stats BaseStats => new Stats() {
			HP = 65,
			Attack = 83,
			Defense = 57,
			SpecialAttack = 95,
			SpecialDefense = 85,
			Speed = 105
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.QuickAttack, MoveFactory.Leer, MoveFactory.ThunderShock, MoveFactory.Charge, },
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

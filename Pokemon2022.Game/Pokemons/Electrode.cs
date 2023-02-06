using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Electrode : Pokemon
	{
		public override string Name => "Electrode";
		public override int Generation => 1;
		public override string PokedexEntry => "They appear in great numbers at electric power plants. Because they feed on electricity, they cause massive and chaotic blackouts in nearby cities.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Electric };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Soundproof, AbilityFactory.Static, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Aftermath;
		public override Stats BaseStats => new Stats() {
			HP = 60,
			Attack = 50,
			Defense = 70,
			SpecialAttack = 80,
			SpecialDefense = 80,
			Speed = 150
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.MagneticFlux, MoveFactory.Charge, MoveFactory.Tackle, MoveFactory.EerieImpulse, },
			[4] = new List<Move>() { MoveFactory.ThunderShock, },
			[6] = new List<Move>() { MoveFactory.EerieImpulse, },
			[9] = new List<Move>() { MoveFactory.Spark, },
			[11] = new List<Move>() { MoveFactory.Rollout, },
			[13] = new List<Move>() { MoveFactory.Screech, },
			[16] = new List<Move>() { MoveFactory.ChargeBeam, },
			[20] = new List<Move>() { MoveFactory.Swift, },
			[22] = new List<Move>() { MoveFactory.ElectroBall, },
			[26] = new List<Move>() { MoveFactory.SelfDestruct, },
			[29] = new List<Move>() { MoveFactory.LightScreen, },
			[36] = new List<Move>() { MoveFactory.MagnetRise, },
			[41] = new List<Move>() { MoveFactory.Discharge, },
			[47] = new List<Move>() { MoveFactory.Explosion, },
			[54] = new List<Move>() { MoveFactory.GyroBall, },
			[58] = new List<Move>() { MoveFactory.MirrorCoat, },
		};
	}
}

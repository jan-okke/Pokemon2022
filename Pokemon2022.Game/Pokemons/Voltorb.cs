using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Voltorb : Pokemon
	{
		public override string Name => "Voltorb";
		public override int Generation => 1;
		public override string PokedexEntry => "It bears an uncanny and unexplained resemblance to a Poké Ball. Because it explodes at the slightest shock, even veteran trainers treat it with caution.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Electric };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Soundproof, AbilityFactory.Static, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Aftermath;
		public override Stats BaseStats => new Stats() {
			HP = 40,
			Attack = 30,
			Defense = 50,
			SpecialAttack = 55,
			SpecialDefense = 55,
			Speed = 100
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Charge, MoveFactory.Tackle, },
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
			[34] = new List<Move>() { MoveFactory.MagnetRise, },
			[37] = new List<Move>() { MoveFactory.Discharge, },
			[41] = new List<Move>() { MoveFactory.Explosion, },
			[46] = new List<Move>() { MoveFactory.GyroBall, },
			[48] = new List<Move>() { MoveFactory.MirrorCoat, },
		};
	}
}

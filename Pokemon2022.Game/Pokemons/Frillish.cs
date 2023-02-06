using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Frillish : Pokemon
	{
		public override string Name => "Frillish";
		public override int Generation => 5;
		public override string PokedexEntry => "They paralyze prey with poison, then drag them down to their lairs, five miles below the surface.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Water, PokemonType.Ghost };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.WaterAbsorb, AbilityFactory.CursedBody, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Damp;
		public override Stats BaseStats => new Stats() {
			HP = 55,
			Attack = 40,
			Defense = 50,
			SpecialAttack = 65,
			SpecialDefense = 85,
			Speed = 40
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Absorb, MoveFactory.WaterGun, },
			[4] = new List<Move>() { MoveFactory.PoisonSting, },
			[8] = new List<Move>() { MoveFactory.NightShade, },
			[12] = new List<Move>() { MoveFactory.WaterPulse, },
			[16] = new List<Move>() { MoveFactory.RainDance, },
			[20] = new List<Move>() { MoveFactory.Hex, },
			[24] = new List<Move>() { MoveFactory.Brine, },
			[28] = new List<Move>() { MoveFactory.Recover, },
			[32] = new List<Move>() { MoveFactory.ShadowBall, },
			[36] = new List<Move>() { MoveFactory.Whirlpool, },
			[41] = new List<Move>() { MoveFactory.HydroPump, },
			[44] = new List<Move>() { MoveFactory.DestinyBond, },
			[48] = new List<Move>() { MoveFactory.WaterSpout, },
		};
	}
}

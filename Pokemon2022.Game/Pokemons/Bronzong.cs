using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Bronzong : Pokemon
	{
		public override string Name => "Bronzong";
		public override int Generation => 4;
		public override string PokedexEntry => "One caused a news sensation when it was dug up at a construction site after a 2,000-year sleep.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Steel, PokemonType.Psychic };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Levitate, AbilityFactory.Heatproof, };
		public override Ability AvailableHiddenAbility => AbilityFactory.HeavyMetal;
		public override Stats BaseStats => new Stats() {
			HP = 67,
			Attack = 89,
			Defense = 116,
			SpecialAttack = 79,
			SpecialDefense = 116,
			Speed = 33
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[0] = new List<Move>() { MoveFactory.Block, },
			[1] = new List<Move>() { MoveFactory.Block, MoveFactory.SunnyDay, MoveFactory.WeatherBall, MoveFactory.Tackle, MoveFactory.Confusion, MoveFactory.ConfuseRay, MoveFactory.Payback, },
			[12] = new List<Move>() { MoveFactory.Imprison, },
			[16] = new List<Move>() { MoveFactory.GyroBall, },
			[20] = new List<Move>() { MoveFactory.Hypnosis, },
			[24] = new List<Move>() { MoveFactory.Safeguard, },
			[28] = new List<Move>() { MoveFactory.Extrasensory, },
			[32] = new List<Move>() { MoveFactory.HeavySlam, },
			[38] = new List<Move>() { MoveFactory.IronDefense, },
			[44] = new List<Move>() { MoveFactory.MetalSound, },
			[50] = new List<Move>() { MoveFactory.FutureSight, },
			[56] = new List<Move>() { MoveFactory.RainDance, },
		};
	}
}

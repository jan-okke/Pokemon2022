using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Bronzor : Pokemon
	{
		public override string Name => "Bronzor";
		public override int Generation => 4;
		public override string PokedexEntry => "Implements shaped like it were discovered in ancient tombs. It is unknown if they are related.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Steel, PokemonType.Psychic };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Levitate, AbilityFactory.Heatproof, };
		public override Ability AvailableHiddenAbility => AbilityFactory.HeavyMetal;
		public override Stats BaseStats => new Stats() {
			HP = 57,
			Attack = 24,
			Defense = 86,
			SpecialAttack = 24,
			SpecialDefense = 86,
			Speed = 23
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Tackle, MoveFactory.Confusion, },
			[4] = new List<Move>() { MoveFactory.ConfuseRay, },
			[8] = new List<Move>() { MoveFactory.Payback, },
			[12] = new List<Move>() { MoveFactory.Imprison, },
			[16] = new List<Move>() { MoveFactory.GyroBall, },
			[20] = new List<Move>() { MoveFactory.Hypnosis, },
			[24] = new List<Move>() { MoveFactory.Safeguard, },
			[28] = new List<Move>() { MoveFactory.Extrasensory, },
			[32] = new List<Move>() { MoveFactory.HeavySlam, },
			[36] = new List<Move>() { MoveFactory.IronDefense, },
			[40] = new List<Move>() { MoveFactory.MetalSound, },
			[44] = new List<Move>() { MoveFactory.FutureSight, },
		};
	}
}

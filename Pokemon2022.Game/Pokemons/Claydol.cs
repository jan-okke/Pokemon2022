using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Claydol : Pokemon
	{
		public override string Name => "Claydol";
		public override int Generation => 3;
		public override string PokedexEntry => "A Claydol sleeps while hovering in midair. Its arms are separate from its body. They are kept floating by the Pokémon's manipulation of psychic power.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Ground, PokemonType.Psychic };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Levitate, };
		public override Stats BaseStats => new Stats() {
			HP = 60,
			Attack = 70,
			Defense = 105,
			SpecialAttack = 70,
			SpecialDefense = 120,
			Speed = 75
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[0] = new List<Move>() { MoveFactory.HyperBeam, },
			[1] = new List<Move>() { MoveFactory.HyperBeam, MoveFactory.Teleport, MoveFactory.Harden, MoveFactory.MudSlap, MoveFactory.RapidSpin, MoveFactory.Confusion, },
			[9] = new List<Move>() { MoveFactory.RockTomb, },
			[12] = new List<Move>() { MoveFactory.PowerTrick, },
			[15] = new List<Move>() { MoveFactory.Psybeam, },
			[18] = new List<Move>() { MoveFactory.AncientPower, },
			[21] = new List<Move>() { MoveFactory.Imprison, },
			[24] = new List<Move>() { MoveFactory.CosmicPower, },
			[27] = new List<Move>() { MoveFactory.Extrasensory, },
			[30] = new List<Move>() { MoveFactory.EarthPower, },
			[33] = new List<Move>() { MoveFactory.SelfDestruct, },
			[38] = new List<Move>() { MoveFactory.GuardSplit, MoveFactory.PowerSplit, },
			[43] = new List<Move>() { MoveFactory.Sandstorm, },
			[48] = new List<Move>() { MoveFactory.Explosion, },
		};
	}
}

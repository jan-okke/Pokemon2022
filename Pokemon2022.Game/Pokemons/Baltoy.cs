using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Baltoy : Pokemon
	{
		public override string Name => "Baltoy";
		public override int Generation => 3;
		public override string PokedexEntry => "A Baltoy moves by spinning on its single foot. It has been depicted in murals adorning the walls of a once-bustling city in an ancient age.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Ground, PokemonType.Psychic };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Levitate, };
		public override Stats BaseStats => new Stats() {
			HP = 40,
			Attack = 40,
			Defense = 55,
			SpecialAttack = 40,
			SpecialDefense = 70,
			Speed = 55
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Harden, MoveFactory.MudSlap, },
			[3] = new List<Move>() { MoveFactory.RapidSpin, },
			[6] = new List<Move>() { MoveFactory.Confusion, },
			[9] = new List<Move>() { MoveFactory.RockTomb, },
			[12] = new List<Move>() { MoveFactory.PowerTrick, },
			[15] = new List<Move>() { MoveFactory.Psybeam, },
			[18] = new List<Move>() { MoveFactory.AncientPower, },
			[21] = new List<Move>() { MoveFactory.Imprison, },
			[24] = new List<Move>() { MoveFactory.CosmicPower, },
			[27] = new List<Move>() { MoveFactory.Extrasensory, },
			[30] = new List<Move>() { MoveFactory.EarthPower, },
			[33] = new List<Move>() { MoveFactory.SelfDestruct, },
			[36] = new List<Move>() { MoveFactory.GuardSplit, MoveFactory.PowerSplit, },
			[39] = new List<Move>() { MoveFactory.Sandstorm, },
			[42] = new List<Move>() { MoveFactory.Explosion, },
		};
	}
}

using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Mothim : Pokemon
	{
		public override string Name => "Mothim";
		public override int Generation => 4;
		public override string PokedexEntry => "It loves the honey of flowers and steals honey collected by Combee.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Bug, PokemonType.Flying };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Swarm, };
		public override Ability AvailableHiddenAbility => AbilityFactory.TintedLens;
		public override Stats BaseStats => new Stats() {
			HP = 70,
			Attack = 94,
			Defense = 50,
			SpecialAttack = 94,
			SpecialDefense = 50,
			Speed = 66
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[0] = new List<Move>() { MoveFactory.QuiverDance, },
			[1] = new List<Move>() { MoveFactory.QuiverDance, MoveFactory.Tackle, MoveFactory.Protect, MoveFactory.BugBite, },
			[10] = new List<Move>() { MoveFactory.Protect, },
			[15] = new List<Move>() { MoveFactory.BugBite, },
			[20] = new List<Move>() { MoveFactory.StringShot, },
			[23] = new List<Move>() { MoveFactory.Confusion, },
			[26] = new List<Move>() { MoveFactory.Gust, },
			[29] = new List<Move>() { MoveFactory.PoisonPowder, },
			[32] = new List<Move>() { MoveFactory.Psybeam, },
			[35] = new List<Move>() { MoveFactory.Roost, },
			[38] = new List<Move>() { MoveFactory.StruggleBug, },
			[41] = new List<Move>() { MoveFactory.AirSlash, },
			[44] = new List<Move>() { MoveFactory.Psychic, },
			[47] = new List<Move>() { MoveFactory.Lunge, },
			[50] = new List<Move>() { MoveFactory.BugBuzz, },
		};
	}
}

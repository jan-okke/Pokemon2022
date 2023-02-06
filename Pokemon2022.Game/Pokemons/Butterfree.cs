using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Butterfree : Pokemon
	{
		public override string Name => "Butterfree";
		public override int Generation => 1;
		public override string PokedexEntry => "It has a superior ability to search for delicious honey from flowers. It can seek, extract, and carry honey from flowers blooming over six miles away.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Bug, PokemonType.Flying };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.CompoundEyes, };
		public override Ability AvailableHiddenAbility => AbilityFactory.TintedLens;
		public override Stats BaseStats => new Stats() {
			HP = 60,
			Attack = 45,
			Defense = 50,
			SpecialAttack = 90,
			SpecialDefense = 80,
			Speed = 70
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[0] = new List<Move>() { MoveFactory.Gust, },
			[1] = new List<Move>() { MoveFactory.Gust, MoveFactory.Harden, MoveFactory.Tackle, MoveFactory.StringShot, MoveFactory.BugBite, },
			[4] = new List<Move>() { MoveFactory.Supersonic, },
			[8] = new List<Move>() { MoveFactory.Confusion, },
			[12] = new List<Move>() { MoveFactory.PoisonPowder, MoveFactory.StunSpore, MoveFactory.SleepPowder, },
			[16] = new List<Move>() { MoveFactory.Psybeam, },
			[20] = new List<Move>() { MoveFactory.Whirlwind, },
			[24] = new List<Move>() { MoveFactory.AirSlash, },
			[28] = new List<Move>() { MoveFactory.Safeguard, },
			[32] = new List<Move>() { MoveFactory.BugBuzz, },
			[36] = new List<Move>() { MoveFactory.Tailwind, },
			[40] = new List<Move>() { MoveFactory.RagePowder, },
			[44] = new List<Move>() { MoveFactory.QuiverDance, },
		};
	}
}

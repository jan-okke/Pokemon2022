using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Beautifly : Pokemon
	{
		public override string Name => "Beautifly";
		public override int Generation => 3;
		public override string PokedexEntry => "Its colorfully patterned wings are its most prominent feature. It flies through flower-covered fields collecting pollen. It attacks ferociously when angered.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Bug, PokemonType.Flying };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Swarm, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Rivalry;
		public override Stats BaseStats => new Stats() {
			HP = 60,
			Attack = 70,
			Defense = 50,
			SpecialAttack = 100,
			SpecialDefense = 50,
			Speed = 65
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[0] = new List<Move>() { MoveFactory.Gust, },
			[1] = new List<Move>() { MoveFactory.Gust, },
			[12] = new List<Move>() { MoveFactory.Absorb, },
			[15] = new List<Move>() { MoveFactory.StunSpore, },
			[17] = new List<Move>() { MoveFactory.MorningSun, },
			[20] = new List<Move>() { MoveFactory.AirCutter, },
			[22] = new List<Move>() { MoveFactory.MegaDrain, },
			[25] = new List<Move>() { MoveFactory.LeechLife, },
			[27] = new List<Move>() { MoveFactory.Attract, },
			[30] = new List<Move>() { MoveFactory.Whirlwind, },
			[32] = new List<Move>() { MoveFactory.GigaDrain, },
			[35] = new List<Move>() { MoveFactory.BugBuzz, },
			[37] = new List<Move>() { MoveFactory.Protect, },
			[40] = new List<Move>() { MoveFactory.QuiverDance, },
		};
	}
}

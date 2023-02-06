using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Swoobat : Pokemon
	{
		public override string Name => "Swoobat";
		public override int Generation => 5;
		public override string PokedexEntry => "Anyone who comes into contact with the ultrasonic waves emitted by a courting male experiences a positive mood shift.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Psychic, PokemonType.Flying };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Unaware, AbilityFactory.Klutz, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Simple;
		public override Stats BaseStats => new Stats() {
			HP = 67,
			Attack = 57,
			Defense = 55,
			SpecialAttack = 77,
			SpecialDefense = 55,
			Speed = 114
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Gust, MoveFactory.Attract, MoveFactory.Confusion, MoveFactory.Endeavor, },
			[15] = new List<Move>() { MoveFactory.AirCutter, },
			[20] = new List<Move>() { MoveFactory.Imprison, },
			[25] = new List<Move>() { MoveFactory.Assurance, },
			[30] = new List<Move>() { MoveFactory.Amnesia, },
			[35] = new List<Move>() { MoveFactory.AirSlash, },
			[40] = new List<Move>() { MoveFactory.Psychic, },
			[45] = new List<Move>() { MoveFactory.CalmMind, },
			[50] = new List<Move>() { MoveFactory.FutureSight, },
			[55] = new List<Move>() { MoveFactory.SimpleBeam, },
		};
	}
}

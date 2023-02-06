using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Azelf : Pokemon
	{
		public override string Name => "Azelf";
		public override int Generation => 4;
		public override string PokedexEntry => "Known as 'The Being of Willpower.' It sleeps at the bottom of a lake to keep the world in balance.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Psychic };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Levitate, };
		public override Stats BaseStats => new Stats() {
			HP = 75,
			Attack = 125,
			Defense = 70,
			SpecialAttack = 125,
			SpecialDefense = 70,
			Speed = 115
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Confusion, MoveFactory.Rest, },
			[7] = new List<Move>() { MoveFactory.Swift, },
			[14] = new List<Move>() { MoveFactory.Detect, },
			[21] = new List<Move>() { MoveFactory.Psybeam, },
			[28] = new List<Move>() { MoveFactory.Imprison, },
			[35] = new List<Move>() { MoveFactory.Extrasensory, },
			[42] = new List<Move>() { MoveFactory.NastyPlot, },
			[49] = new List<Move>() { MoveFactory.Psychic, },
			[56] = new List<Move>() { MoveFactory.Uproar, },
			[63] = new List<Move>() { MoveFactory.FutureSight, },
			[70] = new List<Move>() { MoveFactory.LastResort, },
			[77] = new List<Move>() { MoveFactory.Explosion, },
		};
	}
}

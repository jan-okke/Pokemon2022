using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Uxie : Pokemon
	{
		public override string Name => "Uxie";
		public override int Generation => 4;
		public override string PokedexEntry => "Known as 'The Being of Knowledge.' It is said that it can wipe out the memory of those who see its eyes.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Psychic };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Levitate, };
		public override Stats BaseStats => new Stats() {
			HP = 75,
			Attack = 75,
			Defense = 130,
			SpecialAttack = 75,
			SpecialDefense = 130,
			Speed = 95
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Confusion, MoveFactory.Rest, },
			[7] = new List<Move>() { MoveFactory.Swift, },
			[14] = new List<Move>() { MoveFactory.Endure, },
			[21] = new List<Move>() { MoveFactory.Psybeam, },
			[28] = new List<Move>() { MoveFactory.Imprison, },
			[35] = new List<Move>() { MoveFactory.Extrasensory, },
			[42] = new List<Move>() { MoveFactory.Amnesia, },
			[49] = new List<Move>() { MoveFactory.Psychic, },
			[56] = new List<Move>() { MoveFactory.Yawn, },
			[63] = new List<Move>() { MoveFactory.FutureSight, },
			[70] = new List<Move>() { MoveFactory.Flail, },
			[77] = new List<Move>() { MoveFactory.Memento, },
		};
	}
}

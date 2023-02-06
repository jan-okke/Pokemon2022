using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Mesprit : Pokemon
	{
		public override string Name => "Mesprit";
		public override int Generation => 4;
		public override string PokedexEntry => "Known as 'The Being of Emotion.' It taught humans the nobility of sorrow, pain, and joy.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Psychic };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Levitate, };
		public override Stats BaseStats => new Stats() {
			HP = 80,
			Attack = 105,
			Defense = 105,
			SpecialAttack = 105,
			SpecialDefense = 105,
			Speed = 80
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Confusion, MoveFactory.Rest, },
			[7] = new List<Move>() { MoveFactory.Swift, },
			[14] = new List<Move>() { MoveFactory.Protect, },
			[21] = new List<Move>() { MoveFactory.Psybeam, },
			[28] = new List<Move>() { MoveFactory.Imprison, },
			[35] = new List<Move>() { MoveFactory.Extrasensory, },
			[42] = new List<Move>() { MoveFactory.Charm, },
			[49] = new List<Move>() { MoveFactory.Psychic, },
			[56] = new List<Move>() { MoveFactory.Flatter, },
			[63] = new List<Move>() { MoveFactory.FutureSight, },
			[70] = new List<Move>() { MoveFactory.Copycat, },
			[77] = new List<Move>() { MoveFactory.HealingWish, },
		};
	}
}

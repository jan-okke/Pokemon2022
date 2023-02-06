using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Smoochum : Pokemon
	{
		public override string Name => "Smoochum";
		public override int Generation => 2;
		public override string PokedexEntry => "It actively runs about, but also falls often. Whenever it falls, it will check its reflection on a lake's surface to make sure its face hasn't become dirty.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Ice, PokemonType.Psychic };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Oblivious, AbilityFactory.Forewarn, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Hydration;
		public override Stats BaseStats => new Stats() {
			HP = 45,
			Attack = 30,
			Defense = 15,
			SpecialAttack = 85,
			SpecialDefense = 65,
			Speed = 65
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Lick, MoveFactory.Pound, },
			[4] = new List<Move>() { MoveFactory.PowderSnow, },
			[8] = new List<Move>() { MoveFactory.Copycat, },
			[12] = new List<Move>() { MoveFactory.Confusion, },
			[16] = new List<Move>() { MoveFactory.Covet, },
			[20] = new List<Move>() { MoveFactory.Sing, },
			[24] = new List<Move>() { MoveFactory.FakeTears, },
			[28] = new List<Move>() { MoveFactory.IcePunch, },
			[32] = new List<Move>() { MoveFactory.Psychic, },
			[36] = new List<Move>() { MoveFactory.SweetKiss, },
			[40] = new List<Move>() { MoveFactory.MeanLook, },
			[44] = new List<Move>() { MoveFactory.PerishSong, },
			[48] = new List<Move>() { MoveFactory.Blizzard, },
		};
	}
}

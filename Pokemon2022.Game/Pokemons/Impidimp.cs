using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Impidimp : Pokemon
	{
		public override string Name => "Impidimp";
		public override int Generation => 8;
		public override string PokedexEntry => "Through its nose, it sucks in the emanations produced by people and Pokémon when they feel annoyed. It thrives off this negative energy.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Dark, PokemonType.Fairy };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Prankster, AbilityFactory.Frisk, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Pickpocket;
		public override Stats BaseStats => new Stats() {
			HP = 45,
			Attack = 45,
			Defense = 30,
			SpecialAttack = 55,
			SpecialDefense = 40,
			Speed = 50
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.FakeOut, MoveFactory.Confide, },
			[4] = new List<Move>() { MoveFactory.Bite, },
			[8] = new List<Move>() { MoveFactory.Flatter, },
			[12] = new List<Move>() { MoveFactory.FakeTears, },
			[16] = new List<Move>() { MoveFactory.Assurance, },
			[20] = new List<Move>() { MoveFactory.Swagger, },
			[24] = new List<Move>() { MoveFactory.SuckerPunch, },
			[28] = new List<Move>() { MoveFactory.Torment, },
			[33] = new List<Move>() { MoveFactory.DarkPulse, },
			[36] = new List<Move>() { MoveFactory.NastyPlot, },
			[40] = new List<Move>() { MoveFactory.PlayRough, },
			[44] = new List<Move>() { MoveFactory.FoulPlay, },
		};
	}
}

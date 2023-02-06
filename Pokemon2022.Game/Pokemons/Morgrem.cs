using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Morgrem : Pokemon
	{
		public override string Name => "Morgrem";
		public override int Generation => 8;
		public override string PokedexEntry => "With sly cunning, it tries to lure people into the woods. Some believe it to have the power to make crops grow.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Dark, PokemonType.Fairy };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Prankster, AbilityFactory.Frisk, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Pickpocket;
		public override Stats BaseStats => new Stats() {
			HP = 65,
			Attack = 60,
			Defense = 45,
			SpecialAttack = 75,
			SpecialDefense = 55,
			Speed = 70
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[0] = new List<Move>() { MoveFactory.FalseSurrender, },
			[1] = new List<Move>() { MoveFactory.FalseSurrender, MoveFactory.FakeOut, MoveFactory.Confide, MoveFactory.Bite, MoveFactory.Flatter, },
			[12] = new List<Move>() { MoveFactory.FakeTears, },
			[16] = new List<Move>() { MoveFactory.Assurance, },
			[20] = new List<Move>() { MoveFactory.Swagger, },
			[24] = new List<Move>() { MoveFactory.SuckerPunch, },
			[28] = new List<Move>() { MoveFactory.Torment, },
			[35] = new List<Move>() { MoveFactory.DarkPulse, },
			[40] = new List<Move>() { MoveFactory.NastyPlot, },
			[46] = new List<Move>() { MoveFactory.PlayRough, },
			[52] = new List<Move>() { MoveFactory.FoulPlay, },
		};
	}
}

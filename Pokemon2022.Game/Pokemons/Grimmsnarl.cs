using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Grimmsnarl : Pokemon
	{
		public override string Name => "Grimmsnarl";
		public override int Generation => 8;
		public override string PokedexEntry => "Its hairs work like muscle fibers. When its hairs unfurl, they latch on to opponents, ensnaring them as tentacles would.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Dark, PokemonType.Fairy };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Prankster, AbilityFactory.Frisk, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Pickpocket;
		public override Stats BaseStats => new Stats() {
			HP = 95,
			Attack = 120,
			Defense = 65,
			SpecialAttack = 95,
			SpecialDefense = 75,
			Speed = 60
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[0] = new List<Move>() { MoveFactory.SpiritBreak, },
			[1] = new List<Move>() { MoveFactory.SpiritBreak, MoveFactory.FalseSurrender, MoveFactory.BulkUp, MoveFactory.PowerUpPunch, MoveFactory.FakeOut, MoveFactory.Confide, MoveFactory.Bite, MoveFactory.Flatter, },
			[12] = new List<Move>() { MoveFactory.FakeTears, },
			[16] = new List<Move>() { MoveFactory.Assurance, },
			[20] = new List<Move>() { MoveFactory.Swagger, },
			[24] = new List<Move>() { MoveFactory.SuckerPunch, },
			[28] = new List<Move>() { MoveFactory.Torment, },
			[35] = new List<Move>() { MoveFactory.DarkPulse, },
			[40] = new List<Move>() { MoveFactory.NastyPlot, },
			[48] = new List<Move>() { MoveFactory.PlayRough, },
			[56] = new List<Move>() { MoveFactory.FoulPlay, },
			[64] = new List<Move>() { MoveFactory.HammerArm, },
		};
	}
}

using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Darkrai : Pokemon
	{
		public override string Name => "Darkrai";
		public override int Generation => 4;
		public override string PokedexEntry => "It can lull people to sleep and make them dream. It is active during nights of the new moon.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Dark };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.BadDreams, };
		public override Stats BaseStats => new Stats() {
			HP = 70,
			Attack = 90,
			Defense = 90,
			SpecialAttack = 135,
			SpecialDefense = 90,
			Speed = 125
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.ConfuseRay, MoveFactory.Disable, },
			[11] = new List<Move>() { MoveFactory.QuickAttack, },
			[20] = new List<Move>() { MoveFactory.Hypnosis, },
			[29] = new List<Move>() { MoveFactory.SuckerPunch, },
			[38] = new List<Move>() { MoveFactory.FoulPlay, },
			[47] = new List<Move>() { MoveFactory.DoubleTeam, },
			[57] = new List<Move>() { MoveFactory.Haze, },
			[66] = new List<Move>() { MoveFactory.DarkVoid, },
			[75] = new List<Move>() { MoveFactory.NastyPlot, },
			[84] = new List<Move>() { MoveFactory.DreamEater, },
			[93] = new List<Move>() { MoveFactory.DarkPulse, },
		};
	}
}

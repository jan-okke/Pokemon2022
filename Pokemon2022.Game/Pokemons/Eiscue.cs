using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Eiscue : Pokemon
	{
		public override string Name => "Eiscue";
		public override int Generation => 8;
		public override string PokedexEntry => "It drifted in on the flow of ocean waters from a frigid place. It keeps its head iced constantly to make sure it stays nice and cold.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Ice };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.IceFace, };
		public override Stats BaseStats => new Stats() {
			HP = 75,
			Attack = 80,
			Defense = 110,
			SpecialAttack = 65,
			SpecialDefense = 90,
			Speed = 50
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.PowderSnow, MoveFactory.Tackle, },
			[6] = new List<Move>() { MoveFactory.Mist, },
			[12] = new List<Move>() { MoveFactory.WeatherBall, },
			[18] = new List<Move>() { MoveFactory.IcyWind, },
			[24] = new List<Move>() { MoveFactory.Headbutt, },
			[30] = new List<Move>() { MoveFactory.Amnesia, },
			[36] = new List<Move>() { MoveFactory.FreezeDry, },
			[42] = new List<Move>() { MoveFactory.Hail, },
			[48] = new List<Move>() { MoveFactory.AuroraVeil, },
			[54] = new List<Move>() { MoveFactory.Surf, },
			[60] = new List<Move>() { MoveFactory.Blizzard, },
		};
	}
}

using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Lugia : Pokemon
	{
		public override string Name => "Lugia";
		public override int Generation => 2;
		public override string PokedexEntry => "Lugia is so powerful even a light fluttering of its wings can blow apart houses. As a result, it chooses to live out of sight deep under the sea.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Psychic, PokemonType.Flying };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Pressure, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Multiscale;
		public override Stats BaseStats => new Stats() {
			HP = 106,
			Attack = 90,
			Defense = 130,
			SpecialAttack = 90,
			SpecialDefense = 154,
			Speed = 110
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.DragonRush, MoveFactory.Gust, MoveFactory.Whirlwind, MoveFactory.WeatherBall, MoveFactory.AncientPower, },
			[9] = new List<Move>() { MoveFactory.Mist, },
			[18] = new List<Move>() { MoveFactory.Safeguard, },
			[27] = new List<Move>() { MoveFactory.CalmMind, },
			[36] = new List<Move>() { MoveFactory.Extrasensory, },
			[45] = new List<Move>() { MoveFactory.Recover, },
			[54] = new List<Move>() { MoveFactory.Aeroblast, },
			[63] = new List<Move>() { MoveFactory.RainDance, },
			[72] = new List<Move>() { MoveFactory.HydroPump, },
			[81] = new List<Move>() { MoveFactory.FutureSight, },
			[90] = new List<Move>() { MoveFactory.SkyAttack, },
		};
	}
}

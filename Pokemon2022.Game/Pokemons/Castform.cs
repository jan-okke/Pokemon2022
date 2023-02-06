using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Castform : Pokemon
	{
		public override string Name => "Castform";
		public override int Generation => 3;
		public override string PokedexEntry => "It alters its form depending on the weather. Changes in the climate such as the temperature and humidity appear to affect its cellular structure.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Normal };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Forecast, };
		public override Stats BaseStats => new Stats() {
			HP = 70,
			Attack = 70,
			Defense = 70,
			SpecialAttack = 70,
			SpecialDefense = 70,
			Speed = 70
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Tackle, },
			[10] = new List<Move>() { MoveFactory.WaterGun, MoveFactory.Ember, MoveFactory.PowderSnow, },
			[15] = new List<Move>() { MoveFactory.Headbutt, },
			[20] = new List<Move>() { MoveFactory.RainDance, MoveFactory.SunnyDay, MoveFactory.Hail, },
			[25] = new List<Move>() { MoveFactory.WeatherBall, },
			[35] = new List<Move>() { MoveFactory.HydroPump, MoveFactory.FireBlast, MoveFactory.Blizzard, },
			[45] = new List<Move>() { MoveFactory.Hurricane, },
		};
	}
}

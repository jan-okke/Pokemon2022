using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class HoOh : Pokemon
	{
		public override string Name => "Ho-Oh";
		public override int Generation => 2;
		public override string PokedexEntry => "Its feathers--which glow in seven colors depending on the angle at which light strikes them--are thought to bring joy. It is said to live at the foot of a rainbow.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Fire, PokemonType.Flying };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Pressure, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Regenerator;
		public override Stats BaseStats => new Stats() {
			HP = 106,
			Attack = 130,
			Defense = 90,
			SpecialAttack = 110,
			SpecialDefense = 154,
			Speed = 90
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Gust, MoveFactory.Whirlwind, MoveFactory.WeatherBall, MoveFactory.AncientPower, },
			[9] = new List<Move>() { MoveFactory.LifeDew, },
			[18] = new List<Move>() { MoveFactory.Safeguard, },
			[27] = new List<Move>() { MoveFactory.CalmMind, },
			[36] = new List<Move>() { MoveFactory.Extrasensory, },
			[45] = new List<Move>() { MoveFactory.Recover, },
			[54] = new List<Move>() { MoveFactory.SacredFire, },
			[63] = new List<Move>() { MoveFactory.SunnyDay, },
			[72] = new List<Move>() { MoveFactory.FireBlast, },
			[81] = new List<Move>() { MoveFactory.FutureSight, },
			[90] = new List<Move>() { MoveFactory.SkyAttack, },
			[99] = new List<Move>() { MoveFactory.BurnUp, },
		};
	}
}

using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Suicune : Pokemon
	{
		public override string Name => "Suicune";
		public override int Generation => 2;
		public override string PokedexEntry => "Suicune embodies the compassion of a pure spring of water. It runs across the land with gliding elegance. It has the power to purify dirty water.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Water };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Pressure, };
		public override Ability AvailableHiddenAbility => AbilityFactory.InnerFocus;
		public override Stats BaseStats => new Stats() {
			HP = 100,
			Attack = 75,
			Defense = 115,
			SpecialAttack = 90,
			SpecialDefense = 115,
			Speed = 85
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.SheerCold, MoveFactory.ExtremeSpeed, MoveFactory.WaterGun, MoveFactory.Leer, MoveFactory.Gust, MoveFactory.Mist, },
			[6] = new List<Move>() { MoveFactory.WaterPulse, },
			[12] = new List<Move>() { MoveFactory.Bite, },
			[18] = new List<Move>() { MoveFactory.CalmMind, },
			[24] = new List<Move>() { MoveFactory.Roar, },
			[30] = new List<Move>() { MoveFactory.IceFang, },
			[36] = new List<Move>() { MoveFactory.Tailwind, },
			[42] = new List<Move>() { MoveFactory.Crunch, },
			[48] = new List<Move>() { MoveFactory.Extrasensory, },
			[54] = new List<Move>() { MoveFactory.Surf, },
			[60] = new List<Move>() { MoveFactory.MirrorCoat, },
			[66] = new List<Move>() { MoveFactory.RainDance, },
			[72] = new List<Move>() { MoveFactory.HydroPump, },
			[78] = new List<Move>() { MoveFactory.Blizzard, },
		};
	}
}

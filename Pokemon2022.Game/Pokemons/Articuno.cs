using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Articuno : Pokemon
	{
		public override string Name => "Articuno";
		public override int Generation => 1;
		public override string PokedexEntry => "Articuno is a legendary bird Pokémon that can control ice. The flapping of its wings chills the air. As a result, it is said that when this Pokémon flies, snow will fall.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Ice, PokemonType.Flying };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Pressure, };
		public override Ability AvailableHiddenAbility => AbilityFactory.SnowCloak;
		public override Stats BaseStats => new Stats() {
			HP = 90,
			Attack = 85,
			Defense = 100,
			SpecialAttack = 95,
			SpecialDefense = 125,
			Speed = 85
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Gust, MoveFactory.Mist, },
			[5] = new List<Move>() { MoveFactory.PowderSnow, },
			[10] = new List<Move>() { MoveFactory.Reflect, },
			[15] = new List<Move>() { MoveFactory.IceShard, },
			[20] = new List<Move>() { MoveFactory.Agility, },
			[25] = new List<Move>() { MoveFactory.AncientPower, },
			[30] = new List<Move>() { MoveFactory.Tailwind, },
			[35] = new List<Move>() { MoveFactory.FreezeDry, },
			[40] = new List<Move>() { MoveFactory.Roost, },
			[45] = new List<Move>() { MoveFactory.IceBeam, },
			[50] = new List<Move>() { MoveFactory.Hail, },
			[55] = new List<Move>() { MoveFactory.Hurricane, },
			[60] = new List<Move>() { MoveFactory.MindReader, },
			[65] = new List<Move>() { MoveFactory.Blizzard, },
			[70] = new List<Move>() { MoveFactory.SheerCold, },
		};
	}
}

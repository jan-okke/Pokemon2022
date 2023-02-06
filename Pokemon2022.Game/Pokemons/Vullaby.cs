using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Vullaby : Pokemon
	{
		public override string Name => "Vullaby";
		public override int Generation => 5;
		public override string PokedexEntry => "They tend to guard their posteriors with suitable bones they have found. They pursue weak Pokémon.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Dark, PokemonType.Flying };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.BigPecks, AbilityFactory.Overcoat, };
		public override Ability AvailableHiddenAbility => AbilityFactory.WeakArmor;
		public override Stats BaseStats => new Stats() {
			HP = 70,
			Attack = 55,
			Defense = 75,
			SpecialAttack = 45,
			SpecialDefense = 65,
			Speed = 60
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Gust, MoveFactory.Leer, },
			[6] = new List<Move>() { MoveFactory.Flatter, },
			[12] = new List<Move>() { MoveFactory.Pluck, },
			[18] = new List<Move>() { MoveFactory.Tailwind, },
			[24] = new List<Move>() { MoveFactory.KnockOff, },
			[30] = new List<Move>() { MoveFactory.IronDefense, },
			[36] = new List<Move>() { MoveFactory.Whirlwind, },
			[42] = new List<Move>() { MoveFactory.AirSlash, },
			[48] = new List<Move>() { MoveFactory.DarkPulse, },
			[54] = new List<Move>() { MoveFactory.NastyPlot, },
			[60] = new List<Move>() { MoveFactory.Defog, },
			[66] = new List<Move>() { MoveFactory.Attract, },
			[72] = new List<Move>() { MoveFactory.BraveBird, },
		};
	}
}

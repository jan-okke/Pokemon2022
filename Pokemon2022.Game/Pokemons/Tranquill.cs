using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Tranquill : Pokemon
	{
		public override string Name => "Tranquill";
		public override int Generation => 5;
		public override string PokedexEntry => "Many people believe that, deep in the forest where Tranquill live, there is a peaceful place where there is no war.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Normal, PokemonType.Flying };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.BigPecks, AbilityFactory.SuperLuck, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Rivalry;
		public override Stats BaseStats => new Stats() {
			HP = 62,
			Attack = 77,
			Defense = 62,
			SpecialAttack = 50,
			SpecialDefense = 42,
			Speed = 65
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Gust, MoveFactory.Growl, MoveFactory.Leer, MoveFactory.QuickAttack, },
			[12] = new List<Move>() { MoveFactory.Taunt, },
			[16] = new List<Move>() { MoveFactory.AirCutter, },
			[20] = new List<Move>() { MoveFactory.Swagger, },
			[26] = new List<Move>() { MoveFactory.FeatherDance, },
			[34] = new List<Move>() { MoveFactory.Detect, },
			[38] = new List<Move>() { MoveFactory.AirSlash, },
			[44] = new List<Move>() { MoveFactory.Roost, },
			[50] = new List<Move>() { MoveFactory.Tailwind, },
			[56] = new List<Move>() { MoveFactory.SkyAttack, },
		};
	}
}

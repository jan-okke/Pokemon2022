using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Pidove : Pokemon
	{
		public override string Name => "Pidove";
		public override int Generation => 5;
		public override string PokedexEntry => "These Pokémon live in cities. They are accustomed to people. Flocks often gather in parks and plazas.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Normal, PokemonType.Flying };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.BigPecks, AbilityFactory.SuperLuck, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Rivalry;
		public override Stats BaseStats => new Stats() {
			HP = 50,
			Attack = 55,
			Defense = 50,
			SpecialAttack = 36,
			SpecialDefense = 30,
			Speed = 43
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Gust, MoveFactory.Growl, },
			[4] = new List<Move>() { MoveFactory.Leer, },
			[8] = new List<Move>() { MoveFactory.QuickAttack, },
			[12] = new List<Move>() { MoveFactory.Taunt, },
			[16] = new List<Move>() { MoveFactory.AirCutter, },
			[20] = new List<Move>() { MoveFactory.Swagger, },
			[24] = new List<Move>() { MoveFactory.FeatherDance, },
			[28] = new List<Move>() { MoveFactory.Detect, },
			[32] = new List<Move>() { MoveFactory.AirSlash, },
			[36] = new List<Move>() { MoveFactory.Roost, },
			[40] = new List<Move>() { MoveFactory.Tailwind, },
			[44] = new List<Move>() { MoveFactory.SkyAttack, },
		};
	}
}

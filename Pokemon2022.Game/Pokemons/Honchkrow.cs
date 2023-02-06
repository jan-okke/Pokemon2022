using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Honchkrow : Pokemon
	{
		public override string Name => "Honchkrow";
		public override int Generation => 4;
		public override string PokedexEntry => "Becoming active at night, it is known to swarm with numerous Murkrow in tow.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Dark, PokemonType.Flying };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Insomnia, AbilityFactory.SuperLuck, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Moxie;
		public override Stats BaseStats => new Stats() {
			HP = 100,
			Attack = 125,
			Defense = 52,
			SpecialAttack = 105,
			SpecialDefense = 52,
			Speed = 71
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.NightSlash, MoveFactory.SuckerPunch, MoveFactory.Astonish, MoveFactory.Haze, MoveFactory.WingAttack, },
			[25] = new List<Move>() { MoveFactory.Swagger, },
			[35] = new List<Move>() { MoveFactory.NastyPlot, },
			[45] = new List<Move>() { MoveFactory.FoulPlay, },
			[55] = new List<Move>() { MoveFactory.NightSlash, },
			[65] = new List<Move>() { MoveFactory.Quash, },
			[75] = new List<Move>() { MoveFactory.DarkPulse, },
		};
	}
}

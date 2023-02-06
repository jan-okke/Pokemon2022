using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Murkrow : Pokemon
	{
		public override string Name => "Murkrow";
		public override int Generation => 2;
		public override string PokedexEntry => "Murkrow were feared as the alleged bearers of ill fortune. It shows strong interest in anything that sparkles. It will even try to steal rings from women.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Dark, PokemonType.Flying };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Insomnia, AbilityFactory.SuperLuck, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Prankster;
		public override Stats BaseStats => new Stats() {
			HP = 60,
			Attack = 85,
			Defense = 42,
			SpecialAttack = 85,
			SpecialDefense = 42,
			Speed = 91
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Peck, MoveFactory.Astonish, },
			[5] = new List<Move>() { MoveFactory.Gust, },
			[11] = new List<Move>() { MoveFactory.Haze, },
			[15] = new List<Move>() { MoveFactory.WingAttack, },
			[21] = new List<Move>() { MoveFactory.NightShade, },
			[25] = new List<Move>() { MoveFactory.Assurance, },
			[31] = new List<Move>() { MoveFactory.Taunt, },
			[35] = new List<Move>() { MoveFactory.AirCutter, },
			[41] = new List<Move>() { MoveFactory.MeanLook, },
			[45] = new List<Move>() { MoveFactory.FoulPlay, },
			[50] = new List<Move>() { MoveFactory.Tailwind, },
			[55] = new List<Move>() { MoveFactory.SuckerPunch, },
			[61] = new List<Move>() { MoveFactory.Torment, },
			[65] = new List<Move>() { MoveFactory.Quash, },
		};
	}
}

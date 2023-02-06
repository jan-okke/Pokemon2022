using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Yanmega : Pokemon
	{
		public override string Name => "Yanmega";
		public override int Generation => 4;
		public override string PokedexEntry => "By churning its wings, it creates shock waves that inflict critical internal injuries to foes.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Bug, PokemonType.Flying };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.SpeedBoost, AbilityFactory.TintedLens, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Frisk;
		public override Stats BaseStats => new Stats() {
			HP = 86,
			Attack = 76,
			Defense = 86,
			SpecialAttack = 116,
			SpecialDefense = 56,
			Speed = 95
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.BugBuzz, MoveFactory.AirSlash, MoveFactory.NightSlash, MoveFactory.BugBite, MoveFactory.Tackle, MoveFactory.Gust, MoveFactory.QuickAttack, MoveFactory.DoubleTeam, },
			[6] = new List<Move>() { MoveFactory.QuickAttack, },
			[11] = new List<Move>() { MoveFactory.DoubleTeam, },
			[14] = new List<Move>() { MoveFactory.AerialAce, },
			[17] = new List<Move>() { MoveFactory.Detect, },
			[22] = new List<Move>() { MoveFactory.Supersonic, },
			[27] = new List<Move>() { MoveFactory.Uproar, },
			[30] = new List<Move>() { MoveFactory.StringShot, },
			[33] = new List<Move>() { MoveFactory.AncientPower, },
			[38] = new List<Move>() { MoveFactory.Feint, },
			[43] = new List<Move>() { MoveFactory.Slash, },
			[46] = new List<Move>() { MoveFactory.Screech, },
			[49] = new List<Move>() { MoveFactory.Uturn, },
			[54] = new List<Move>() { MoveFactory.AirSlash, },
			[57] = new List<Move>() { MoveFactory.BugBuzz, },
		};
	}
}

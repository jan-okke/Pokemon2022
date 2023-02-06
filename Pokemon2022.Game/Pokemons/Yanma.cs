using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Yanma : Pokemon
	{
		public override string Name => "Yanma";
		public override int Generation => 2;
		public override string PokedexEntry => "It can see 360 degrees without moving its eyes. It is a great flier capable of making sudden stops and turning midair to quickly chase down targeted prey.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Bug, PokemonType.Flying };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.SpeedBoost, AbilityFactory.CompoundEyes, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Frisk;
		public override Stats BaseStats => new Stats() {
			HP = 65,
			Attack = 65,
			Defense = 45,
			SpecialAttack = 75,
			SpecialDefense = 45,
			Speed = 95
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Tackle, MoveFactory.Gust, },
			[6] = new List<Move>() { MoveFactory.QuickAttack, },
			[11] = new List<Move>() { MoveFactory.DoubleTeam, },
			[14] = new List<Move>() { MoveFactory.AerialAce, },
			[17] = new List<Move>() { MoveFactory.Detect, },
			[22] = new List<Move>() { MoveFactory.Supersonic, },
			[27] = new List<Move>() { MoveFactory.Uproar, },
			[30] = new List<Move>() { MoveFactory.StringShot, },
			[33] = new List<Move>() { MoveFactory.AncientPower, },
			[38] = new List<Move>() { MoveFactory.Hypnosis, },
			[43] = new List<Move>() { MoveFactory.WingAttack, },
			[46] = new List<Move>() { MoveFactory.Screech, },
			[49] = new List<Move>() { MoveFactory.Uturn, },
			[54] = new List<Move>() { MoveFactory.AirSlash, },
			[57] = new List<Move>() { MoveFactory.BugBuzz, },
		};
	}
}

using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Noibat : Pokemon
	{
		public override string Name => "Noibat";
		public override int Generation => 6;
		public override string PokedexEntry => "Even a robust wrestler will become dizzy and unable to stand when exposed to its 200,000-hertz ultrasonic waves.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Flying, PokemonType.Dragon };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Frisk, AbilityFactory.Infiltrator, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Telepathy;
		public override Stats BaseStats => new Stats() {
			HP = 40,
			Attack = 30,
			Defense = 35,
			SpecialAttack = 45,
			SpecialDefense = 40,
			Speed = 55
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Tackle, MoveFactory.Absorb, },
			[4] = new List<Move>() { MoveFactory.Gust, },
			[8] = new List<Move>() { MoveFactory.Supersonic, },
			[12] = new List<Move>() { MoveFactory.DoubleTeam, },
			[16] = new List<Move>() { MoveFactory.WingAttack, },
			[20] = new List<Move>() { MoveFactory.Bite, },
			[24] = new List<Move>() { MoveFactory.AirCutter, },
			[28] = new List<Move>() { MoveFactory.Whirlwind, },
			[32] = new List<Move>() { MoveFactory.SuperFang, },
			[36] = new List<Move>() { MoveFactory.AirSlash, },
			[40] = new List<Move>() { MoveFactory.Screech, },
			[44] = new List<Move>() { MoveFactory.Roost, },
			[49] = new List<Move>() { MoveFactory.Tailwind, },
			[52] = new List<Move>() { MoveFactory.Hurricane, },
		};
	}
}

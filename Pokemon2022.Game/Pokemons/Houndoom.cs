using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Houndoom : Pokemon
	{
		public override string Name => "Houndoom";
		public override int Generation => 2;
		public override string PokedexEntry => "In a Houndoom pack, the one with its horns raked sharply back serves a leadership role. They choose their leader by fighting among themselves.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Dark, PokemonType.Fire };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.EarlyBird, AbilityFactory.FlashFire, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Unnerve;
		public override Stats BaseStats => new Stats() {
			HP = 75,
			Attack = 90,
			Defense = 50,
			SpecialAttack = 110,
			SpecialDefense = 80,
			Speed = 95
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Inferno, MoveFactory.NastyPlot, MoveFactory.ThunderFang, MoveFactory.Leer, MoveFactory.Ember, },
			[4] = new List<Move>() { MoveFactory.Howl, },
			[8] = new List<Move>() { MoveFactory.Smog, },
			[13] = new List<Move>() { MoveFactory.Roar, },
			[16] = new List<Move>() { MoveFactory.Bite, },
			[20] = new List<Move>() { MoveFactory.Taunt, },
			[26] = new List<Move>() { MoveFactory.BeatUp, },
			[30] = new List<Move>() { MoveFactory.FireFang, },
			[35] = new List<Move>() { MoveFactory.Payback, },
			[41] = new List<Move>() { MoveFactory.FlameCharge, },
			[45] = new List<Move>() { MoveFactory.FoulPlay, },
			[50] = new List<Move>() { MoveFactory.Flamethrower, },
			[56] = new List<Move>() { MoveFactory.Crunch, },
			[60] = new List<Move>() { MoveFactory.NastyPlot, },
			[65] = new List<Move>() { MoveFactory.Inferno, },
		};
	}
}

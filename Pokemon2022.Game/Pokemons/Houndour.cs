using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Houndour : Pokemon
	{
		public override string Name => "Houndour";
		public override int Generation => 2;
		public override string PokedexEntry => "Houndour communicate with each other using a variety of cries to corner their prey. This Pokémon's remarkable teamwork is simply unparalleled.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Dark, PokemonType.Fire };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.EarlyBird, AbilityFactory.FlashFire, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Unnerve;
		public override Stats BaseStats => new Stats() {
			HP = 45,
			Attack = 60,
			Defense = 30,
			SpecialAttack = 80,
			SpecialDefense = 50,
			Speed = 65
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Leer, MoveFactory.Ember, },
			[4] = new List<Move>() { MoveFactory.Howl, },
			[8] = new List<Move>() { MoveFactory.Smog, },
			[13] = new List<Move>() { MoveFactory.Roar, },
			[16] = new List<Move>() { MoveFactory.Bite, },
			[20] = new List<Move>() { MoveFactory.Taunt, },
			[25] = new List<Move>() { MoveFactory.BeatUp, },
			[28] = new List<Move>() { MoveFactory.FireFang, },
			[32] = new List<Move>() { MoveFactory.Payback, },
			[37] = new List<Move>() { MoveFactory.FlameCharge, },
			[40] = new List<Move>() { MoveFactory.FoulPlay, },
			[44] = new List<Move>() { MoveFactory.Flamethrower, },
			[49] = new List<Move>() { MoveFactory.Crunch, },
			[52] = new List<Move>() { MoveFactory.NastyPlot, },
			[56] = new List<Move>() { MoveFactory.Inferno, },
		};
	}
}

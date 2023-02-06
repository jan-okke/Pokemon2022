using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Teddiursa : Pokemon
	{
		public override string Name => "Teddiursa";
		public override int Generation => 2;
		public override string PokedexEntry => "It licks its palms that are sweetened by being soaked in honey. A Teddiursa makes its own honey by blending fruits and pollen collected by Beedrill.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Normal };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Pickup, AbilityFactory.QuickFeet, };
		public override Ability AvailableHiddenAbility => AbilityFactory.HoneyGather;
		public override Stats BaseStats => new Stats() {
			HP = 60,
			Attack = 80,
			Defense = 50,
			SpecialAttack = 50,
			SpecialDefense = 50,
			Speed = 40
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Fling, MoveFactory.Covet, MoveFactory.Scratch, MoveFactory.BabyDollEyes, MoveFactory.Lick, MoveFactory.FakeTears, },
			[8] = new List<Move>() { MoveFactory.FurySwipes, },
			[15] = new List<Move>() { MoveFactory.Payback, },
			[22] = new List<Move>() { MoveFactory.SweetScent, },
			[25] = new List<Move>() { MoveFactory.PlayNice, },
			[29] = new List<Move>() { MoveFactory.Slash, },
			[36] = new List<Move>() { MoveFactory.Charm, },
			[43] = new List<Move>() { MoveFactory.Rest, MoveFactory.Snore, },
			[50] = new List<Move>() { MoveFactory.Thrash, },
			[57] = new List<Move>() { MoveFactory.Fling, },
		};
	}
}

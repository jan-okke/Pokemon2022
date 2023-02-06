using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Kangaskhan : Pokemon
	{
		public override string Name => "Kangaskhan";
		public override int Generation => 1;
		public override string PokedexEntry => "If you come across a young Kangaskhan playing by itself, never try to catch it. The baby's parent is sure to be in the area, and it will become violently enraged.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Normal };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.EarlyBird, AbilityFactory.Scrappy, };
		public override Ability AvailableHiddenAbility => AbilityFactory.InnerFocus;
		public override Stats BaseStats => new Stats() {
			HP = 105,
			Attack = 95,
			Defense = 80,
			SpecialAttack = 40,
			SpecialDefense = 80,
			Speed = 90
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Pound, MoveFactory.TailWhip, },
			[4] = new List<Move>() { MoveFactory.Growl, },
			[8] = new List<Move>() { MoveFactory.FakeOut, },
			[12] = new List<Move>() { MoveFactory.Bite, },
			[16] = new List<Move>() { MoveFactory.Stomp, },
			[20] = new List<Move>() { MoveFactory.FocusEnergy, },
			[24] = new List<Move>() { MoveFactory.Headbutt, },
			[28] = new List<Move>() { MoveFactory.SuckerPunch, },
			[32] = new List<Move>() { MoveFactory.DoubleHit, },
			[36] = new List<Move>() { MoveFactory.Crunch, },
			[40] = new List<Move>() { MoveFactory.Endure, },
			[44] = new List<Move>() { MoveFactory.Reversal, },
			[48] = new List<Move>() { MoveFactory.Outrage, },
			[52] = new List<Move>() { MoveFactory.LastResort, },
		};
	}
}

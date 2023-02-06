using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Dubwool : Pokemon
	{
		public override string Name => "Dubwool";
		public override int Generation => 8;
		public override string PokedexEntry => "Its majestic horns are meant only to impress the opposite gender. They never see use in battle.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Normal };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Fluffy, AbilityFactory.Steadfast, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Bulletproof;
		public override Stats BaseStats => new Stats() {
			HP = 72,
			Attack = 80,
			Defense = 100,
			SpecialAttack = 60,
			SpecialDefense = 90,
			Speed = 88
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Tackle, MoveFactory.Growl, MoveFactory.DefenseCurl, MoveFactory.Copycat, },
			[12] = new List<Move>() { MoveFactory.GuardSplit, },
			[16] = new List<Move>() { MoveFactory.DoubleKick, },
			[21] = new List<Move>() { MoveFactory.Headbutt, },
			[27] = new List<Move>() { MoveFactory.TakeDown, },
			[32] = new List<Move>() { MoveFactory.GuardSwap, },
			[38] = new List<Move>() { MoveFactory.Reversal, },
			[44] = new List<Move>() { MoveFactory.CottonGuard, },
			[50] = new List<Move>() { MoveFactory.DoubleEdge, },
			[56] = new List<Move>() { MoveFactory.LastResort, },
		};
	}
}

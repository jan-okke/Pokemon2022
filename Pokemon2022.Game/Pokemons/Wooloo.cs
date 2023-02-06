using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Wooloo : Pokemon
	{
		public override string Name => "Wooloo";
		public override int Generation => 8;
		public override string PokedexEntry => "Its curly fleece is such an effective cushion that this Pokémon could fall off a cliff and stand right back up at the bottom, unharmed.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Normal };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Fluffy, AbilityFactory.RunAway, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Bulletproof;
		public override Stats BaseStats => new Stats() {
			HP = 42,
			Attack = 40,
			Defense = 55,
			SpecialAttack = 40,
			SpecialDefense = 45,
			Speed = 48
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Tackle, MoveFactory.Growl, },
			[4] = new List<Move>() { MoveFactory.DefenseCurl, },
			[8] = new List<Move>() { MoveFactory.Copycat, },
			[12] = new List<Move>() { MoveFactory.GuardSplit, },
			[16] = new List<Move>() { MoveFactory.DoubleKick, },
			[21] = new List<Move>() { MoveFactory.Headbutt, },
			[25] = new List<Move>() { MoveFactory.TakeDown, },
			[28] = new List<Move>() { MoveFactory.GuardSwap, },
			[32] = new List<Move>() { MoveFactory.Reversal, },
			[36] = new List<Move>() { MoveFactory.CottonGuard, },
			[40] = new List<Move>() { MoveFactory.DoubleEdge, },
		};
	}
}

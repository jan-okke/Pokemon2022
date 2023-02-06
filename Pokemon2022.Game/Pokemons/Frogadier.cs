using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Frogadier : Pokemon
	{
		public override string Name => "Frogadier";
		public override int Generation => 6;
		public override string PokedexEntry => "It can throw bubble-covered pebbles with precise control, hitting empty cans up to a hundred feet away.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Water };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Torrent, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Protean;
		public override Stats BaseStats => new Stats() {
			HP = 54,
			Attack = 63,
			Defense = 52,
			SpecialAttack = 83,
			SpecialDefense = 56,
			Speed = 97
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Pound, MoveFactory.Growl, MoveFactory.Bubble, },
			[5] = new List<Move>() { MoveFactory.Bubble, },
			[8] = new List<Move>() { MoveFactory.QuickAttack, },
			[10] = new List<Move>() { MoveFactory.Lick, },
			[14] = new List<Move>() { MoveFactory.WaterPulse, },
			[19] = new List<Move>() { MoveFactory.Smokescreen, },
			[23] = new List<Move>() { MoveFactory.Round, },
			[28] = new List<Move>() { MoveFactory.Fling, },
			[33] = new List<Move>() { MoveFactory.SmackDown, },
			[40] = new List<Move>() { MoveFactory.Substitute, },
			[45] = new List<Move>() { MoveFactory.Bounce, },
			[50] = new List<Move>() { MoveFactory.DoubleTeam, },
			[56] = new List<Move>() { MoveFactory.HydroPump, },
		};
	}
}

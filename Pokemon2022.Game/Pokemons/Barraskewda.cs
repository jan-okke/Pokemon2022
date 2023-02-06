using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Barraskewda : Pokemon
	{
		public override string Name => "Barraskewda";
		public override int Generation => 8;
		public override string PokedexEntry => "This Pokémon has a jaw that's as sharp as a spear and as strong as steel. Apparently Barraskewda's flesh is surprisingly tasty, too.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Water };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.SwiftSwim, };
		public override Ability AvailableHiddenAbility => AbilityFactory.PropellerTail;
		public override Stats BaseStats => new Stats() {
			HP = 61,
			Attack = 123,
			Defense = 60,
			SpecialAttack = 60,
			SpecialDefense = 50,
			Speed = 136
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.ThroatChop, MoveFactory.Peck, MoveFactory.AquaJet, MoveFactory.FuryAttack, MoveFactory.Bite, },
			[18] = new List<Move>() { MoveFactory.Agility, },
			[24] = new List<Move>() { MoveFactory.Dive, },
			[32] = new List<Move>() { MoveFactory.LaserFocus, },
			[40] = new List<Move>() { MoveFactory.Crunch, },
			[48] = new List<Move>() { MoveFactory.Liquidation, },
			[56] = new List<Move>() { MoveFactory.DoubleEdge, },
		};
	}
}

using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Sceptile : Pokemon
	{
		public override string Name => "Sceptile";
		public override int Generation => 3;
		public override string PokedexEntry => "In the jungle, its power is without equal. This Pokémon carefully grows trees and plants. It regulates its body temperature by basking in sunlight.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Grass };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Overgrow, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Unburden;
		public override Stats BaseStats => new Stats() {
			HP = 70,
			Attack = 85,
			Defense = 65,
			SpecialAttack = 105,
			SpecialDefense = 85,
			Speed = 120
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[0] = new List<Move>() { MoveFactory.DualChop, },
			[1] = new List<Move>() { MoveFactory.DualChop, MoveFactory.FuryCutter, MoveFactory.FalseSwipe, MoveFactory.XScissor, MoveFactory.EnergyBall, MoveFactory.Pound, MoveFactory.Leer, MoveFactory.Leafage, MoveFactory.QuickAttack, },
			[5] = new List<Move>() { MoveFactory.MegaDrain, },
			[12] = new List<Move>() { MoveFactory.Detect, },
			[15] = new List<Move>() { MoveFactory.QuickGuard, },
			[20] = new List<Move>() { MoveFactory.Assurance, },
			[25] = new List<Move>() { MoveFactory.GigaDrain, },
			[30] = new List<Move>() { MoveFactory.Slam, },
			[35] = new List<Move>() { MoveFactory.DoubleTeam, },
			[42] = new List<Move>() { MoveFactory.LeafBlade, },
			[49] = new List<Move>() { MoveFactory.Screech, },
			[56] = new List<Move>() { MoveFactory.Endeavor, },
			[63] = new List<Move>() { MoveFactory.LeafStorm, },
		};
	}
}

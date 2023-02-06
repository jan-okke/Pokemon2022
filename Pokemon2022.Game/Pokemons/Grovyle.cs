using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Grovyle : Pokemon
	{
		public override string Name => "Grovyle";
		public override int Generation => 3;
		public override string PokedexEntry => "Leaves grow out of this Pokémon's body. They help obscure a Grovyle from the eyes of its enemies while it is in a thickly overgrown forest.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Grass };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Overgrow, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Unburden;
		public override Stats BaseStats => new Stats() {
			HP = 50,
			Attack = 65,
			Defense = 45,
			SpecialAttack = 85,
			SpecialDefense = 65,
			Speed = 95
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.FuryCutter, MoveFactory.FalseSwipe, MoveFactory.XScissor, MoveFactory.EnergyBall, MoveFactory.Pound, MoveFactory.Leer, MoveFactory.Leafage, MoveFactory.QuickAttack, },
			[9] = new List<Move>() { MoveFactory.MegaDrain, },
			[12] = new List<Move>() { MoveFactory.Detect, },
			[15] = new List<Move>() { MoveFactory.QuickGuard, },
			[20] = new List<Move>() { MoveFactory.Assurance, },
			[25] = new List<Move>() { MoveFactory.GigaDrain, },
			[30] = new List<Move>() { MoveFactory.Slam, },
			[35] = new List<Move>() { MoveFactory.DoubleTeam, },
			[40] = new List<Move>() { MoveFactory.LeafBlade, },
			[45] = new List<Move>() { MoveFactory.Screech, },
			[50] = new List<Move>() { MoveFactory.Endeavor, },
			[55] = new List<Move>() { MoveFactory.LeafStorm, },
		};
	}
}

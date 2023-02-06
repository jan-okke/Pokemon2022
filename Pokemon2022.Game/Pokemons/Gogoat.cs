using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Gogoat : Pokemon
	{
		public override string Name => "Gogoat";
		public override int Generation => 6;
		public override string PokedexEntry => "It can tell how its trainer is feeling by subtle shifts in the grip on its horns. This empathetic sense lets them run as if one being.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Grass };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.SapSipper, };
		public override Ability AvailableHiddenAbility => AbilityFactory.GrassPelt;
		public override Stats BaseStats => new Stats() {
			HP = 123,
			Attack = 100,
			Defense = 62,
			SpecialAttack = 97,
			SpecialDefense = 81,
			Speed = 68
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[0] = new List<Move>() { MoveFactory.AerialAce, },
			[1] = new List<Move>() { MoveFactory.AerialAce, MoveFactory.Earthquake, MoveFactory.Tackle, MoveFactory.Growth, MoveFactory.VineWhip, MoveFactory.TailWhip, },
			[7] = new List<Move>() { MoveFactory.VineWhip, },
			[9] = new List<Move>() { MoveFactory.TailWhip, },
			[12] = new List<Move>() { MoveFactory.LeechSeed, },
			[13] = new List<Move>() { MoveFactory.RazorLeaf, },
			[16] = new List<Move>() { MoveFactory.WorrySeed, },
			[20] = new List<Move>() { MoveFactory.Synthesis, },
			[22] = new List<Move>() { MoveFactory.TakeDown, },
			[26] = new List<Move>() { MoveFactory.Bulldoze, },
			[30] = new List<Move>() { MoveFactory.SeedBomb, },
			[34] = new List<Move>() { MoveFactory.BulkUp, },
			[40] = new List<Move>() { MoveFactory.DoubleEdge, },
			[47] = new List<Move>() { MoveFactory.HornLeech, },
			[55] = new List<Move>() { MoveFactory.LeafBlade, },
			[58] = new List<Move>() { MoveFactory.MilkDrink, },
		};
	}
}

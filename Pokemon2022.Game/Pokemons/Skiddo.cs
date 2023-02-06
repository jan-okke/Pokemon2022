using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Skiddo : Pokemon
	{
		public override string Name => "Skiddo";
		public override int Generation => 6;
		public override string PokedexEntry => "If it has sunshine and water, it doesn't need to eat, because it can generate energy from the leaves on its back.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Grass };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.SapSipper, };
		public override Ability AvailableHiddenAbility => AbilityFactory.GrassPelt;
		public override Stats BaseStats => new Stats() {
			HP = 66,
			Attack = 65,
			Defense = 48,
			SpecialAttack = 62,
			SpecialDefense = 57,
			Speed = 52
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Tackle, MoveFactory.Growth, },
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
			[38] = new List<Move>() { MoveFactory.DoubleEdge, },
			[42] = new List<Move>() { MoveFactory.HornLeech, },
			[45] = new List<Move>() { MoveFactory.LeafBlade, },
			[50] = new List<Move>() { MoveFactory.MilkDrink, },
		};
	}
}

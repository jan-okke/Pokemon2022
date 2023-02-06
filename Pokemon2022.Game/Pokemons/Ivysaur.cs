using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Ivysaur : Pokemon
	{
		public override string Name => "Ivysaur";
		public override int Generation => 1;
		public override string PokedexEntry => "To support its bulb, Ivysaur's legs grow sturdy. If it spends more time lying in the sunlight, the bud will soon bloom into a large flower.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Grass, PokemonType.Poison };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Overgrow, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Chlorophyll;
		public override Stats BaseStats => new Stats() {
			HP = 60,
			Attack = 62,
			Defense = 63,
			SpecialAttack = 80,
			SpecialDefense = 80,
			Speed = 60
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Tackle, MoveFactory.Growl, MoveFactory.VineWhip, MoveFactory.Growth, },
			[9] = new List<Move>() { MoveFactory.LeechSeed, },
			[12] = new List<Move>() { MoveFactory.RazorLeaf, },
			[15] = new List<Move>() { MoveFactory.PoisonPowder, MoveFactory.SleepPowder, },
			[20] = new List<Move>() { MoveFactory.SeedBomb, },
			[25] = new List<Move>() { MoveFactory.TakeDown, },
			[30] = new List<Move>() { MoveFactory.SweetScent, },
			[35] = new List<Move>() { MoveFactory.Synthesis, },
			[40] = new List<Move>() { MoveFactory.WorrySeed, },
			[45] = new List<Move>() { MoveFactory.DoubleEdge, },
			[50] = new List<Move>() { MoveFactory.SolarBeam, },
		};
	}
}

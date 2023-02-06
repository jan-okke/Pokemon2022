using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Venusaur : Pokemon
	{
		public override string Name => "Venusaur";
		public override int Generation => 1;
		public override string PokedexEntry => "Venusaur's flower is said to take on vivid colors if it gets plenty of nutrition and sunlight. The flower's aroma soothes the emotions of people.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Grass, PokemonType.Poison };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Overgrow, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Chlorophyll;
		public override Stats BaseStats => new Stats() {
			HP = 80,
			Attack = 82,
			Defense = 83,
			SpecialAttack = 100,
			SpecialDefense = 100,
			Speed = 80
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[0] = new List<Move>() { MoveFactory.PetalBlizzard, },
			[1] = new List<Move>() { MoveFactory.PetalBlizzard, MoveFactory.PetalDance, MoveFactory.Tackle, MoveFactory.Growl, MoveFactory.VineWhip, MoveFactory.Growth, },
			[9] = new List<Move>() { MoveFactory.LeechSeed, },
			[12] = new List<Move>() { MoveFactory.RazorLeaf, },
			[15] = new List<Move>() { MoveFactory.PoisonPowder, MoveFactory.SleepPowder, },
			[20] = new List<Move>() { MoveFactory.SeedBomb, },
			[25] = new List<Move>() { MoveFactory.TakeDown, },
			[30] = new List<Move>() { MoveFactory.SweetScent, },
			[37] = new List<Move>() { MoveFactory.Synthesis, },
			[44] = new List<Move>() { MoveFactory.WorrySeed, },
			[51] = new List<Move>() { MoveFactory.DoubleEdge, },
			[58] = new List<Move>() { MoveFactory.SolarBeam, },
		};
	}
}

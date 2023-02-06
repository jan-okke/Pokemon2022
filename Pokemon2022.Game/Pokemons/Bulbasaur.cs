using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Bulbasaur : Pokemon
	{
		public override string Name => "Bulbasaur";
		public override int Generation => 1;
		public override string PokedexEntry => "Bulbasaur can be seen napping in bright sunlight. There is a seed on its back. By soaking up the sun's rays, the seed grows progressively larger.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Grass, PokemonType.Poison };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Overgrow, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Chlorophyll;
		public override Stats BaseStats => new Stats() {
			HP = 45,
			Attack = 49,
			Defense = 49,
			SpecialAttack = 65,
			SpecialDefense = 65,
			Speed = 45
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Tackle, MoveFactory.Growl, },
			[3] = new List<Move>() { MoveFactory.VineWhip, },
			[6] = new List<Move>() { MoveFactory.Growth, },
			[9] = new List<Move>() { MoveFactory.LeechSeed, },
			[12] = new List<Move>() { MoveFactory.RazorLeaf, },
			[15] = new List<Move>() { MoveFactory.PoisonPowder, MoveFactory.SleepPowder, },
			[18] = new List<Move>() { MoveFactory.SeedBomb, },
			[21] = new List<Move>() { MoveFactory.TakeDown, },
			[24] = new List<Move>() { MoveFactory.SweetScent, },
			[27] = new List<Move>() { MoveFactory.Synthesis, },
			[30] = new List<Move>() { MoveFactory.WorrySeed, },
			[33] = new List<Move>() { MoveFactory.DoubleEdge, },
			[36] = new List<Move>() { MoveFactory.SolarBeam, },
		};
	}
}

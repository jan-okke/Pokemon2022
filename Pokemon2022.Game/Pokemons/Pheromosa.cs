using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Pheromosa : Pokemon
	{
		public override string Name => "Pheromosa";
		public override int Generation => 7;
		public override string PokedexEntry => "One of the Ultra Beasts. It refuses to touch anything, perhaps because it senses some uncleanness in this world.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Bug, PokemonType.Fighting };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.BeastBoost, };
		public override Stats BaseStats => new Stats() {
			HP = 71,
			Attack = 137,
			Defense = 37,
			SpecialAttack = 137,
			SpecialDefense = 37,
			Speed = 151
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Feint, MoveFactory.RapidSpin, },
			[5] = new List<Move>() { MoveFactory.Leer, },
			[10] = new List<Move>() { MoveFactory.QuickGuard, },
			[15] = new List<Move>() { MoveFactory.BugBite, },
			[20] = new List<Move>() { MoveFactory.LowKick, },
			[25] = new List<Move>() { MoveFactory.DoubleKick, },
			[30] = new List<Move>() { MoveFactory.TripleKick, },
			[35] = new List<Move>() { MoveFactory.Stomp, },
			[40] = new List<Move>() { MoveFactory.Agility, },
			[45] = new List<Move>() { MoveFactory.Lunge, },
			[50] = new List<Move>() { MoveFactory.Bounce, },
			[55] = new List<Move>() { MoveFactory.SpeedSwap, },
			[60] = new List<Move>() { MoveFactory.BugBuzz, },
			[65] = new List<Move>() { MoveFactory.QuiverDance, },
			[70] = new List<Move>() { MoveFactory.HighJumpKick, },
		};
	}
}

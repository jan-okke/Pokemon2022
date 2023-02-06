using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Decidueye : Pokemon
	{
		public override string Name => "Decidueye";
		public override int Generation => 7;
		public override string PokedexEntry => "It fires arrow quills from its wings with such precision, they can pierce a pebble at distances over a hundred yards.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Grass, PokemonType.Ghost };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Overgrow, };
		public override Ability AvailableHiddenAbility => AbilityFactory.LongReach;
		public override Stats BaseStats => new Stats() {
			HP = 78,
			Attack = 107,
			Defense = 75,
			SpecialAttack = 100,
			SpecialDefense = 100,
			Speed = 70
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[0] = new List<Move>() { MoveFactory.SpiritShackle, },
			[1] = new List<Move>() { MoveFactory.SpiritShackle, MoveFactory.PhantomForce, MoveFactory.LeafStorm, MoveFactory.Uturn, MoveFactory.Spite, MoveFactory.Tackle, MoveFactory.Growl, MoveFactory.Leafage, MoveFactory.Astonish, },
			[9] = new List<Move>() { MoveFactory.Peck, },
			[12] = new List<Move>() { MoveFactory.ShadowSneak, },
			[15] = new List<Move>() { MoveFactory.RazorLeaf, },
			[20] = new List<Move>() { MoveFactory.Synthesis, },
			[25] = new List<Move>() { MoveFactory.Pluck, },
			[30] = new List<Move>() { MoveFactory.NastyPlot, },
			[37] = new List<Move>() { MoveFactory.SuckerPunch, },
			[44] = new List<Move>() { MoveFactory.LeafBlade, },
			[51] = new List<Move>() { MoveFactory.FeatherDance, },
			[58] = new List<Move>() { MoveFactory.BraveBird, },
		};
	}
}

using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Landorus : Pokemon
	{
		public override string Name => "Landorus";
		public override int Generation => 5;
		public override string PokedexEntry => "The energy that comes pouring from its tail increases the nutrition in the soil, making crops grow to great size.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Ground, PokemonType.Flying };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.SandForce, };
		public override Ability AvailableHiddenAbility => AbilityFactory.SheerForce;
		public override Stats BaseStats => new Stats() {
			HP = 89,
			Attack = 125,
			Defense = 90,
			SpecialAttack = 115,
			SpecialDefense = 80,
			Speed = 101
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.SandTomb, MoveFactory.RockThrow, },
			[5] = new List<Move>() { MoveFactory.Leer, },
			[10] = new List<Move>() { MoveFactory.Block, },
			[15] = new List<Move>() { MoveFactory.Bulldoze, },
			[20] = new List<Move>() { MoveFactory.RockTomb, },
			[25] = new List<Move>() { MoveFactory.SwordsDance, },
			[30] = new List<Move>() { MoveFactory.Imprison, },
			[35] = new List<Move>() { MoveFactory.RockSlide, },
			[40] = new List<Move>() { MoveFactory.EarthPower, },
			[45] = new List<Move>() { MoveFactory.Extrasensory, },
			[50] = new List<Move>() { MoveFactory.StoneEdge, },
			[55] = new List<Move>() { MoveFactory.HammerArm, },
			[60] = new List<Move>() { MoveFactory.Sandstorm, },
			[65] = new List<Move>() { MoveFactory.Earthquake, },
			[70] = new List<Move>() { MoveFactory.Outrage, },
			[75] = new List<Move>() { MoveFactory.Fissure, },
		};
	}
}

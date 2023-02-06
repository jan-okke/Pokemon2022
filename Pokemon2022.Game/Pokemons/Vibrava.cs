using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Vibrava : Pokemon
	{
		public override string Name => "Vibrava";
		public override int Generation => 3;
		public override string PokedexEntry => "It looses ultrasonic waves by rubbing its wings together. Since a Vibrava's wings are still in the process of growing, it can only fly short distances.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Ground, PokemonType.Dragon };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Levitate, };
		public override Stats BaseStats => new Stats() {
			HP = 50,
			Attack = 70,
			Defense = 50,
			SpecialAttack = 50,
			SpecialDefense = 50,
			Speed = 70
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[0] = new List<Move>() { MoveFactory.DragonBreath, },
			[1] = new List<Move>() { MoveFactory.DragonBreath, MoveFactory.LaserFocus, MoveFactory.Bulldoze, MoveFactory.Dig, MoveFactory.Crunch, MoveFactory.Superpower, MoveFactory.Fissure, MoveFactory.SandAttack, MoveFactory.Astonish, MoveFactory.Supersonic, MoveFactory.Bite, },
			[12] = new List<Move>() { MoveFactory.MudSlap, },
			[16] = new List<Move>() { MoveFactory.SandTomb, },
			[20] = new List<Move>() { MoveFactory.DragonTail, },
			[24] = new List<Move>() { MoveFactory.Screech, },
			[28] = new List<Move>() { MoveFactory.BugBuzz, },
			[32] = new List<Move>() { MoveFactory.Sandstorm, },
			[38] = new List<Move>() { MoveFactory.EarthPower, },
			[44] = new List<Move>() { MoveFactory.Earthquake, },
			[50] = new List<Move>() { MoveFactory.Uproar, },
			[56] = new List<Move>() { MoveFactory.DragonRush, },
			[62] = new List<Move>() { MoveFactory.Boomburst, },
		};
	}
}

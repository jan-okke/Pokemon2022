using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Flygon : Pokemon
	{
		public override string Name => "Flygon";
		public override int Generation => 3;
		public override string PokedexEntry => "The flapping of its wings sounds like singing. To prevent detection by enemies, it hides itself by flapping up a cloud of desert sand.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Ground, PokemonType.Dragon };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Levitate, };
		public override Stats BaseStats => new Stats() {
			HP = 80,
			Attack = 100,
			Defense = 80,
			SpecialAttack = 80,
			SpecialDefense = 80,
			Speed = 100
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[0] = new List<Move>() { MoveFactory.DragonClaw, },
			[1] = new List<Move>() { MoveFactory.Outrage, MoveFactory.DragonClaw, MoveFactory.DragonBreath, MoveFactory.DragonDance, MoveFactory.Feint, MoveFactory.LaserFocus, MoveFactory.Bulldoze, MoveFactory.Dig, MoveFactory.Crunch, MoveFactory.Superpower, MoveFactory.Fissure, MoveFactory.SandAttack, MoveFactory.Astonish, MoveFactory.Supersonic, MoveFactory.Bite, },
			[12] = new List<Move>() { MoveFactory.MudSlap, },
			[16] = new List<Move>() { MoveFactory.SandTomb, },
			[20] = new List<Move>() { MoveFactory.DragonTail, },
			[24] = new List<Move>() { MoveFactory.Screech, },
			[28] = new List<Move>() { MoveFactory.BugBuzz, },
			[32] = new List<Move>() { MoveFactory.Sandstorm, },
			[38] = new List<Move>() { MoveFactory.EarthPower, },
			[44] = new List<Move>() { MoveFactory.Earthquake, },
			[52] = new List<Move>() { MoveFactory.Uproar, },
			[60] = new List<Move>() { MoveFactory.DragonRush, },
			[68] = new List<Move>() { MoveFactory.Boomburst, },
		};
	}
}

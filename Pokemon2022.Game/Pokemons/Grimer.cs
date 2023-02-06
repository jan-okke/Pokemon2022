using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Grimer : Pokemon
	{
		public override string Name => "Grimer";
		public override int Generation => 1;
		public override string PokedexEntry => "Born from polluted sludge in the sea, Grimer's favorite food is anything filthy. They feed on wastewater pumped out from factories.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Poison };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Stench, AbilityFactory.StickyHold, };
		public override Ability AvailableHiddenAbility => AbilityFactory.PoisonTouch;
		public override Stats BaseStats => new Stats() {
			HP = 80,
			Attack = 80,
			Defense = 50,
			SpecialAttack = 40,
			SpecialDefense = 50,
			Speed = 25
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Pound, MoveFactory.PoisonGas, },
			[4] = new List<Move>() { MoveFactory.Harden, },
			[7] = new List<Move>() { MoveFactory.MudSlap, },
			[12] = new List<Move>() { MoveFactory.Disable, },
			[15] = new List<Move>() { MoveFactory.Sludge, },
			[18] = new List<Move>() { MoveFactory.Smog, },
			[21] = new List<Move>() { MoveFactory.Minimize, },
			[26] = new List<Move>() { MoveFactory.Fling, },
			[29] = new List<Move>() { MoveFactory.SludgeBomb, },
			[32] = new List<Move>() { MoveFactory.SludgeWave, },
			[37] = new List<Move>() { MoveFactory.Screech, },
			[40] = new List<Move>() { MoveFactory.GunkShot, },
			[43] = new List<Move>() { MoveFactory.AcidArmor, },
			[46] = new List<Move>() { MoveFactory.Belch, },
			[48] = new List<Move>() { MoveFactory.Memento, },
		};
	}
}

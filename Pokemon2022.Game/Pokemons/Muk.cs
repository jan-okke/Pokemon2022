using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Muk : Pokemon
	{
		public override string Name => "Muk";
		public override int Generation => 1;
		public override string PokedexEntry => "It prefers warm and humid habitats. In the summertime, the toxic substances in its body intensify, making Muk reek like putrid kitchen garbage.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Poison };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Stench, AbilityFactory.StickyHold, };
		public override Ability AvailableHiddenAbility => AbilityFactory.PoisonTouch;
		public override Stats BaseStats => new Stats() {
			HP = 105,
			Attack = 105,
			Defense = 75,
			SpecialAttack = 65,
			SpecialDefense = 100,
			Speed = 50
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[0] = new List<Move>() { MoveFactory.VenomDrench, },
			[1] = new List<Move>() { MoveFactory.VenomDrench, MoveFactory.Pound, MoveFactory.PoisonGas, MoveFactory.Harden, MoveFactory.MudSlap, },
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
			[46] = new List<Move>() { MoveFactory.AcidArmor, },
			[52] = new List<Move>() { MoveFactory.Belch, },
			[57] = new List<Move>() { MoveFactory.Memento, },
		};
	}
}

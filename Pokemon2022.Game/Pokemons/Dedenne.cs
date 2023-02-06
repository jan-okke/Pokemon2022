using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Dedenne : Pokemon
	{
		public override string Name => "Dedenne";
		public override int Generation => 6;
		public override string PokedexEntry => "Its whiskers serve as antennas. By sending and receiving electrical waves, it can communicate with others over vast distances.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Electric, PokemonType.Fairy };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.CheekPouch, AbilityFactory.Pickup, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Plus;
		public override Stats BaseStats => new Stats() {
			HP = 67,
			Attack = 58,
			Defense = 57,
			SpecialAttack = 81,
			SpecialDefense = 67,
			Speed = 101
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Nuzzle, MoveFactory.TailWhip, },
			[5] = new List<Move>() { MoveFactory.Tackle, },
			[10] = new List<Move>() { MoveFactory.Charge, },
			[15] = new List<Move>() { MoveFactory.ThunderShock, },
			[20] = new List<Move>() { MoveFactory.Charm, },
			[25] = new List<Move>() { MoveFactory.ParabolicCharge, },
			[30] = new List<Move>() { MoveFactory.VoltSwitch, },
			[35] = new List<Move>() { MoveFactory.Rest, MoveFactory.Snore, },
			[40] = new List<Move>() { MoveFactory.Discharge, },
			[45] = new List<Move>() { MoveFactory.PlayRough, },
			[50] = new List<Move>() { MoveFactory.SuperFang, },
			[55] = new List<Move>() { MoveFactory.Entrainment, },
			[60] = new List<Move>() { MoveFactory.Thunder, },
		};
	}
}

using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Masquerain : Pokemon
	{
		public override string Name => "Masquerain";
		public override int Generation => 3;
		public override string PokedexEntry => "It intimidates foes with the large eyelike patterns on its antennae. Because it can't fly if its wings get wet, it shelters from rain under large trees and eaves.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Bug, PokemonType.Flying };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Intimidate, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Unnerve;
		public override Stats BaseStats => new Stats() {
			HP = 70,
			Attack = 60,
			Defense = 62,
			SpecialAttack = 100,
			SpecialDefense = 82,
			Speed = 80
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.QuiverDance, MoveFactory.Whirlwind, MoveFactory.BugBuzz, MoveFactory.QuickAttack, MoveFactory.SweetScent, },
			[6] = new List<Move>() { MoveFactory.QuickAttack, },
			[9] = new List<Move>() { MoveFactory.SweetScent, },
			[14] = new List<Move>() { MoveFactory.Soak, },
			[17] = new List<Move>() { MoveFactory.Gust, },
			[22] = new List<Move>() { MoveFactory.ScaryFace, MoveFactory.AirCutter, },
			[26] = new List<Move>() { MoveFactory.StunSpore, },
			[32] = new List<Move>() { MoveFactory.Supersonic, },
			[38] = new List<Move>() { MoveFactory.AirSlash, },
			[42] = new List<Move>() { MoveFactory.BugBuzz, },
			[48] = new List<Move>() { MoveFactory.Whirlwind, },
			[52] = new List<Move>() { MoveFactory.QuiverDance, },
		};
	}
}

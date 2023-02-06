using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Staraptor : Pokemon
	{
		public override string Name => "Staraptor";
		public override int Generation => 4;
		public override string PokedexEntry => "It has a savage nature. It will courageously challenge foes that are much larger.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Normal, PokemonType.Flying };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Intimidate, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Reckless;
		public override Stats BaseStats => new Stats() {
			HP = 85,
			Attack = 120,
			Defense = 70,
			SpecialAttack = 50,
			SpecialDefense = 60,
			Speed = 100
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[0] = new List<Move>() { MoveFactory.CloseCombat, },
			[1] = new List<Move>() { MoveFactory.CloseCombat, MoveFactory.Tackle, MoveFactory.Growl, MoveFactory.QuickAttack, MoveFactory.WingAttack, },
			[5] = new List<Move>() { MoveFactory.QuickAttack, },
			[9] = new List<Move>() { MoveFactory.WingAttack, },
			[13] = new List<Move>() { MoveFactory.DoubleTeam, },
			[18] = new List<Move>() { MoveFactory.Endeavor, },
			[23] = new List<Move>() { MoveFactory.Whirlwind, },
			[28] = new List<Move>() { MoveFactory.AerialAce, },
			[33] = new List<Move>() { MoveFactory.TakeDown, },
			[41] = new List<Move>() { MoveFactory.Agility, },
			[49] = new List<Move>() { MoveFactory.BraveBird, },
			[57] = new List<Move>() { MoveFactory.FinalGambit, },
		};
	}
}

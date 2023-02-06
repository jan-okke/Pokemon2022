using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Staravia : Pokemon
	{
		public override string Name => "Staravia";
		public override int Generation => 4;
		public override string PokedexEntry => "It flies around forests and fields in search of bug Pokémon. It stays within a huge flock.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Normal, PokemonType.Flying };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Intimidate, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Reckless;
		public override Stats BaseStats => new Stats() {
			HP = 55,
			Attack = 75,
			Defense = 50,
			SpecialAttack = 40,
			SpecialDefense = 40,
			Speed = 80
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Tackle, MoveFactory.Growl, MoveFactory.QuickAttack, },
			[5] = new List<Move>() { MoveFactory.QuickAttack, },
			[9] = new List<Move>() { MoveFactory.WingAttack, },
			[13] = new List<Move>() { MoveFactory.DoubleTeam, },
			[18] = new List<Move>() { MoveFactory.Endeavor, },
			[23] = new List<Move>() { MoveFactory.Whirlwind, },
			[28] = new List<Move>() { MoveFactory.AerialAce, },
			[33] = new List<Move>() { MoveFactory.TakeDown, },
			[38] = new List<Move>() { MoveFactory.Agility, },
			[43] = new List<Move>() { MoveFactory.BraveBird, },
			[48] = new List<Move>() { MoveFactory.FinalGambit, },
		};
	}
}

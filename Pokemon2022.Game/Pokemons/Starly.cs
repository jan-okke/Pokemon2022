using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Starly : Pokemon
	{
		public override string Name => "Starly";
		public override int Generation => 4;
		public override string PokedexEntry => "They flock in great numbers. Though small, they flap their wings with great power.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Normal, PokemonType.Flying };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.KeenEye, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Reckless;
		public override Stats BaseStats => new Stats() {
			HP = 40,
			Attack = 55,
			Defense = 30,
			SpecialAttack = 30,
			SpecialDefense = 30,
			Speed = 60
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Tackle, MoveFactory.Growl, },
			[5] = new List<Move>() { MoveFactory.QuickAttack, },
			[9] = new List<Move>() { MoveFactory.WingAttack, },
			[13] = new List<Move>() { MoveFactory.DoubleTeam, },
			[17] = new List<Move>() { MoveFactory.Endeavor, },
			[21] = new List<Move>() { MoveFactory.Whirlwind, },
			[25] = new List<Move>() { MoveFactory.AerialAce, },
			[29] = new List<Move>() { MoveFactory.TakeDown, },
			[33] = new List<Move>() { MoveFactory.Agility, },
			[37] = new List<Move>() { MoveFactory.BraveBird, },
			[41] = new List<Move>() { MoveFactory.FinalGambit, },
		};
	}
}

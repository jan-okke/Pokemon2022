using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Incineroar : Pokemon
	{
		public override string Name => "Incineroar";
		public override int Generation => 7;
		public override string PokedexEntry => "Although it's rough mannered and egotistical, it finds beating down unworthy opponents boring. It gets motivated for stronger opponents.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Fire, PokemonType.Dark };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Blaze, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Intimidate;
		public override Stats BaseStats => new Stats() {
			HP = 95,
			Attack = 115,
			Defense = 90,
			SpecialAttack = 80,
			SpecialDefense = 90,
			Speed = 60
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[0] = new List<Move>() { MoveFactory.DarkestLariat, },
			[1] = new List<Move>() { MoveFactory.DarkestLariat, MoveFactory.CrossChop, MoveFactory.ThroatChop, MoveFactory.BulkUp, MoveFactory.Scratch, MoveFactory.Growl, MoveFactory.Ember, MoveFactory.Lick, },
			[9] = new List<Move>() { MoveFactory.Roar, },
			[12] = new List<Move>() { MoveFactory.FurySwipes, },
			[15] = new List<Move>() { MoveFactory.Bite, },
			[20] = new List<Move>() { MoveFactory.DoubleKick, },
			[25] = new List<Move>() { MoveFactory.FireFang, },
			[30] = new List<Move>() { MoveFactory.ScaryFace, },
			[32] = new List<Move>() { MoveFactory.Swagger, },
			[44] = new List<Move>() { MoveFactory.Flamethrower, },
			[51] = new List<Move>() { MoveFactory.Thrash, },
			[58] = new List<Move>() { MoveFactory.FlareBlitz, },
		};
	}
}

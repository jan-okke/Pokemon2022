using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Ursaring : Pokemon
	{
		public override string Name => "Ursaring";
		public override int Generation => 2;
		public override string PokedexEntry => "In forests, it is said that there are many streams and towering trees where an Ursaring gathers food. It walks through its forest collecting food every day.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Normal };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Guts, AbilityFactory.QuickFeet, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Unnerve;
		public override Stats BaseStats => new Stats() {
			HP = 90,
			Attack = 130,
			Defense = 75,
			SpecialAttack = 75,
			SpecialDefense = 75,
			Speed = 55
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.HammerArm, MoveFactory.Covet, MoveFactory.Scratch, MoveFactory.Leer, MoveFactory.Lick, MoveFactory.FakeTears, },
			[8] = new List<Move>() { MoveFactory.FurySwipes, },
			[15] = new List<Move>() { MoveFactory.Payback, },
			[22] = new List<Move>() { MoveFactory.SweetScent, },
			[25] = new List<Move>() { MoveFactory.PlayNice, },
			[29] = new List<Move>() { MoveFactory.Slash, },
			[38] = new List<Move>() { MoveFactory.ScaryFace, },
			[47] = new List<Move>() { MoveFactory.Rest, },
			[49] = new List<Move>() { MoveFactory.Snore, },
			[58] = new List<Move>() { MoveFactory.Thrash, },
			[67] = new List<Move>() { MoveFactory.HammerArm, },
		};
	}
}

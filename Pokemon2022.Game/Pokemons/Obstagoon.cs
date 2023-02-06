using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Obstagoon : Pokemon
	{
		public override string Name => "Obstagoon";
		public override int Generation => 8;
		public override string PokedexEntry => "It evolved after experiencing numerous fights. While crossing its arms, it lets out a shout that would make any opponent flinch.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Dark, PokemonType.Normal };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Reckless, AbilityFactory.Guts, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Defiant;
		public override Stats BaseStats => new Stats() {
			HP = 93,
			Attack = 90,
			Defense = 101,
			SpecialAttack = 60,
			SpecialDefense = 81,
			Speed = 95
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[0] = new List<Move>() { MoveFactory.Obstruct, },
			[1] = new List<Move>() { MoveFactory.Obstruct, MoveFactory.CrossChop, MoveFactory.Submission, MoveFactory.NightSlash, MoveFactory.Switcheroo, MoveFactory.PinMissile, MoveFactory.BabyDollEyes, MoveFactory.Tackle, MoveFactory.Leer, MoveFactory.SandAttack, MoveFactory.Lick, },
			[9] = new List<Move>() { MoveFactory.Snarl, },
			[12] = new List<Move>() { MoveFactory.Headbutt, },
			[15] = new List<Move>() { MoveFactory.HoneClaws, },
			[18] = new List<Move>() { MoveFactory.FurySwipes, },
			[23] = new List<Move>() { MoveFactory.Rest, },
			[28] = new List<Move>() { MoveFactory.TakeDown, },
			[35] = new List<Move>() { MoveFactory.ScaryFace, },
			[42] = new List<Move>() { MoveFactory.Counter, },
			[49] = new List<Move>() { MoveFactory.Taunt, },
			[56] = new List<Move>() { MoveFactory.DoubleEdge, },
		};
	}
}

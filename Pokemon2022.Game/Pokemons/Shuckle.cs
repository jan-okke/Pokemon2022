using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Shuckle : Pokemon
	{
		public override string Name => "Shuckle";
		public override int Generation => 2;
		public override string PokedexEntry => "A Shuckle hides under rocks, keeping its body concealed inside its shell while eating stored berries. The berries mix with its body fluids to become a juice.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Bug, PokemonType.Rock };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Sturdy, AbilityFactory.Gluttony, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Contrary;
		public override Stats BaseStats => new Stats() {
			HP = 20,
			Attack = 10,
			Defense = 230,
			SpecialAttack = 10,
			SpecialDefense = 230,
			Speed = 5
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Withdraw, MoveFactory.Wrap, },
			[5] = new List<Move>() { MoveFactory.Rollout, },
			[10] = new List<Move>() { MoveFactory.StruggleBug, },
			[15] = new List<Move>() { MoveFactory.RockThrow, },
			[20] = new List<Move>() { MoveFactory.Safeguard, },
			[25] = new List<Move>() { MoveFactory.Rest, },
			[30] = new List<Move>() { MoveFactory.BugBite, },
			[35] = new List<Move>() { MoveFactory.PowerSplit, MoveFactory.GuardSplit, },
			[40] = new List<Move>() { MoveFactory.RockSlide, },
			[45] = new List<Move>() { MoveFactory.GastroAcid, },
			[50] = new List<Move>() { MoveFactory.StickyWeb, },
			[55] = new List<Move>() { MoveFactory.PowerTrick, },
			[60] = new List<Move>() { MoveFactory.StoneEdge, },
			[65] = new List<Move>() { MoveFactory.ShellSmash, },
		};
	}
}

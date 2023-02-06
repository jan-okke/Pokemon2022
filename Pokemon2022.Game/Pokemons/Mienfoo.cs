using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Mienfoo : Pokemon
	{
		public override string Name => "Mienfoo";
		public override int Generation => 5;
		public override string PokedexEntry => "They have mastered elegant combos. As they concentrate, their battle moves become swifter and more precise.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Fighting };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.InnerFocus, AbilityFactory.Regenerator, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Reckless;
		public override Stats BaseStats => new Stats() {
			HP = 45,
			Attack = 85,
			Defense = 50,
			SpecialAttack = 55,
			SpecialDefense = 50,
			Speed = 65
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Pound, MoveFactory.Detect, },
			[5] = new List<Move>() { MoveFactory.FakeOut, },
			[10] = new List<Move>() { MoveFactory.Reversal, },
			[15] = new List<Move>() { MoveFactory.FurySwipes, },
			[20] = new List<Move>() { MoveFactory.QuickGuard, },
			[25] = new List<Move>() { MoveFactory.ForcePalm, },
			[30] = new List<Move>() { MoveFactory.Uturn, },
			[35] = new List<Move>() { MoveFactory.DrainPunch, },
			[40] = new List<Move>() { MoveFactory.HoneClaws, },
			[45] = new List<Move>() { MoveFactory.AuraSphere, },
			[51] = new List<Move>() { MoveFactory.Bounce, },
			[55] = new List<Move>() { MoveFactory.CalmMind, },
			[60] = new List<Move>() { MoveFactory.HighJumpKick, },
		};
	}
}

using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Mienshao : Pokemon
	{
		public override string Name => "Mienshao";
		public override int Generation => 5;
		public override string PokedexEntry => "They use the long fur on their arms as a whip to strike their opponents.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Fighting };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.InnerFocus, AbilityFactory.Regenerator, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Reckless;
		public override Stats BaseStats => new Stats() {
			HP = 65,
			Attack = 125,
			Defense = 60,
			SpecialAttack = 95,
			SpecialDefense = 60,
			Speed = 105
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.QuickGuard, MoveFactory.Pound, MoveFactory.Detect, MoveFactory.FakeOut, MoveFactory.Reversal, },
			[15] = new List<Move>() { MoveFactory.FurySwipes, },
			[20] = new List<Move>() { MoveFactory.WideGuard, },
			[25] = new List<Move>() { MoveFactory.ForcePalm, },
			[30] = new List<Move>() { MoveFactory.Uturn, },
			[35] = new List<Move>() { MoveFactory.DrainPunch, },
			[40] = new List<Move>() { MoveFactory.HoneClaws, },
			[45] = new List<Move>() { MoveFactory.AuraSphere, },
			[53] = new List<Move>() { MoveFactory.Bounce, },
			[59] = new List<Move>() { MoveFactory.CalmMind, },
			[66] = new List<Move>() { MoveFactory.HighJumpKick, },
		};
	}
}

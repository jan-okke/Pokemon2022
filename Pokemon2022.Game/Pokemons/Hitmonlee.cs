using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Hitmonlee : Pokemon
	{
		public override string Name => "Hitmonlee";
		public override int Generation => 1;
		public override string PokedexEntry => "Its legs freely stretch and contract. Using these springlike limbs, it bowls over foes with devastating kicks. After battle, it rubs down its tired legs.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Fighting };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Limber, AbilityFactory.Reckless, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Unburden;
		public override Stats BaseStats => new Stats() {
			HP = 50,
			Attack = 120,
			Defense = 53,
			SpecialAttack = 35,
			SpecialDefense = 110,
			Speed = 87
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[0] = new List<Move>() { MoveFactory.BrickBreak, },
			[1] = new List<Move>() { MoveFactory.BrickBreak, MoveFactory.Feint, MoveFactory.LowSweep, MoveFactory.Tackle, MoveFactory.HelpingHand, MoveFactory.FakeOut, MoveFactory.FocusEnergy, },
			[4] = new List<Move>() { MoveFactory.DoubleKick, },
			[8] = new List<Move>() { MoveFactory.LowKick, },
			[12] = new List<Move>() { MoveFactory.Endure, },
			[16] = new List<Move>() { MoveFactory.Revenge, },
			[21] = new List<Move>() { MoveFactory.WideGuard, },
			[24] = new List<Move>() { MoveFactory.BlazeKick, },
			[28] = new List<Move>() { MoveFactory.MindReader, },
			[32] = new List<Move>() { MoveFactory.MegaKick, },
			[36] = new List<Move>() { MoveFactory.CloseCombat, },
			[40] = new List<Move>() { MoveFactory.Reversal, },
			[44] = new List<Move>() { MoveFactory.HighJumpKick, },
		};
	}
}

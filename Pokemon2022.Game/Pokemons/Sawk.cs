using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Sawk : Pokemon
	{
		public override string Name => "Sawk";
		public override int Generation => 5;
		public override string PokedexEntry => "Tying their belts gets them pumped and makes their punches more destructive. Disturbing their training angers them.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Fighting };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Sturdy, AbilityFactory.InnerFocus, };
		public override Ability AvailableHiddenAbility => AbilityFactory.MoldBreaker;
		public override Stats BaseStats => new Stats() {
			HP = 75,
			Attack = 125,
			Defense = 75,
			SpecialAttack = 30,
			SpecialDefense = 75,
			Speed = 85
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.RockSmash, MoveFactory.Leer, },
			[5] = new List<Move>() { MoveFactory.FocusEnergy, },
			[10] = new List<Move>() { MoveFactory.DoubleKick, },
			[15] = new List<Move>() { MoveFactory.QuickGuard, },
			[20] = new List<Move>() { MoveFactory.LowSweep, },
			[25] = new List<Move>() { MoveFactory.BulkUp, },
			[30] = new List<Move>() { MoveFactory.Retaliate, },
			[35] = new List<Move>() { MoveFactory.BrickBreak, },
			[40] = new List<Move>() { MoveFactory.Counter, },
			[45] = new List<Move>() { MoveFactory.Endure, },
			[50] = new List<Move>() { MoveFactory.Reversal, },
			[55] = new List<Move>() { MoveFactory.CloseCombat, },
		};
	}
}

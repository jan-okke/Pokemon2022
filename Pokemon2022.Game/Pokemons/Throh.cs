using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Throh : Pokemon
	{
		public override string Name => "Throh";
		public override int Generation => 5;
		public override string PokedexEntry => "When they encounter foes bigger than themselves, they try to throw them. They always travel in packs of five.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Fighting };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Guts, AbilityFactory.InnerFocus, };
		public override Ability AvailableHiddenAbility => AbilityFactory.MoldBreaker;
		public override Stats BaseStats => new Stats() {
			HP = 120,
			Attack = 100,
			Defense = 85,
			SpecialAttack = 30,
			SpecialDefense = 85,
			Speed = 45
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Bind, MoveFactory.Leer, },
			[5] = new List<Move>() { MoveFactory.FocusEnergy, },
			[10] = new List<Move>() { MoveFactory.CircleThrow, },
			[15] = new List<Move>() { MoveFactory.WideGuard, },
			[20] = new List<Move>() { MoveFactory.Revenge, },
			[25] = new List<Move>() { MoveFactory.BulkUp, },
			[30] = new List<Move>() { MoveFactory.StormThrow, },
			[35] = new List<Move>() { MoveFactory.VitalThrow, },
			[40] = new List<Move>() { MoveFactory.SeismicToss, },
			[45] = new List<Move>() { MoveFactory.Endure, },
			[50] = new List<Move>() { MoveFactory.Reversal, },
			[55] = new List<Move>() { MoveFactory.Superpower, },
		};
	}
}

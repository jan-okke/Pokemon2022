using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Bouffalant : Pokemon
	{
		public override string Name => "Bouffalant";
		public override int Generation => 5;
		public override string PokedexEntry => "They charge wildly and headbutt everything. They headbutts have enough destructive force to derail a train.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Normal };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Reckless, AbilityFactory.SapSipper, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Soundproof;
		public override Stats BaseStats => new Stats() {
			HP = 95,
			Attack = 110,
			Defense = 95,
			SpecialAttack = 40,
			SpecialDefense = 95,
			Speed = 55
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Tackle, MoveFactory.Leer, },
			[5] = new List<Move>() { MoveFactory.FocusEnergy, },
			[10] = new List<Move>() { MoveFactory.FuryAttack, },
			[15] = new List<Move>() { MoveFactory.Revenge, },
			[20] = new List<Move>() { MoveFactory.ScaryFace, },
			[25] = new List<Move>() { MoveFactory.HornAttack, },
			[30] = new List<Move>() { MoveFactory.Reversal, },
			[35] = new List<Move>() { MoveFactory.ThroatChop, },
			[40] = new List<Move>() { MoveFactory.HeadCharge, },
			[45] = new List<Move>() { MoveFactory.SwordsDance, },
			[50] = new List<Move>() { MoveFactory.Megahorn, },
			[55] = new List<Move>() { MoveFactory.GigaImpact, },
		};
	}
}

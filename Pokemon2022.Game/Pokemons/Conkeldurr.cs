using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Conkeldurr : Pokemon
	{
		public override string Name => "Conkeldurr";
		public override int Generation => 5;
		public override string PokedexEntry => "They use concrete pillars as walking canes. They know moves that enable them to swing the pillars freely in battle.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Fighting };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Guts, AbilityFactory.SheerForce, };
		public override Ability AvailableHiddenAbility => AbilityFactory.IronFist;
		public override Stats BaseStats => new Stats() {
			HP = 105,
			Attack = 140,
			Defense = 95,
			SpecialAttack = 55,
			SpecialDefense = 65,
			Speed = 45
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Pound, MoveFactory.Leer, MoveFactory.LowKick, MoveFactory.RockThrow, },
			[12] = new List<Move>() { MoveFactory.FocusEnergy, },
			[16] = new List<Move>() { MoveFactory.BulkUp, },
			[20] = new List<Move>() { MoveFactory.RockSlide, },
			[24] = new List<Move>() { MoveFactory.Slam, },
			[30] = new List<Move>() { MoveFactory.ScaryFace, },
			[36] = new List<Move>() { MoveFactory.DynamicPunch, },
			[42] = new List<Move>() { MoveFactory.HammerArm, },
			[48] = new List<Move>() { MoveFactory.StoneEdge, },
			[54] = new List<Move>() { MoveFactory.Superpower, },
			[60] = new List<Move>() { MoveFactory.FocusPunch, },
		};
	}
}

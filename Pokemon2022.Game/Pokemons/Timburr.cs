using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Timburr : Pokemon
	{
		public override string Name => "Timburr";
		public override int Generation => 5;
		public override string PokedexEntry => "These Pokémon appear at building sites and help out with construction. They always carry squared logs.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Fighting };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Guts, AbilityFactory.SheerForce, };
		public override Ability AvailableHiddenAbility => AbilityFactory.IronFist;
		public override Stats BaseStats => new Stats() {
			HP = 75,
			Attack = 80,
			Defense = 55,
			SpecialAttack = 25,
			SpecialDefense = 35,
			Speed = 35
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Pound, MoveFactory.Leer, },
			[4] = new List<Move>() { MoveFactory.LowKick, },
			[8] = new List<Move>() { MoveFactory.RockThrow, },
			[12] = new List<Move>() { MoveFactory.FocusEnergy, },
			[16] = new List<Move>() { MoveFactory.BulkUp, },
			[20] = new List<Move>() { MoveFactory.RockSlide, },
			[24] = new List<Move>() { MoveFactory.Slam, },
			[28] = new List<Move>() { MoveFactory.ScaryFace, },
			[32] = new List<Move>() { MoveFactory.DynamicPunch, },
			[36] = new List<Move>() { MoveFactory.HammerArm, },
			[40] = new List<Move>() { MoveFactory.StoneEdge, },
			[44] = new List<Move>() { MoveFactory.Superpower, },
			[48] = new List<Move>() { MoveFactory.FocusPunch, },
		};
	}
}

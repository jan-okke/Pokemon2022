using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Stufful : Pokemon
	{
		public override string Name => "Stufful";
		public override int Generation => 7;
		public override string PokedexEntry => "Despite its adorable appearance, when it gets angry and flails about, its arms and legs could knock a pro wrestler sprawling.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Normal, PokemonType.Fighting };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Fluffy, AbilityFactory.Klutz, };
		public override Ability AvailableHiddenAbility => AbilityFactory.CuteCharm;
		public override Stats BaseStats => new Stats() {
			HP = 70,
			Attack = 75,
			Defense = 50,
			SpecialAttack = 45,
			SpecialDefense = 50,
			Speed = 50
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Tackle, MoveFactory.Leer, },
			[4] = new List<Move>() { MoveFactory.BabyDollEyes, },
			[8] = new List<Move>() { MoveFactory.Payback, },
			[12] = new List<Move>() { MoveFactory.BrutalSwing, },
			[16] = new List<Move>() { MoveFactory.Endure, },
			[20] = new List<Move>() { MoveFactory.Strength, },
			[24] = new List<Move>() { MoveFactory.TakeDown, },
			[28] = new List<Move>() { MoveFactory.Flail, },
			[32] = new List<Move>() { MoveFactory.HammerArm, },
			[36] = new List<Move>() { MoveFactory.Thrash, },
			[40] = new List<Move>() { MoveFactory.PainSplit, },
			[44] = new List<Move>() { MoveFactory.DoubleEdge, },
			[48] = new List<Move>() { MoveFactory.Superpower, },
		};
	}
}

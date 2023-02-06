using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Bergmite : Pokemon
	{
		public override string Name => "Bergmite";
		public override int Generation => 6;
		public override string PokedexEntry => "It blocks opponents' attacks with the ice that shields its body. It uses cold air to repair any cracks with new ice.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Ice };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.OwnTempo, AbilityFactory.IceBody, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Sturdy;
		public override Stats BaseStats => new Stats() {
			HP = 55,
			Attack = 69,
			Defense = 85,
			SpecialAttack = 32,
			SpecialDefense = 35,
			Speed = 28
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.RapidSpin, MoveFactory.Harden, },
			[3] = new List<Move>() { MoveFactory.Tackle, },
			[6] = new List<Move>() { MoveFactory.PowderSnow, },
			[9] = new List<Move>() { MoveFactory.Curse, },
			[12] = new List<Move>() { MoveFactory.IcyWind, },
			[15] = new List<Move>() { MoveFactory.Protect, },
			[18] = new List<Move>() { MoveFactory.Avalanche, },
			[21] = new List<Move>() { MoveFactory.Bite, },
			[24] = new List<Move>() { MoveFactory.IceFang, },
			[27] = new List<Move>() { MoveFactory.IronDefense, },
			[30] = new List<Move>() { MoveFactory.Recover, },
			[33] = new List<Move>() { MoveFactory.Crunch, },
			[36] = new List<Move>() { MoveFactory.TakeDown, },
			[39] = new List<Move>() { MoveFactory.Blizzard, },
			[42] = new List<Move>() { MoveFactory.DoubleEdge, },
		};
	}
}

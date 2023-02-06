using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Patrat : Pokemon
	{
		public override string Name => "Patrat";
		public override int Generation => 5;
		public override string PokedexEntry => "Extremely cautious, they take shifts to maintain a constant watch of their nest. They feel insecure without a lookout.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Normal };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.RunAway, AbilityFactory.KeenEye, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Analytic;
		public override Stats BaseStats => new Stats() {
			HP = 45,
			Attack = 55,
			Defense = 39,
			SpecialAttack = 35,
			SpecialDefense = 39,
			Speed = 42
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Tackle, },
			[3] = new List<Move>() { MoveFactory.Leer, },
			[6] = new List<Move>() { MoveFactory.Bite, },
			[8] = new List<Move>() { MoveFactory.Bide, },
			[11] = new List<Move>() { MoveFactory.Detect, },
			[13] = new List<Move>() { MoveFactory.SandAttack, },
			[16] = new List<Move>() { MoveFactory.Crunch, },
			[18] = new List<Move>() { MoveFactory.Hypnosis, },
			[21] = new List<Move>() { MoveFactory.SuperFang, },
			[23] = new List<Move>() { MoveFactory.AfterYou, },
			[26] = new List<Move>() { MoveFactory.FocusEnergy, },
			[28] = new List<Move>() { MoveFactory.WorkUp, },
			[31] = new List<Move>() { MoveFactory.HyperFang, },
			[33] = new List<Move>() { MoveFactory.NastyPlot, },
			[36] = new List<Move>() { MoveFactory.MeanLook, },
			[38] = new List<Move>() { MoveFactory.BatonPass, },
			[41] = new List<Move>() { MoveFactory.Slam, },
		};
	}
}

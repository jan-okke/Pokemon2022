using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Watchog : Pokemon
	{
		public override string Name => "Watchog";
		public override int Generation => 5;
		public override string PokedexEntry => "They make the patterns on their bodies shine in order to threaten predators. Keen eyesight lets them see in the dark.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Normal };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Illuminate, AbilityFactory.KeenEye, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Analytic;
		public override Stats BaseStats => new Stats() {
			HP = 60,
			Attack = 85,
			Defense = 69,
			SpecialAttack = 60,
			SpecialDefense = 69,
			Speed = 77
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[0] = new List<Move>() { MoveFactory.ConfuseRay, },
			[1] = new List<Move>() { MoveFactory.ConfuseRay, MoveFactory.Rototiller, MoveFactory.Tackle, MoveFactory.Leer, MoveFactory.Bite, MoveFactory.LowKick, },
			[3] = new List<Move>() { MoveFactory.Leer, },
			[6] = new List<Move>() { MoveFactory.Bite, },
			[8] = new List<Move>() { MoveFactory.Bide, },
			[11] = new List<Move>() { MoveFactory.Detect, },
			[13] = new List<Move>() { MoveFactory.SandAttack, },
			[16] = new List<Move>() { MoveFactory.Crunch, },
			[18] = new List<Move>() { MoveFactory.Hypnosis, },
			[22] = new List<Move>() { MoveFactory.SuperFang, },
			[25] = new List<Move>() { MoveFactory.AfterYou, },
			[29] = new List<Move>() { MoveFactory.FocusEnergy, },
			[32] = new List<Move>() { MoveFactory.PsychUp, },
			[36] = new List<Move>() { MoveFactory.HyperFang, },
			[39] = new List<Move>() { MoveFactory.NastyPlot, },
			[43] = new List<Move>() { MoveFactory.MeanLook, },
			[46] = new List<Move>() { MoveFactory.BatonPass, },
			[50] = new List<Move>() { MoveFactory.Slam, },
		};
	}
}

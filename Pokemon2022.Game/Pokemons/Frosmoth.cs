using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Frosmoth : Pokemon
	{
		public override string Name => "Frosmoth";
		public override int Generation => 8;
		public override string PokedexEntry => "It shows no mercy to any who desecrate fields and mountains. It will fly around on its icy wings, causing a blizzard to chase offenders away.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Ice, PokemonType.Bug };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.ShieldDust, };
		public override Ability AvailableHiddenAbility => AbilityFactory.IceScales;
		public override Stats BaseStats => new Stats() {
			HP = 70,
			Attack = 65,
			Defense = 60,
			SpecialAttack = 125,
			SpecialDefense = 90,
			Speed = 65
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[0] = new List<Move>() { MoveFactory.IcyWind, },
			[1] = new List<Move>() { MoveFactory.IcyWind, MoveFactory.PowderSnow, MoveFactory.StruggleBug, MoveFactory.HelpingHand, MoveFactory.Attract, },
			[4] = new List<Move>() { MoveFactory.StunSpore, },
			[8] = new List<Move>() { MoveFactory.Infestation, },
			[12] = new List<Move>() { MoveFactory.Mist, },
			[16] = new List<Move>() { MoveFactory.Defog, },
			[21] = new List<Move>() { MoveFactory.FeatherDance, },
			[24] = new List<Move>() { MoveFactory.AuroraBeam, },
			[28] = new List<Move>() { MoveFactory.Hail, },
			[32] = new List<Move>() { MoveFactory.BugBuzz, },
			[36] = new List<Move>() { MoveFactory.AuroraVeil, },
			[40] = new List<Move>() { MoveFactory.Blizzard, },
			[44] = new List<Move>() { MoveFactory.Tailwind, },
			[48] = new List<Move>() { MoveFactory.WideGuard, },
			[52] = new List<Move>() { MoveFactory.QuiverDance, },
		};
	}
}

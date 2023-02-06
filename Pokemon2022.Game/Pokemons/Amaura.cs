using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Amaura : Pokemon
	{
		public override string Name => "Amaura";
		public override int Generation => 6;
		public override string PokedexEntry => "This ancient Pokémon was restored from part of its body that had been frozen in ice for over 100 million years.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Rock, PokemonType.Ice };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Refrigerate, };
		public override Ability AvailableHiddenAbility => AbilityFactory.SnowWarning;
		public override Stats BaseStats => new Stats() {
			HP = 77,
			Attack = 59,
			Defense = 50,
			SpecialAttack = 67,
			SpecialDefense = 63,
			Speed = 46
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.PowderSnow, MoveFactory.Growl, },
			[4] = new List<Move>() { MoveFactory.Encore, },
			[8] = new List<Move>() { MoveFactory.AncientPower, },
			[12] = new List<Move>() { MoveFactory.IcyWind, },
			[16] = new List<Move>() { MoveFactory.Round, },
			[20] = new List<Move>() { MoveFactory.Mist, },
			[24] = new List<Move>() { MoveFactory.AuroraBeam, },
			[28] = new List<Move>() { MoveFactory.ThunderWave, },
			[32] = new List<Move>() { MoveFactory.NaturePower, },
			[36] = new List<Move>() { MoveFactory.FreezeDry, },
			[40] = new List<Move>() { MoveFactory.IceBeam, },
			[44] = new List<Move>() { MoveFactory.LightScreen, },
			[48] = new List<Move>() { MoveFactory.Hail, },
			[52] = new List<Move>() { MoveFactory.Blizzard, },
			[56] = new List<Move>() { MoveFactory.HyperBeam, },
		};
	}
}

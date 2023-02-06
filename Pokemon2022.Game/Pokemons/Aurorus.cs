using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Aurorus : Pokemon
	{
		public override string Name => "Aurorus";
		public override int Generation => 6;
		public override string PokedexEntry => "Using its diamond-shaped crystals, it can instantly create a wall of ice to block an opponent's attack.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Rock, PokemonType.Ice };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Refrigerate, };
		public override Ability AvailableHiddenAbility => AbilityFactory.SnowWarning;
		public override Stats BaseStats => new Stats() {
			HP = 123,
			Attack = 77,
			Defense = 72,
			SpecialAttack = 99,
			SpecialDefense = 92,
			Speed = 58
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.PowderSnow, MoveFactory.Growl, MoveFactory.Encore, MoveFactory.AncientPower, },
			[12] = new List<Move>() { MoveFactory.IcyWind, },
			[16] = new List<Move>() { MoveFactory.Round, },
			[20] = new List<Move>() { MoveFactory.Mist, },
			[24] = new List<Move>() { MoveFactory.AuroraBeam, },
			[28] = new List<Move>() { MoveFactory.ThunderWave, },
			[32] = new List<Move>() { MoveFactory.NaturePower, },
			[36] = new List<Move>() { MoveFactory.FreezeDry, },
			[42] = new List<Move>() { MoveFactory.IceBeam, },
			[48] = new List<Move>() { MoveFactory.LightScreen, },
			[54] = new List<Move>() { MoveFactory.Hail, },
			[60] = new List<Move>() { MoveFactory.Blizzard, },
			[66] = new List<Move>() { MoveFactory.HyperBeam, },
		};
	}
}

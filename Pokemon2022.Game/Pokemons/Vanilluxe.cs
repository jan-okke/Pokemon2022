using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Vanilluxe : Pokemon
	{
		public override string Name => "Vanilluxe";
		public override int Generation => 5;
		public override string PokedexEntry => "If both heads get angry simultaneously, this Pokémon expels a blizzard, burying everything in snow.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Ice };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.IceBody, AbilityFactory.SnowWarning, };
		public override Ability AvailableHiddenAbility => AbilityFactory.WeakArmor;
		public override Stats BaseStats => new Stats() {
			HP = 71,
			Attack = 95,
			Defense = 85,
			SpecialAttack = 110,
			SpecialDefense = 95,
			Speed = 79
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.WeatherBall, MoveFactory.IcicleCrash, MoveFactory.FreezeDry, MoveFactory.Astonish, MoveFactory.Harden, MoveFactory.Taunt, MoveFactory.Mist, },
			[12] = new List<Move>() { MoveFactory.IcyWind, },
			[16] = new List<Move>() { MoveFactory.Avalanche, },
			[20] = new List<Move>() { MoveFactory.Hail, },
			[24] = new List<Move>() { MoveFactory.IcicleSpear, },
			[28] = new List<Move>() { MoveFactory.Uproar, },
			[32] = new List<Move>() { MoveFactory.AcidArmor, },
			[38] = new List<Move>() { MoveFactory.MirrorCoat, },
			[44] = new List<Move>() { MoveFactory.IceBeam, },
			[52] = new List<Move>() { MoveFactory.Blizzard, },
			[60] = new List<Move>() { MoveFactory.SheerCold, },
		};
	}
}

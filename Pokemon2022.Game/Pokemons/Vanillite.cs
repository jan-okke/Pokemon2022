using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Vanillite : Pokemon
	{
		public override string Name => "Vanillite";
		public override int Generation => 5;
		public override string PokedexEntry => "This Pokémon formed from icicles bathed in energy from the morning sun. It sleeps buried in snow.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Ice };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.IceBody, AbilityFactory.SnowCloak, };
		public override Ability AvailableHiddenAbility => AbilityFactory.WeakArmor;
		public override Stats BaseStats => new Stats() {
			HP = 36,
			Attack = 50,
			Defense = 50,
			SpecialAttack = 65,
			SpecialDefense = 60,
			Speed = 44
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Astonish, MoveFactory.Harden, },
			[4] = new List<Move>() { MoveFactory.Taunt, },
			[8] = new List<Move>() { MoveFactory.Mist, },
			[12] = new List<Move>() { MoveFactory.IcyWind, },
			[16] = new List<Move>() { MoveFactory.Avalanche, },
			[20] = new List<Move>() { MoveFactory.Hail, },
			[24] = new List<Move>() { MoveFactory.IcicleSpear, },
			[28] = new List<Move>() { MoveFactory.Uproar, },
			[32] = new List<Move>() { MoveFactory.AcidArmor, },
			[36] = new List<Move>() { MoveFactory.MirrorCoat, },
			[40] = new List<Move>() { MoveFactory.IceBeam, },
			[44] = new List<Move>() { MoveFactory.Blizzard, },
			[48] = new List<Move>() { MoveFactory.SheerCold, },
		};
	}
}

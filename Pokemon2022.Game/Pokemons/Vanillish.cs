using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Vanillish : Pokemon
	{
		public override string Name => "Vanillish";
		public override int Generation => 5;
		public override string PokedexEntry => "It conceals itself from enemy eyes by creating many small ice particles and hiding among them.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Ice };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.IceBody, AbilityFactory.SnowCloak, };
		public override Ability AvailableHiddenAbility => AbilityFactory.WeakArmor;
		public override Stats BaseStats => new Stats() {
			HP = 51,
			Attack = 65,
			Defense = 65,
			SpecialAttack = 80,
			SpecialDefense = 75,
			Speed = 59
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Astonish, MoveFactory.Harden, MoveFactory.Taunt, MoveFactory.Mist, },
			[12] = new List<Move>() { MoveFactory.IcyWind, },
			[16] = new List<Move>() { MoveFactory.Avalanche, },
			[20] = new List<Move>() { MoveFactory.Hail, },
			[24] = new List<Move>() { MoveFactory.IcicleSpear, },
			[28] = new List<Move>() { MoveFactory.Uproar, },
			[32] = new List<Move>() { MoveFactory.AcidArmor, },
			[38] = new List<Move>() { MoveFactory.MirrorCoat, },
			[44] = new List<Move>() { MoveFactory.IceBeam, },
			[50] = new List<Move>() { MoveFactory.Blizzard, },
			[56] = new List<Move>() { MoveFactory.SheerCold, },
		};
	}
}

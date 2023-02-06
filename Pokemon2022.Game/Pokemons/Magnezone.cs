using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Magnezone : Pokemon
	{
		public override string Name => "Magnezone";
		public override int Generation => 4;
		public override string PokedexEntry => "It evolved from exposure to a special magnetic field. Three units generate magnetism.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Electric, PokemonType.Steel };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.MagnetPull, AbilityFactory.Sturdy, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Analytic;
		public override Stats BaseStats => new Stats() {
			HP = 70,
			Attack = 70,
			Defense = 115,
			SpecialAttack = 130,
			SpecialDefense = 90,
			Speed = 60
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.TriAttack, MoveFactory.ElectricTerrain, MoveFactory.MagneticFlux, MoveFactory.MirrorCoat, MoveFactory.ThunderShock, MoveFactory.Tackle, MoveFactory.Supersonic, MoveFactory.ThunderWave, },
			[12] = new List<Move>() { MoveFactory.ElectroBall, },
			[16] = new List<Move>() { MoveFactory.GyroBall, },
			[20] = new List<Move>() { MoveFactory.Spark, },
			[24] = new List<Move>() { MoveFactory.Screech, },
			[28] = new List<Move>() { MoveFactory.MagnetRise, },
			[34] = new List<Move>() { MoveFactory.FlashCannon, },
			[40] = new List<Move>() { MoveFactory.Discharge, },
			[46] = new List<Move>() { MoveFactory.MetalSound, },
			[52] = new List<Move>() { MoveFactory.LightScreen, },
			[58] = new List<Move>() { MoveFactory.LockOn, },
			[64] = new List<Move>() { MoveFactory.ZapCannon, },
		};
	}
}

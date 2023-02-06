using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Magnemite : Pokemon
	{
		public override string Name => "Magnemite";
		public override int Generation => 1;
		public override string PokedexEntry => "The units at its sides are extremely powerful magnets. They generate enough magnetism to draw in iron objects from over 300 feet away.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Electric, PokemonType.Steel };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.MagnetPull, AbilityFactory.Sturdy, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Analytic;
		public override Stats BaseStats => new Stats() {
			HP = 25,
			Attack = 35,
			Defense = 70,
			SpecialAttack = 95,
			SpecialDefense = 55,
			Speed = 45
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.ThunderShock, MoveFactory.Tackle, },
			[4] = new List<Move>() { MoveFactory.Supersonic, },
			[8] = new List<Move>() { MoveFactory.ThunderWave, },
			[12] = new List<Move>() { MoveFactory.ElectroBall, },
			[16] = new List<Move>() { MoveFactory.GyroBall, },
			[20] = new List<Move>() { MoveFactory.Spark, },
			[24] = new List<Move>() { MoveFactory.Screech, },
			[28] = new List<Move>() { MoveFactory.MagnetRise, },
			[32] = new List<Move>() { MoveFactory.FlashCannon, },
			[36] = new List<Move>() { MoveFactory.Discharge, },
			[40] = new List<Move>() { MoveFactory.MetalSound, },
			[44] = new List<Move>() { MoveFactory.LightScreen, },
			[48] = new List<Move>() { MoveFactory.LockOn, },
			[52] = new List<Move>() { MoveFactory.ZapCannon, },
		};
	}
}

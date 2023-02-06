using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Magneton : Pokemon
	{
		public override string Name => "Magneton";
		public override int Generation => 1;
		public override string PokedexEntry => "It is actually three Magnemite linked by magnetism. It generates powerful radio waves that raise temperatures by 3.6 degrees F within a 3,300-foot radius.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Electric, PokemonType.Steel };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.MagnetPull, AbilityFactory.Sturdy, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Analytic;
		public override Stats BaseStats => new Stats() {
			HP = 50,
			Attack = 60,
			Defense = 95,
			SpecialAttack = 120,
			SpecialDefense = 70,
			Speed = 70
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[0] = new List<Move>() { MoveFactory.TriAttack, },
			[1] = new List<Move>() { MoveFactory.TriAttack, MoveFactory.ElectricTerrain, MoveFactory.ThunderShock, MoveFactory.Tackle, MoveFactory.Supersonic, MoveFactory.ThunderWave, },
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

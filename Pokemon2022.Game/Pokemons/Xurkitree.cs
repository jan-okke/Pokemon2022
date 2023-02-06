using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Xurkitree : Pokemon
	{
		public override string Name => "Xurkitree";
		public override int Generation => 7;
		public override string PokedexEntry => "One of the mysterious life-forms known as Ultra Beasts. Astonishing electric shocks emanate from its entire body, according to witnesses.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Electric };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.BeastBoost, };
		public override Stats BaseStats => new Stats() {
			HP = 83,
			Attack = 89,
			Defense = 71,
			SpecialAttack = 173,
			SpecialDefense = 71,
			Speed = 83
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Wrap, MoveFactory.ThunderShock, },
			[5] = new List<Move>() { MoveFactory.Charge, },
			[10] = new List<Move>() { MoveFactory.ThunderWave, },
			[15] = new List<Move>() { MoveFactory.Ingrain, },
			[20] = new List<Move>() { MoveFactory.Spark, },
			[25] = new List<Move>() { MoveFactory.ShockWave, },
			[30] = new List<Move>() { MoveFactory.Hypnosis, },
			[35] = new List<Move>() { MoveFactory.EerieImpulse, },
			[40] = new List<Move>() { MoveFactory.ThunderPunch, },
			[45] = new List<Move>() { MoveFactory.Discharge, },
			[50] = new List<Move>() { MoveFactory.MagnetRise, },
			[55] = new List<Move>() { MoveFactory.Thunderbolt, },
			[60] = new List<Move>() { MoveFactory.ElectricTerrain, },
			[65] = new List<Move>() { MoveFactory.PowerWhip, },
			[70] = new List<Move>() { MoveFactory.ZapCannon, },
		};
	}
}

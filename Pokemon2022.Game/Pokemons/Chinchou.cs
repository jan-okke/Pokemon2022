using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Chinchou : Pokemon
	{
		public override string Name => "Chinchou";
		public override int Generation => 2;
		public override string PokedexEntry => "When it senses danger, it discharges positive and negative electricity from its two antennae. It lives in depths beyond sunlight's reach.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Water, PokemonType.Electric };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.VoltAbsorb, AbilityFactory.Illuminate, };
		public override Ability AvailableHiddenAbility => AbilityFactory.WaterAbsorb;
		public override Stats BaseStats => new Stats() {
			HP = 75,
			Attack = 38,
			Defense = 38,
			SpecialAttack = 56,
			SpecialDefense = 56,
			Speed = 67
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.WaterGun, MoveFactory.Supersonic, },
			[4] = new List<Move>() { MoveFactory.ElectroBall, },
			[8] = new List<Move>() { MoveFactory.ThunderWave, },
			[12] = new List<Move>() { MoveFactory.BubbleBeam, },
			[16] = new List<Move>() { MoveFactory.ConfuseRay, },
			[20] = new List<Move>() { MoveFactory.Spark, },
			[24] = new List<Move>() { MoveFactory.Charge, },
			[28] = new List<Move>() { MoveFactory.Discharge, },
			[32] = new List<Move>() { MoveFactory.AquaRing, },
			[36] = new List<Move>() { MoveFactory.Flail, },
			[40] = new List<Move>() { MoveFactory.TakeDown, },
			[44] = new List<Move>() { MoveFactory.HydroPump, },
		};
	}
}

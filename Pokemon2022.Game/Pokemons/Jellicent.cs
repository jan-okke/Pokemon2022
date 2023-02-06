using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Jellicent : Pokemon
	{
		public override string Name => "Jellicent";
		public override int Generation => 5;
		public override string PokedexEntry => "They propel themselves by expelling absorbed seawater from their bodies. Their favorite food is life energy.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Water, PokemonType.Ghost };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.WaterAbsorb, AbilityFactory.CursedBody, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Damp;
		public override Stats BaseStats => new Stats() {
			HP = 100,
			Attack = 60,
			Defense = 70,
			SpecialAttack = 85,
			SpecialDefense = 105,
			Speed = 60
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.AcidArmor, MoveFactory.Absorb, MoveFactory.WaterGun, MoveFactory.PoisonSting, MoveFactory.NightShade, },
			[12] = new List<Move>() { MoveFactory.WaterPulse, },
			[16] = new List<Move>() { MoveFactory.RainDance, },
			[20] = new List<Move>() { MoveFactory.Hex, },
			[24] = new List<Move>() { MoveFactory.Brine, },
			[28] = new List<Move>() { MoveFactory.Recover, },
			[32] = new List<Move>() { MoveFactory.ShadowBall, },
			[36] = new List<Move>() { MoveFactory.Whirlpool, },
			[43] = new List<Move>() { MoveFactory.HydroPump, },
			[48] = new List<Move>() { MoveFactory.DestinyBond, },
			[54] = new List<Move>() { MoveFactory.WaterSpout, },
		};
	}
}

using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Lanturn : Pokemon
	{
		public override string Name => "Lanturn";
		public override int Generation => 2;
		public override string PokedexEntry => "The light-emitting orbs on its back are very bright. They are formed from a part of its dorsal fin. This Pokémon illuminates the inky darkness of deep seas.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Water, PokemonType.Electric };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.VoltAbsorb, AbilityFactory.Illuminate, };
		public override Ability AvailableHiddenAbility => AbilityFactory.WaterAbsorb;
		public override Stats BaseStats => new Stats() {
			HP = 125,
			Attack = 58,
			Defense = 58,
			SpecialAttack = 76,
			SpecialDefense = 76,
			Speed = 67
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[0] = new List<Move>() { MoveFactory.Stockpile, MoveFactory.Swallow, MoveFactory.SpitUp, },
			[1] = new List<Move>() { MoveFactory.Stockpile, MoveFactory.Swallow, MoveFactory.SpitUp, MoveFactory.EerieImpulse, MoveFactory.WaterGun, MoveFactory.Supersonic, MoveFactory.ElectroBall, MoveFactory.ThunderWave, },
			[12] = new List<Move>() { MoveFactory.BubbleBeam, },
			[16] = new List<Move>() { MoveFactory.ConfuseRay, },
			[20] = new List<Move>() { MoveFactory.Spark, },
			[24] = new List<Move>() { MoveFactory.Charge, },
			[30] = new List<Move>() { MoveFactory.Discharge, },
			[36] = new List<Move>() { MoveFactory.AquaRing, },
			[42] = new List<Move>() { MoveFactory.Flail, },
			[48] = new List<Move>() { MoveFactory.TakeDown, },
			[54] = new List<Move>() { MoveFactory.HydroPump, },
		};
	}
}

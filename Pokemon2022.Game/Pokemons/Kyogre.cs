using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Kyogre : Pokemon
	{
		public override string Name => "Kyogre";
		public override int Generation => 3;
		public override string PokedexEntry => "Kyogre has appeared in mythology as the creator of the sea. After long years of feuding with Groudon, it took to sleep at the bottom of the sea.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Water };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Drizzle, };
		public override Stats BaseStats => new Stats() {
			HP = 100,
			Attack = 100,
			Defense = 90,
			SpecialAttack = 150,
			SpecialDefense = 140,
			Speed = 90
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.WaterPulse, MoveFactory.AncientPower, MoveFactory.BodySlam, MoveFactory.ScaryFace, },
			[9] = new List<Move>() { MoveFactory.AquaTail, },
			[18] = new List<Move>() { MoveFactory.CalmMind, },
			[27] = new List<Move>() { MoveFactory.MuddyWater, },
			[36] = new List<Move>() { MoveFactory.IceBeam, },
			[45] = new List<Move>() { MoveFactory.SheerCold, },
			[54] = new List<Move>() { MoveFactory.AquaRing, },
			[63] = new List<Move>() { MoveFactory.OriginPulse, },
			[72] = new List<Move>() { MoveFactory.HydroPump, },
			[81] = new List<Move>() { MoveFactory.DoubleEdge, },
			[90] = new List<Move>() { MoveFactory.WaterSpout, },
		};
	}
}

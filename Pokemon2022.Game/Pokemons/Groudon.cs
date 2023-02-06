using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Groudon : Pokemon
	{
		public override string Name => "Groudon";
		public override int Generation => 3;
		public override string PokedexEntry => "Groudon has appeared in mythology as the creator of the land. It sleeps in magma underground and is said to make volcanoes erupt on awakening.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Ground };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Drought, };
		public override Stats BaseStats => new Stats() {
			HP = 100,
			Attack = 150,
			Defense = 140,
			SpecialAttack = 100,
			SpecialDefense = 90,
			Speed = 90
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.MudShot, MoveFactory.AncientPower, MoveFactory.LavaPlume, MoveFactory.ScaryFace, },
			[9] = new List<Move>() { MoveFactory.EarthPower, },
			[18] = new List<Move>() { MoveFactory.BulkUp, },
			[27] = new List<Move>() { MoveFactory.Earthquake, },
			[36] = new List<Move>() { MoveFactory.HammerArm, },
			[45] = new List<Move>() { MoveFactory.Fissure, },
			[54] = new List<Move>() { MoveFactory.Rest, },
			[63] = new List<Move>() { MoveFactory.PrecipiceBlades, },
			[72] = new List<Move>() { MoveFactory.FireBlast, },
			[81] = new List<Move>() { MoveFactory.SolarBeam, },
			[90] = new List<Move>() { MoveFactory.Eruption, },
		};
	}
}

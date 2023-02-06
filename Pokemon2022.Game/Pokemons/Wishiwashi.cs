using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Wishiwashi : Pokemon
	{
		public override string Name => "Wishiwashi";
		public override int Generation => 7;
		public override string PokedexEntry => "It's awfully weak and notably tasty, so everyone is always out to get it. As it happens, anyone trying to bully it receives a painful lesson.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Water };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Schooling, };
		public override Stats BaseStats => new Stats() {
			HP = 45,
			Attack = 20,
			Defense = 20,
			SpecialAttack = 25,
			SpecialDefense = 25,
			Speed = 40
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.WaterGun, MoveFactory.Growl, },
			[4] = new List<Move>() { MoveFactory.HelpingHand, },
			[8] = new List<Move>() { MoveFactory.BeatUp, },
			[12] = new List<Move>() { MoveFactory.Brine, },
			[16] = new List<Move>() { MoveFactory.TearfulLook, },
			[20] = new List<Move>() { MoveFactory.Dive, },
			[24] = new List<Move>() { MoveFactory.Soak, },
			[28] = new List<Move>() { MoveFactory.Uproar, },
			[32] = new List<Move>() { MoveFactory.AquaTail, },
			[36] = new List<Move>() { MoveFactory.AquaRing, },
			[40] = new List<Move>() { MoveFactory.Endeavor, },
			[44] = new List<Move>() { MoveFactory.HydroPump, },
			[48] = new List<Move>() { MoveFactory.DoubleEdge, },
		};
	}
}

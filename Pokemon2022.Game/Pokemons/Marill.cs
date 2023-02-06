using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Marill : Pokemon
	{
		public override string Name => "Marill";
		public override int Generation => 2;
		public override string PokedexEntry => "Its body is covered with water-repellent fur. Because of the fur, it can swim through water at high speed without being slowed by the water's resistance.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Water, PokemonType.Fairy };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.ThickFat, AbilityFactory.HugePower, };
		public override Ability AvailableHiddenAbility => AbilityFactory.SapSipper;
		public override Stats BaseStats => new Stats() {
			HP = 70,
			Attack = 20,
			Defense = 50,
			SpecialAttack = 20,
			SpecialDefense = 50,
			Speed = 40
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Rollout, MoveFactory.DefenseCurl, MoveFactory.Tackle, MoveFactory.WaterGun, MoveFactory.TailWhip, MoveFactory.HelpingHand, },
			[6] = new List<Move>() { MoveFactory.BubbleBeam, },
			[9] = new List<Move>() { MoveFactory.Charm, },
			[12] = new List<Move>() { MoveFactory.Slam, },
			[15] = new List<Move>() { MoveFactory.Bounce, },
			[19] = new List<Move>() { MoveFactory.AquaTail, },
			[21] = new List<Move>() { MoveFactory.PlayRough, },
			[24] = new List<Move>() { MoveFactory.AquaRing, },
			[27] = new List<Move>() { MoveFactory.RainDance, },
			[30] = new List<Move>() { MoveFactory.HydroPump, },
			[33] = new List<Move>() { MoveFactory.DoubleEdge, },
			[36] = new List<Move>() { MoveFactory.Superpower, },
		};
	}
}

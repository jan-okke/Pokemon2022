using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Azumarill : Pokemon
	{
		public override string Name => "Azumarill";
		public override int Generation => 2;
		public override string PokedexEntry => "It lives in water virtually all day long. Its body color and pattern act as camouflage that makes it tough for enemies to spot in water.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Water, PokemonType.Fairy };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.ThickFat, AbilityFactory.HugePower, };
		public override Ability AvailableHiddenAbility => AbilityFactory.SapSipper;
		public override Stats BaseStats => new Stats() {
			HP = 100,
			Attack = 50,
			Defense = 80,
			SpecialAttack = 60,
			SpecialDefense = 80,
			Speed = 50
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Rollout, MoveFactory.DefenseCurl, MoveFactory.Tackle, MoveFactory.WaterGun, MoveFactory.TailWhip, MoveFactory.HelpingHand, },
			[6] = new List<Move>() { MoveFactory.BubbleBeam, },
			[9] = new List<Move>() { MoveFactory.Charm, },
			[12] = new List<Move>() { MoveFactory.Slam, },
			[15] = new List<Move>() { MoveFactory.Bounce, },
			[21] = new List<Move>() { MoveFactory.AquaTail, },
			[25] = new List<Move>() { MoveFactory.PlayRough, },
			[30] = new List<Move>() { MoveFactory.AquaRing, },
			[35] = new List<Move>() { MoveFactory.RainDance, },
			[40] = new List<Move>() { MoveFactory.HydroPump, },
			[45] = new List<Move>() { MoveFactory.DoubleEdge, },
			[50] = new List<Move>() { MoveFactory.Superpower, },
		};
	}
}

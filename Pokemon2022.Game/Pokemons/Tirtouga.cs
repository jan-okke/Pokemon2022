using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Tirtouga : Pokemon
	{
		public override string Name => "Tirtouga";
		public override int Generation => 5;
		public override string PokedexEntry => "About 100 million years ago, these Pokémon swam in oceans. It is thought they also went on land to attack prey.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Water, PokemonType.Rock };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.SolidRock, AbilityFactory.Sturdy, };
		public override Ability AvailableHiddenAbility => AbilityFactory.SwiftSwim;
		public override Stats BaseStats => new Stats() {
			HP = 54,
			Attack = 78,
			Defense = 103,
			SpecialAttack = 53,
			SpecialDefense = 45,
			Speed = 22
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.WaterGun, MoveFactory.Withdraw, },
			[3] = new List<Move>() { MoveFactory.Protect, },
			[6] = new List<Move>() { MoveFactory.AquaJet, },
			[9] = new List<Move>() { MoveFactory.SmackDown, },
			[12] = new List<Move>() { MoveFactory.AncientPower, },
			[15] = new List<Move>() { MoveFactory.Bite, },
			[18] = new List<Move>() { MoveFactory.WideGuard, },
			[21] = new List<Move>() { MoveFactory.Brine, },
			[24] = new List<Move>() { MoveFactory.RockSlide, },
			[27] = new List<Move>() { MoveFactory.Crunch, },
			[30] = new List<Move>() { MoveFactory.Curse, },
			[33] = new List<Move>() { MoveFactory.IronDefense, },
			[36] = new List<Move>() { MoveFactory.AquaTail, },
			[39] = new List<Move>() { MoveFactory.RainDance, },
			[42] = new List<Move>() { MoveFactory.HydroPump, },
			[45] = new List<Move>() { MoveFactory.ShellSmash, },
		};
	}
}

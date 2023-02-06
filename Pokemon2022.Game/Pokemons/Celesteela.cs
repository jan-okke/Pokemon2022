using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Celesteela : Pokemon
	{
		public override string Name => "Celesteela";
		public override int Generation => 7;
		public override string PokedexEntry => "One kind of Ultra Beast. Witnesses have seen it burn down a forest by expelling gas from its two arms.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Steel, PokemonType.Flying };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.BeastBoost, };
		public override Stats BaseStats => new Stats() {
			HP = 97,
			Attack = 101,
			Defense = 103,
			SpecialAttack = 107,
			SpecialDefense = 101,
			Speed = 61
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Absorb, MoveFactory.Tackle, },
			[5] = new List<Move>() { MoveFactory.Harden, },
			[10] = new List<Move>() { MoveFactory.WideGuard, },
			[15] = new List<Move>() { MoveFactory.MegaDrain, },
			[20] = new List<Move>() { MoveFactory.SmackDown, },
			[25] = new List<Move>() { MoveFactory.Ingrain, },
			[30] = new List<Move>() { MoveFactory.Autotomize, },
			[35] = new List<Move>() { MoveFactory.GigaDrain, },
			[40] = new List<Move>() { MoveFactory.FlashCannon, },
			[45] = new List<Move>() { MoveFactory.MetalSound, },
			[50] = new List<Move>() { MoveFactory.IronDefense, },
			[55] = new List<Move>() { MoveFactory.LeechSeed, },
			[60] = new List<Move>() { MoveFactory.HeavySlam, },
			[65] = new List<Move>() { MoveFactory.DoubleEdge, },
			[70] = new List<Move>() { MoveFactory.SkullBash, },
		};
	}
}

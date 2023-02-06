using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Roselia : Pokemon
	{
		public override string Name => "Roselia";
		public override int Generation => 3;
		public override string PokedexEntry => "A Roselia that drinks nutritionally rich springwater blooms with lovely flowers. The fragrance of its flowers has the effect of making its foes careless.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Grass, PokemonType.Poison };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.NaturalCure, AbilityFactory.PoisonPoint, };
		public override Ability AvailableHiddenAbility => AbilityFactory.LeafGuard;
		public override Stats BaseStats => new Stats() {
			HP = 50,
			Attack = 60,
			Defense = 45,
			SpecialAttack = 100,
			SpecialDefense = 80,
			Speed = 65
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[0] = new List<Move>() { MoveFactory.PoisonSting, },
			[1] = new List<Move>() { MoveFactory.PoisonSting, MoveFactory.Absorb, MoveFactory.Growth, MoveFactory.StunSpore, MoveFactory.WorrySeed, },
			[5] = new List<Move>() { MoveFactory.MegaDrain, },
			[10] = new List<Move>() { MoveFactory.LeechSeed, },
			[15] = new List<Move>() { MoveFactory.MagicalLeaf, },
			[20] = new List<Move>() { MoveFactory.ToxicSpikes, },
			[25] = new List<Move>() { MoveFactory.SweetScent, },
			[30] = new List<Move>() { MoveFactory.GigaDrain, },
			[35] = new List<Move>() { MoveFactory.Synthesis, },
			[40] = new List<Move>() { MoveFactory.Toxic, },
			[45] = new List<Move>() { MoveFactory.PetalBlizzard, },
			[50] = new List<Move>() { MoveFactory.Aromatherapy, },
			[55] = new List<Move>() { MoveFactory.Ingrain, },
			[60] = new List<Move>() { MoveFactory.PetalDance, },
		};
	}
}

using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Exeggcute : Pokemon
	{
		public override string Name => "Exeggcute";
		public override int Generation => 1;
		public override string PokedexEntry => "It consists of six eggs that care for each other. The eggs attract each other and spin around. When cracks increasingly appear, it is close to evolution.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Grass, PokemonType.Psychic };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Chlorophyll, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Harvest;
		public override Stats BaseStats => new Stats() {
			HP = 60,
			Attack = 40,
			Defense = 80,
			SpecialAttack = 60,
			SpecialDefense = 45,
			Speed = 40
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Absorb, MoveFactory.Hypnosis, },
			[5] = new List<Move>() { MoveFactory.Reflect, },
			[10] = new List<Move>() { MoveFactory.LeechSeed, },
			[15] = new List<Move>() { MoveFactory.MegaDrain, },
			[20] = new List<Move>() { MoveFactory.Confusion, },
			[25] = new List<Move>() { MoveFactory.Synthesis, },
			[30] = new List<Move>() { MoveFactory.BulletSeed, },
			[35] = new List<Move>() { MoveFactory.GigaDrain, },
			[40] = new List<Move>() { MoveFactory.Extrasensory, },
			[45] = new List<Move>() { MoveFactory.Uproar, },
			[50] = new List<Move>() { MoveFactory.WorrySeed, },
			[55] = new List<Move>() { MoveFactory.SolarBeam, },
		};
	}
}

using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Jumpluff : Pokemon
	{
		public override string Name => "Jumpluff";
		public override int Generation => 2;
		public override string PokedexEntry => "Jumpluff ride warm southern winds to cross the sea and fly to foreign lands. This Pokémon lands when it encounters cold air while it is floating.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Grass, PokemonType.Flying };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Chlorophyll, AbilityFactory.LeafGuard, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Infiltrator;
		public override Stats BaseStats => new Stats() {
			HP = 75,
			Attack = 55,
			Defense = 70,
			SpecialAttack = 55,
			SpecialDefense = 95,
			Speed = 110
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Splash, MoveFactory.Absorb, MoveFactory.Synthesis, MoveFactory.TailWhip, },
			[4] = new List<Move>() { MoveFactory.Synthesis, },
			[6] = new List<Move>() { MoveFactory.TailWhip, },
			[8] = new List<Move>() { MoveFactory.Tackle, },
			[10] = new List<Move>() { MoveFactory.FairyWind, },
			[12] = new List<Move>() { MoveFactory.PoisonPowder, },
			[14] = new List<Move>() { MoveFactory.StunSpore, },
			[16] = new List<Move>() { MoveFactory.SleepPowder, },
			[20] = new List<Move>() { MoveFactory.BulletSeed, },
			[24] = new List<Move>() { MoveFactory.LeechSeed, },
			[29] = new List<Move>() { MoveFactory.MegaDrain, },
			[34] = new List<Move>() { MoveFactory.Acrobatics, },
			[39] = new List<Move>() { MoveFactory.RagePowder, },
			[44] = new List<Move>() { MoveFactory.CottonSpore, },
			[49] = new List<Move>() { MoveFactory.Uturn, },
			[54] = new List<Move>() { MoveFactory.WorrySeed, },
			[59] = new List<Move>() { MoveFactory.GigaDrain, },
			[64] = new List<Move>() { MoveFactory.Bounce, },
			[69] = new List<Move>() { MoveFactory.Memento, },
		};
	}
}

using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Hoppip : Pokemon
	{
		public override string Name => "Hoppip";
		public override int Generation => 2;
		public override string PokedexEntry => "This Pokémon drifts and floats with the wind. If it senses the approach of strong winds, a Hoppip links leaves with others to prepare against being blown away.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Grass, PokemonType.Flying };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Chlorophyll, AbilityFactory.LeafGuard, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Infiltrator;
		public override Stats BaseStats => new Stats() {
			HP = 35,
			Attack = 35,
			Defense = 40,
			SpecialAttack = 35,
			SpecialDefense = 55,
			Speed = 50
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Splash, MoveFactory.Absorb, },
			[4] = new List<Move>() { MoveFactory.Synthesis, },
			[6] = new List<Move>() { MoveFactory.TailWhip, },
			[8] = new List<Move>() { MoveFactory.Tackle, },
			[10] = new List<Move>() { MoveFactory.FairyWind, },
			[12] = new List<Move>() { MoveFactory.PoisonPowder, },
			[14] = new List<Move>() { MoveFactory.StunSpore, },
			[16] = new List<Move>() { MoveFactory.SleepPowder, },
			[19] = new List<Move>() { MoveFactory.BulletSeed, },
			[22] = new List<Move>() { MoveFactory.LeechSeed, },
			[25] = new List<Move>() { MoveFactory.MegaDrain, },
			[28] = new List<Move>() { MoveFactory.Acrobatics, },
			[31] = new List<Move>() { MoveFactory.RagePowder, },
			[34] = new List<Move>() { MoveFactory.CottonSpore, },
			[37] = new List<Move>() { MoveFactory.Uturn, },
			[40] = new List<Move>() { MoveFactory.WorrySeed, },
			[43] = new List<Move>() { MoveFactory.GigaDrain, },
			[46] = new List<Move>() { MoveFactory.Bounce, },
			[49] = new List<Move>() { MoveFactory.Memento, },
		};
	}
}

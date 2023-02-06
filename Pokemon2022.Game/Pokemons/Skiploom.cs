using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Skiploom : Pokemon
	{
		public override string Name => "Skiploom";
		public override int Generation => 2;
		public override string PokedexEntry => "It blossoms when the temperature rises above 64 degrees F. Because its flower's blooming changes with the temperature, it is sometimes used as a thermometer.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Grass, PokemonType.Flying };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Chlorophyll, AbilityFactory.LeafGuard, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Infiltrator;
		public override Stats BaseStats => new Stats() {
			HP = 55,
			Attack = 45,
			Defense = 50,
			SpecialAttack = 45,
			SpecialDefense = 65,
			Speed = 80
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
			[28] = new List<Move>() { MoveFactory.MegaDrain, },
			[32] = new List<Move>() { MoveFactory.Acrobatics, },
			[36] = new List<Move>() { MoveFactory.RagePowder, },
			[40] = new List<Move>() { MoveFactory.CottonSpore, },
			[44] = new List<Move>() { MoveFactory.Uturn, },
			[48] = new List<Move>() { MoveFactory.WorrySeed, },
			[52] = new List<Move>() { MoveFactory.GigaDrain, },
			[56] = new List<Move>() { MoveFactory.Bounce, },
			[60] = new List<Move>() { MoveFactory.Memento, },
		};
	}
}

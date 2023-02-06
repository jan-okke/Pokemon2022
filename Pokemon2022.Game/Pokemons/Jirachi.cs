using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Jirachi : Pokemon
	{
		public override string Name => "Jirachi";
		public override int Generation => 3;
		public override string PokedexEntry => "Jirachi is said to make wishes come true. While it sleeps, a tough crystalline shell envelops the body to protect it from enemies.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Steel, PokemonType.Psychic };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.SereneGrace, };
		public override Stats BaseStats => new Stats() {
			HP = 100,
			Attack = 100,
			Defense = 100,
			SpecialAttack = 100,
			SpecialDefense = 100,
			Speed = 100
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Confusion, MoveFactory.Wish, },
			[7] = new List<Move>() { MoveFactory.Swift, },
			[14] = new List<Move>() { MoveFactory.HelpingHand, },
			[21] = new List<Move>() { MoveFactory.LifeDew, },
			[28] = new List<Move>() { MoveFactory.ZenHeadbutt, },
			[35] = new List<Move>() { MoveFactory.Gravity, },
			[42] = new List<Move>() { MoveFactory.Psychic, },
			[49] = new List<Move>() { MoveFactory.MeteorMash, },
			[56] = new List<Move>() { MoveFactory.HealingWish, },
			[63] = new List<Move>() { MoveFactory.Rest, },
			[70] = new List<Move>() { MoveFactory.FutureSight, },
			[77] = new List<Move>() { MoveFactory.DoubleEdge, },
			[84] = new List<Move>() { MoveFactory.CosmicPower, },
			[91] = new List<Move>() { MoveFactory.LastResort, },
			[98] = new List<Move>() { MoveFactory.DoomDesire, },
		};
	}
}

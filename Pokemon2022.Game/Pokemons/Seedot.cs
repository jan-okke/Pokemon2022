using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Seedot : Pokemon
	{
		public override string Name => "Seedot";
		public override int Generation => 3;
		public override string PokedexEntry => "It hangs off branches and absorbs nutrients. When it finishes eating, its body becomes so heavy that it drops to the ground with a thump.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Grass };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Chlorophyll, AbilityFactory.EarlyBird, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Pickpocket;
		public override Stats BaseStats => new Stats() {
			HP = 40,
			Attack = 40,
			Defense = 50,
			SpecialAttack = 30,
			SpecialDefense = 30,
			Speed = 30
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Tackle, MoveFactory.Harden, },
			[3] = new List<Move>() { MoveFactory.Absorb, },
			[6] = new List<Move>() { MoveFactory.Astonish, },
			[9] = new List<Move>() { MoveFactory.Growth, },
			[12] = new List<Move>() { MoveFactory.Rollout, },
			[15] = new List<Move>() { MoveFactory.MegaDrain, },
			[18] = new List<Move>() { MoveFactory.Payback, },
			[21] = new List<Move>() { MoveFactory.NaturePower, },
			[24] = new List<Move>() { MoveFactory.SunnyDay, },
			[27] = new List<Move>() { MoveFactory.Synthesis, },
			[30] = new List<Move>() { MoveFactory.SuckerPunch, },
			[33] = new List<Move>() { MoveFactory.Explosion, },
		};
	}
}

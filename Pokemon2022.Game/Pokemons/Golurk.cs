using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Golurk : Pokemon
	{
		public override string Name => "Golurk";
		public override int Generation => 5;
		public override string PokedexEntry => "It is said that Golurk were ordered to protect people and Pokémon by the ancient people who made them.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Ground, PokemonType.Ghost };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.IronFist, AbilityFactory.Klutz, };
		public override Ability AvailableHiddenAbility => AbilityFactory.NoGuard;
		public override Stats BaseStats => new Stats() {
			HP = 89,
			Attack = 124,
			Defense = 80,
			SpecialAttack = 55,
			SpecialDefense = 80,
			Speed = 55
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.HighHorsepower, MoveFactory.FocusPunch, MoveFactory.MudSlap, MoveFactory.Astonish, MoveFactory.DefenseCurl, MoveFactory.Pound, },
			[12] = new List<Move>() { MoveFactory.ShadowPunch, },
			[16] = new List<Move>() { MoveFactory.Curse, },
			[20] = new List<Move>() { MoveFactory.NightShade, },
			[24] = new List<Move>() { MoveFactory.StompingTantrum, },
			[28] = new List<Move>() { MoveFactory.IronDefense, },
			[32] = new List<Move>() { MoveFactory.MegaPunch, },
			[36] = new List<Move>() { MoveFactory.ShadowBall, },
			[40] = new List<Move>() { MoveFactory.HeavySlam, },
			[46] = new List<Move>() { MoveFactory.PhantomForce, },
			[52] = new List<Move>() { MoveFactory.HammerArm, },
			[58] = new List<Move>() { MoveFactory.Earthquake, },
			[64] = new List<Move>() { MoveFactory.DynamicPunch, },
		};
	}
}

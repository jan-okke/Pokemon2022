using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Golett : Pokemon
	{
		public override string Name => "Golett";
		public override int Generation => 5;
		public override string PokedexEntry => "These Pokémon are thought to have been created by the science of an ancient and mysterious civilization.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Ground, PokemonType.Ghost };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.IronFist, AbilityFactory.Klutz, };
		public override Ability AvailableHiddenAbility => AbilityFactory.NoGuard;
		public override Stats BaseStats => new Stats() {
			HP = 59,
			Attack = 74,
			Defense = 50,
			SpecialAttack = 35,
			SpecialDefense = 50,
			Speed = 35
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.MudSlap, MoveFactory.Astonish, },
			[4] = new List<Move>() { MoveFactory.DefenseCurl, },
			[8] = new List<Move>() { MoveFactory.Pound, },
			[12] = new List<Move>() { MoveFactory.ShadowPunch, },
			[16] = new List<Move>() { MoveFactory.Curse, },
			[20] = new List<Move>() { MoveFactory.NightShade, },
			[24] = new List<Move>() { MoveFactory.StompingTantrum, },
			[28] = new List<Move>() { MoveFactory.IronDefense, },
			[32] = new List<Move>() { MoveFactory.MegaPunch, },
			[36] = new List<Move>() { MoveFactory.ShadowBall, },
			[40] = new List<Move>() { MoveFactory.HeavySlam, },
			[44] = new List<Move>() { MoveFactory.PhantomForce, },
			[48] = new List<Move>() { MoveFactory.HammerArm, },
			[52] = new List<Move>() { MoveFactory.Earthquake, },
			[56] = new List<Move>() { MoveFactory.DynamicPunch, },
		};
	}
}

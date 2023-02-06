using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Forretress : Pokemon
	{
		public override string Name => "Forretress";
		public override int Generation => 2;
		public override string PokedexEntry => "It keeps itself inside its steel shell. The shell is opened when it is catching prey, but it is so quick that the shell's inside cannot be seen.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Bug, PokemonType.Steel };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Sturdy, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Overcoat;
		public override Stats BaseStats => new Stats() {
			HP = 75,
			Attack = 90,
			Defense = 140,
			SpecialAttack = 60,
			SpecialDefense = 60,
			Speed = 40
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[0] = new List<Move>() { MoveFactory.Autotomize, },
			[1] = new List<Move>() { MoveFactory.Autotomize, MoveFactory.HeavySlam, MoveFactory.ZapCannon, MoveFactory.MagnetRise, MoveFactory.ToxicSpikes, MoveFactory.Tackle, MoveFactory.Protect, MoveFactory.SelfDestruct, MoveFactory.BugBite, },
			[6] = new List<Move>() { MoveFactory.SelfDestruct, },
			[9] = new List<Move>() { MoveFactory.BugBite, },
			[12] = new List<Move>() { MoveFactory.TakeDown, },
			[17] = new List<Move>() { MoveFactory.RapidSpin, },
			[20] = new List<Move>() { MoveFactory.Reflect, },
			[23] = new List<Move>() { MoveFactory.Rollout, },
			[28] = new List<Move>() { MoveFactory.Spikes, },
			[32] = new List<Move>() { MoveFactory.Payback, },
			[36] = new List<Move>() { MoveFactory.Explosion, },
			[42] = new List<Move>() { MoveFactory.IronDefense, },
			[46] = new List<Move>() { MoveFactory.GyroBall, },
			[50] = new List<Move>() { MoveFactory.DoubleEdge, },
			[56] = new List<Move>() { MoveFactory.MagnetRise, },
			[60] = new List<Move>() { MoveFactory.ZapCannon, },
			[64] = new List<Move>() { MoveFactory.HeavySlam, },
		};
	}
}

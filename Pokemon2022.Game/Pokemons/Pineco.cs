using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Pineco : Pokemon
	{
		public override string Name => "Pineco";
		public override int Generation => 2;
		public override string PokedexEntry => "A Pineco hangs from a tree branch and waits for prey. While eating, if it is disturbed by someone shaking its tree, it falls on the ground and explodes.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Bug };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Sturdy, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Overcoat;
		public override Stats BaseStats => new Stats() {
			HP = 50,
			Attack = 65,
			Defense = 90,
			SpecialAttack = 35,
			SpecialDefense = 35,
			Speed = 15
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Tackle, MoveFactory.Protect, },
			[6] = new List<Move>() { MoveFactory.SelfDestruct, },
			[9] = new List<Move>() { MoveFactory.BugBite, },
			[12] = new List<Move>() { MoveFactory.TakeDown, },
			[17] = new List<Move>() { MoveFactory.RapidSpin, },
			[20] = new List<Move>() { MoveFactory.Autotomize, },
			[23] = new List<Move>() { MoveFactory.Rollout, },
			[28] = new List<Move>() { MoveFactory.Spikes, },
			[31] = new List<Move>() { MoveFactory.Payback, },
			[34] = new List<Move>() { MoveFactory.Explosion, },
			[39] = new List<Move>() { MoveFactory.IronDefense, },
			[42] = new List<Move>() { MoveFactory.GyroBall, },
			[45] = new List<Move>() { MoveFactory.DoubleEdge, },
		};
	}
}

using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Whirlipede : Pokemon
	{
		public override string Name => "Whirlipede";
		public override int Generation => 5;
		public override string PokedexEntry => "It is usually motionless, but when attacked, it rotates at high speed and then crashes into its opponent.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Bug, PokemonType.Poison };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.PoisonPoint, AbilityFactory.Swarm, };
		public override Ability AvailableHiddenAbility => AbilityFactory.SpeedBoost;
		public override Stats BaseStats => new Stats() {
			HP = 40,
			Attack = 55,
			Defense = 99,
			SpecialAttack = 40,
			SpecialDefense = 79,
			Speed = 47
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[0] = new List<Move>() { MoveFactory.IronDefense, },
			[1] = new List<Move>() { MoveFactory.IronDefense, MoveFactory.PoisonSting, MoveFactory.DefenseCurl, MoveFactory.Rollout, MoveFactory.Protect, },
			[12] = new List<Move>() { MoveFactory.PoisonTail, },
			[16] = new List<Move>() { MoveFactory.Screech, },
			[20] = new List<Move>() { MoveFactory.BugBite, },
			[26] = new List<Move>() { MoveFactory.Venoshock, },
			[32] = new List<Move>() { MoveFactory.TakeDown, },
			[38] = new List<Move>() { MoveFactory.Agility, },
			[44] = new List<Move>() { MoveFactory.Toxic, },
			[50] = new List<Move>() { MoveFactory.VenomDrench, },
			[56] = new List<Move>() { MoveFactory.DoubleEdge, },
		};
	}
}

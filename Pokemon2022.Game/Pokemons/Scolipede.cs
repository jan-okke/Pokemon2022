using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Scolipede : Pokemon
	{
		public override string Name => "Scolipede";
		public override int Generation => 5;
		public override string PokedexEntry => "Highly aggressive, it uses the claws near its neck to dig into its opponents and poison them.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Bug, PokemonType.Poison };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.PoisonPoint, AbilityFactory.Swarm, };
		public override Ability AvailableHiddenAbility => AbilityFactory.SpeedBoost;
		public override Stats BaseStats => new Stats() {
			HP = 60,
			Attack = 100,
			Defense = 89,
			SpecialAttack = 55,
			SpecialDefense = 69,
			Speed = 112
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.IronDefense, MoveFactory.BatonPass, MoveFactory.PoisonSting, MoveFactory.DefenseCurl, MoveFactory.Rollout, MoveFactory.Protect, },
			[12] = new List<Move>() { MoveFactory.PoisonTail, },
			[16] = new List<Move>() { MoveFactory.Screech, },
			[20] = new List<Move>() { MoveFactory.BugBite, },
			[26] = new List<Move>() { MoveFactory.Venoshock, },
			[34] = new List<Move>() { MoveFactory.TakeDown, },
			[42] = new List<Move>() { MoveFactory.Agility, },
			[50] = new List<Move>() { MoveFactory.Toxic, },
			[58] = new List<Move>() { MoveFactory.VenomDrench, },
			[66] = new List<Move>() { MoveFactory.DoubleEdge, },
			[74] = new List<Move>() { MoveFactory.Megahorn, },
		};
	}
}

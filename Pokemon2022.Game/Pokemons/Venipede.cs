using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Venipede : Pokemon
	{
		public override string Name => "Venipede";
		public override int Generation => 5;
		public override string PokedexEntry => "It discovers what is going on around it by using the feelers on its head and tail. It is brutally aggresive.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Bug, PokemonType.Poison };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.PoisonPoint, AbilityFactory.Swarm, };
		public override Ability AvailableHiddenAbility => AbilityFactory.SpeedBoost;
		public override Stats BaseStats => new Stats() {
			HP = 30,
			Attack = 45,
			Defense = 59,
			SpecialAttack = 30,
			SpecialDefense = 39,
			Speed = 57
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.PoisonSting, MoveFactory.DefenseCurl, },
			[4] = new List<Move>() { MoveFactory.Rollout, },
			[8] = new List<Move>() { MoveFactory.Protect, },
			[12] = new List<Move>() { MoveFactory.PoisonTail, },
			[16] = new List<Move>() { MoveFactory.Screech, },
			[20] = new List<Move>() { MoveFactory.BugBite, },
			[24] = new List<Move>() { MoveFactory.Venoshock, },
			[28] = new List<Move>() { MoveFactory.TakeDown, },
			[32] = new List<Move>() { MoveFactory.Agility, },
			[36] = new List<Move>() { MoveFactory.Toxic, },
			[40] = new List<Move>() { MoveFactory.VenomDrench, },
			[44] = new List<Move>() { MoveFactory.DoubleEdge, },
		};
	}
}

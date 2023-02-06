using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Vespiquen : Pokemon
	{
		public override string Name => "Vespiquen";
		public override int Generation => 4;
		public override string PokedexEntry => "Its abdomen is a honeycomb for grubs. It raises its grubs on honey collected by Combee.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Bug, PokemonType.Flying };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Pressure, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Unnerve;
		public override Stats BaseStats => new Stats() {
			HP = 70,
			Attack = 80,
			Defense = 102,
			SpecialAttack = 80,
			SpecialDefense = 102,
			Speed = 40
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[0] = new List<Move>() { MoveFactory.Slash, },
			[1] = new List<Move>() { MoveFactory.Slash, MoveFactory.StruggleBug, MoveFactory.BugBite, MoveFactory.SweetScent, MoveFactory.Gust, MoveFactory.PoisonSting, MoveFactory.ConfuseRay, },
			[4] = new List<Move>() { MoveFactory.FuryCutter, },
			[8] = new List<Move>() { MoveFactory.AromaticMist, },
			[12] = new List<Move>() { MoveFactory.FellStinger, },
			[16] = new List<Move>() { MoveFactory.FurySwipes, },
			[20] = new List<Move>() { MoveFactory.Swagger, },
			[24] = new List<Move>() { MoveFactory.Aromatherapy, },
			[28] = new List<Move>() { MoveFactory.AirSlash, },
			[32] = new List<Move>() { MoveFactory.PowerGem, },
			[36] = new List<Move>() { MoveFactory.Toxic, },
			[40] = new List<Move>() { MoveFactory.AttackOrder, MoveFactory.DefendOrder, },
			[44] = new List<Move>() { MoveFactory.DestinyBond, },
		};
	}
}

using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Mudkip : Pokemon
	{
		public override string Name => "Mudkip";
		public override int Generation => 3;
		public override string PokedexEntry => "On land, it can powerfully lift large boulders by planting its four feet and heaving. It sleeps by burying itself in soil at the water's edge.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Water };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Torrent, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Damp;
		public override Stats BaseStats => new Stats() {
			HP = 50,
			Attack = 70,
			Defense = 50,
			SpecialAttack = 50,
			SpecialDefense = 50,
			Speed = 40
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Tackle, MoveFactory.Growl, },
			[3] = new List<Move>() { MoveFactory.WaterGun, },
			[6] = new List<Move>() { MoveFactory.RockSmash, },
			[9] = new List<Move>() { MoveFactory.RockThrow, },
			[12] = new List<Move>() { MoveFactory.Protect, },
			[15] = new List<Move>() { MoveFactory.Supersonic, },
			[18] = new List<Move>() { MoveFactory.WaterPulse, },
			[21] = new List<Move>() { MoveFactory.RockSlide, },
			[24] = new List<Move>() { MoveFactory.TakeDown, },
			[27] = new List<Move>() { MoveFactory.Amnesia, },
			[30] = new List<Move>() { MoveFactory.Surf, },
			[33] = new List<Move>() { MoveFactory.Screech, },
			[36] = new List<Move>() { MoveFactory.Endeavor, },
			[39] = new List<Move>() { MoveFactory.HydroPump, },
		};
	}
}

using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Goomy : Pokemon
	{
		public override string Name => "Goomy";
		public override int Generation => 6;
		public override string PokedexEntry => "Its source of protection is its slimy, germ-laden mucous membrane. Anyone who touches it needs some thorough hand-washing.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Dragon };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.SapSipper, AbilityFactory.Hydration, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Gooey;
		public override Stats BaseStats => new Stats() {
			HP = 45,
			Attack = 50,
			Defense = 35,
			SpecialAttack = 55,
			SpecialDefense = 75,
			Speed = 40
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Absorb, MoveFactory.Tackle, },
			[5] = new List<Move>() { MoveFactory.WaterGun, },
			[10] = new List<Move>() { MoveFactory.DragonBreath, },
			[15] = new List<Move>() { MoveFactory.Protect, },
			[20] = new List<Move>() { MoveFactory.Flail, },
			[25] = new List<Move>() { MoveFactory.WaterPulse, },
			[30] = new List<Move>() { MoveFactory.RainDance, },
			[35] = new List<Move>() { MoveFactory.DragonPulse, },
			[41] = new List<Move>() { MoveFactory.Curse, },
			[45] = new List<Move>() { MoveFactory.BodySlam, },
			[50] = new List<Move>() { MoveFactory.MuddyWater, },
		};
	}
}

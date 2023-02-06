using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Glalie : Pokemon
	{
		public override string Name => "Glalie";
		public override int Generation => 3;
		public override string PokedexEntry => "A Glalie has the power to instantaneously freeze moisture in the atmosphere. A dazzling cloud of diamondlike ice crystals forms around its body.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Ice };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.InnerFocus, AbilityFactory.IceBody, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Moody;
		public override Stats BaseStats => new Stats() {
			HP = 80,
			Attack = 80,
			Defense = 80,
			SpecialAttack = 80,
			SpecialDefense = 80,
			Speed = 80
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[0] = new List<Move>() { MoveFactory.FreezeDry, },
			[1] = new List<Move>() { MoveFactory.FreezeDry, MoveFactory.SheerCold, MoveFactory.PowderSnow, MoveFactory.Astonish, MoveFactory.Leer, MoveFactory.DoubleTeam, },
			[15] = new List<Move>() { MoveFactory.IceShard, },
			[20] = new List<Move>() { MoveFactory.Protect, },
			[25] = new List<Move>() { MoveFactory.IcyWind, },
			[30] = new List<Move>() { MoveFactory.FrostBreath, },
			[35] = new List<Move>() { MoveFactory.Bite, },
			[40] = new List<Move>() { MoveFactory.IceFang, },
			[47] = new List<Move>() { MoveFactory.Hail, },
			[54] = new List<Move>() { MoveFactory.Headbutt, },
			[61] = new List<Move>() { MoveFactory.Crunch, },
			[68] = new List<Move>() { MoveFactory.Blizzard, },
		};
	}
}

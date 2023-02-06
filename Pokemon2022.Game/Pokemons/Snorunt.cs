using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Snorunt : Pokemon
	{
		public override string Name => "Snorunt";
		public override int Generation => 3;
		public override string PokedexEntry => "They tend to move about in groups of around five Snorunt. In snowy regions, it is said that when they are seen late at night, snowfall will arrive by morning.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Ice };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.InnerFocus, AbilityFactory.IceBody, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Moody;
		public override Stats BaseStats => new Stats() {
			HP = 50,
			Attack = 50,
			Defense = 50,
			SpecialAttack = 50,
			SpecialDefense = 50,
			Speed = 50
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.PowderSnow, MoveFactory.Astonish, },
			[5] = new List<Move>() { MoveFactory.Leer, },
			[10] = new List<Move>() { MoveFactory.DoubleTeam, },
			[15] = new List<Move>() { MoveFactory.IceShard, },
			[20] = new List<Move>() { MoveFactory.Protect, },
			[25] = new List<Move>() { MoveFactory.IcyWind, },
			[30] = new List<Move>() { MoveFactory.FrostBreath, },
			[35] = new List<Move>() { MoveFactory.Bite, },
			[40] = new List<Move>() { MoveFactory.IceFang, },
			[45] = new List<Move>() { MoveFactory.Hail, },
			[50] = new List<Move>() { MoveFactory.Headbutt, },
			[55] = new List<Move>() { MoveFactory.Crunch, },
			[60] = new List<Move>() { MoveFactory.Blizzard, },
		};
	}
}

using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Sizzlipede : Pokemon
	{
		public override string Name => "Sizzlipede";
		public override int Generation => 8;
		public override string PokedexEntry => "It stores flammable gas in its body and uses it to generate heat. The yellow sections on its belly get particularly hot.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Fire, PokemonType.Bug };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.FlashFire, AbilityFactory.WhiteSmoke, };
		public override Ability AvailableHiddenAbility => AbilityFactory.FlameBody;
		public override Stats BaseStats => new Stats() {
			HP = 50,
			Attack = 65,
			Defense = 45,
			SpecialAttack = 50,
			SpecialDefense = 50,
			Speed = 45
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Ember, MoveFactory.Smokescreen, },
			[5] = new List<Move>() { MoveFactory.Wrap, },
			[10] = new List<Move>() { MoveFactory.Bite, },
			[15] = new List<Move>() { MoveFactory.FlameWheel, },
			[20] = new List<Move>() { MoveFactory.BugBite, },
			[25] = new List<Move>() { MoveFactory.Coil, },
			[30] = new List<Move>() { MoveFactory.Slam, },
			[35] = new List<Move>() { MoveFactory.FireSpin, },
			[40] = new List<Move>() { MoveFactory.Crunch, },
			[45] = new List<Move>() { MoveFactory.FireLash, },
			[50] = new List<Move>() { MoveFactory.Lunge, },
			[55] = new List<Move>() { MoveFactory.BurnUp, },
		};
	}
}

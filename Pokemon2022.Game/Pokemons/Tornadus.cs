using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Tornadus : Pokemon
	{
		public override string Name => "Tornadus";
		public override int Generation => 5;
		public override string PokedexEntry => "Tornadus expels massive energy from its tail, causing severe storms. Its power is great enough to blow houses away.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Flying };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Prankster, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Defiant;
		public override Stats BaseStats => new Stats() {
			HP = 79,
			Attack = 115,
			Defense = 70,
			SpecialAttack = 125,
			SpecialDefense = 80,
			Speed = 111
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Astonish, MoveFactory.Gust, },
			[5] = new List<Move>() { MoveFactory.Leer, },
			[10] = new List<Move>() { MoveFactory.Swagger, },
			[15] = new List<Move>() { MoveFactory.Bite, },
			[20] = new List<Move>() { MoveFactory.AirCutter, },
			[25] = new List<Move>() { MoveFactory.Agility, },
			[30] = new List<Move>() { MoveFactory.Tailwind, },
			[35] = new List<Move>() { MoveFactory.AirSlash, },
			[40] = new List<Move>() { MoveFactory.Crunch, },
			[45] = new List<Move>() { MoveFactory.Extrasensory, },
			[50] = new List<Move>() { MoveFactory.Uproar, },
			[55] = new List<Move>() { MoveFactory.HammerArm, },
			[60] = new List<Move>() { MoveFactory.RainDance, },
			[65] = new List<Move>() { MoveFactory.Hurricane, },
			[70] = new List<Move>() { MoveFactory.Thrash, },
		};
	}
}

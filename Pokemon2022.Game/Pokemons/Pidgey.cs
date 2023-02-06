using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Pidgey : Pokemon
	{
		public override string Name => "Pidgey";
		public override int Generation => 1;
		public override string PokedexEntry => "It has an extremely sharp sense of direction. It can unerringly return home to its nest, however far it may be removed from its familiar surroundings.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Normal, PokemonType.Flying };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.KeenEye, AbilityFactory.TangledFeet, };
		public override Ability AvailableHiddenAbility => AbilityFactory.BigPecks;
		public override Stats BaseStats => new Stats() {
			HP = 40,
			Attack = 45,
			Defense = 40,
			SpecialAttack = 35,
			SpecialDefense = 35,
			Speed = 56
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Tackle, },
			[5] = new List<Move>() { MoveFactory.SandAttack, },
			[9] = new List<Move>() { MoveFactory.Gust, },
			[13] = new List<Move>() { MoveFactory.QuickAttack, },
			[17] = new List<Move>() { MoveFactory.Whirlwind, },
			[21] = new List<Move>() { MoveFactory.Twister, },
			[25] = new List<Move>() { MoveFactory.FeatherDance, },
			[29] = new List<Move>() { MoveFactory.Agility, },
			[33] = new List<Move>() { MoveFactory.WingAttack, },
			[37] = new List<Move>() { MoveFactory.Roost, },
			[41] = new List<Move>() { MoveFactory.Tailwind, },
			[45] = new List<Move>() { MoveFactory.AerialAce, },
			[49] = new List<Move>() { MoveFactory.AirSlash, },
			[53] = new List<Move>() { MoveFactory.Hurricane, },
		};
	}
}

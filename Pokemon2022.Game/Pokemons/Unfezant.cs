using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Unfezant : Pokemon
	{
		public override string Name => "Unfezant";
		public override int Generation => 5;
		public override string PokedexEntry => "Males have plumage on their heads. They will never let themselves feel close to anyone other than their Trainers.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Normal, PokemonType.Flying };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.BigPecks, AbilityFactory.SuperLuck, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Rivalry;
		public override Stats BaseStats => new Stats() {
			HP = 80,
			Attack = 115,
			Defense = 80,
			SpecialAttack = 65,
			SpecialDefense = 55,
			Speed = 93
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Gust, MoveFactory.Growl, MoveFactory.Leer, MoveFactory.QuickAttack, },
			[12] = new List<Move>() { MoveFactory.Taunt, },
			[16] = new List<Move>() { MoveFactory.AirCutter, },
			[20] = new List<Move>() { MoveFactory.Swagger, },
			[26] = new List<Move>() { MoveFactory.FeatherDance, },
			[36] = new List<Move>() { MoveFactory.Detect, },
			[42] = new List<Move>() { MoveFactory.AirSlash, },
			[50] = new List<Move>() { MoveFactory.Roost, },
			[58] = new List<Move>() { MoveFactory.Tailwind, },
			[66] = new List<Move>() { MoveFactory.SkyAttack, },
		};
	}
}

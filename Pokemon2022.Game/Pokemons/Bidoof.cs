using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Bidoof : Pokemon
	{
		public override string Name => "Bidoof";
		public override int Generation => 4;
		public override string PokedexEntry => "With nerves of steel, nothing can perturb it. It is more agile and active than it appears.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Normal };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Simple, AbilityFactory.Unaware, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Moody;
		public override Stats BaseStats => new Stats() {
			HP = 59,
			Attack = 45,
			Defense = 40,
			SpecialAttack = 35,
			SpecialDefense = 40,
			Speed = 31
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Tackle, MoveFactory.Growl, },
			[5] = new List<Move>() { MoveFactory.DefenseCurl, },
			[9] = new List<Move>() { MoveFactory.Rollout, },
			[13] = new List<Move>() { MoveFactory.Headbutt, },
			[17] = new List<Move>() { MoveFactory.Taunt, },
			[21] = new List<Move>() { MoveFactory.Yawn, },
			[25] = new List<Move>() { MoveFactory.Crunch, },
			[29] = new List<Move>() { MoveFactory.TakeDown, },
			[33] = new List<Move>() { MoveFactory.SuperFang, },
			[37] = new List<Move>() { MoveFactory.SwordsDance, },
			[41] = new List<Move>() { MoveFactory.Amnesia, },
			[45] = new List<Move>() { MoveFactory.Superpower, },
			[49] = new List<Move>() { MoveFactory.Curse, },
		};
	}
}

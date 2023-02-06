using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Skwovet : Pokemon
	{
		public override string Name => "Skwovet";
		public override int Generation => 8;
		public override string PokedexEntry => "It eats berries nonstop—a habit that has made it more resilient than it looks. It'll show up on farms, searching for yet more berries.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Normal };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.CheekPouch, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Gluttony;
		public override Stats BaseStats => new Stats() {
			HP = 70,
			Attack = 55,
			Defense = 55,
			SpecialAttack = 35,
			SpecialDefense = 35,
			Speed = 25
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Tackle, MoveFactory.TailWhip, },
			[5] = new List<Move>() { MoveFactory.Bite, },
			[10] = new List<Move>() { MoveFactory.StuffCheeks, },
			[15] = new List<Move>() { MoveFactory.Stockpile, MoveFactory.Swallow, MoveFactory.SpitUp, },
			[20] = new List<Move>() { MoveFactory.BodySlam, },
			[25] = new List<Move>() { MoveFactory.Rest, },
			[30] = new List<Move>() { MoveFactory.Counter, },
			[35] = new List<Move>() { MoveFactory.BulletSeed, },
			[40] = new List<Move>() { MoveFactory.SuperFang, },
			[45] = new List<Move>() { MoveFactory.Belch, },
		};
	}
}

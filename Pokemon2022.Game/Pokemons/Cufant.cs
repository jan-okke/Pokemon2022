using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Cufant : Pokemon
	{
		public override string Name => "Cufant";
		public override int Generation => 8;
		public override string PokedexEntry => "It digs up the ground with its trunk. It's also very strong, being able to carry loads of over five tons without any problem at all.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Steel };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.SheerForce, };
		public override Ability AvailableHiddenAbility => AbilityFactory.HeavyMetal;
		public override Stats BaseStats => new Stats() {
			HP = 72,
			Attack = 80,
			Defense = 49,
			SpecialAttack = 40,
			SpecialDefense = 49,
			Speed = 40
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Tackle, MoveFactory.Growl, },
			[5] = new List<Move>() { MoveFactory.Rollout, },
			[10] = new List<Move>() { MoveFactory.RockSmash, },
			[15] = new List<Move>() { MoveFactory.Bulldoze, },
			[20] = new List<Move>() { MoveFactory.Stomp, },
			[25] = new List<Move>() { MoveFactory.IronDefense, },
			[30] = new List<Move>() { MoveFactory.Dig, },
			[35] = new List<Move>() { MoveFactory.Strength, },
			[40] = new List<Move>() { MoveFactory.IronHead, },
			[45] = new List<Move>() { MoveFactory.PlayRough, },
			[50] = new List<Move>() { MoveFactory.HighHorsepower, },
			[55] = new List<Move>() { MoveFactory.Superpower, },
		};
	}
}

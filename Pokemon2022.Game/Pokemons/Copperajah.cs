using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Copperajah : Pokemon
	{
		public override string Name => "Copperajah";
		public override int Generation => 8;
		public override string PokedexEntry => "These Pokémon live in herds. Their trunks have incredible grip strength, strong enough to crush giant rocks into powder.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Steel };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.SheerForce, };
		public override Ability AvailableHiddenAbility => AbilityFactory.HeavyMetal;
		public override Stats BaseStats => new Stats() {
			HP = 122,
			Attack = 130,
			Defense = 69,
			SpecialAttack = 80,
			SpecialDefense = 69,
			Speed = 30
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[0] = new List<Move>() { MoveFactory.HeavySlam, },
			[1] = new List<Move>() { MoveFactory.HeavySlam, MoveFactory.Tackle, MoveFactory.Growl, MoveFactory.Rollout, MoveFactory.RockSmash, },
			[15] = new List<Move>() { MoveFactory.Bulldoze, },
			[20] = new List<Move>() { MoveFactory.Stomp, },
			[25] = new List<Move>() { MoveFactory.IronDefense, },
			[30] = new List<Move>() { MoveFactory.Dig, },
			[37] = new List<Move>() { MoveFactory.Strength, },
			[44] = new List<Move>() { MoveFactory.IronHead, },
			[51] = new List<Move>() { MoveFactory.PlayRough, },
			[58] = new List<Move>() { MoveFactory.HighHorsepower, },
			[65] = new List<Move>() { MoveFactory.Superpower, },
		};
	}
}

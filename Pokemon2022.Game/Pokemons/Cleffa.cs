using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Cleffa : Pokemon
	{
		public override string Name => "Cleffa";
		public override int Generation => 2;
		public override string PokedexEntry => "On nights with many shooting stars, Cleffa can be seen dancing in a ring. They dance until daybreak, when they quench their thirst with the morning dew.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Fairy };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.CuteCharm, AbilityFactory.MagicGuard, };
		public override Ability AvailableHiddenAbility => AbilityFactory.FriendGuard;
		public override Stats BaseStats => new Stats() {
			HP = 50,
			Attack = 25,
			Defense = 28,
			SpecialAttack = 45,
			SpecialDefense = 55,
			Speed = 15
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Splash, MoveFactory.Pound, MoveFactory.Copycat, },
			[4] = new List<Move>() { MoveFactory.Sing, },
			[8] = new List<Move>() { MoveFactory.SweetKiss, },
			[12] = new List<Move>() { MoveFactory.DisarmingVoice, },
			[16] = new List<Move>() { MoveFactory.Encore, },
			[20] = new List<Move>() { MoveFactory.Charm, },
		};
	}
}

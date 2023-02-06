using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Igglybuff : Pokemon
	{
		public override string Name => "Igglybuff";
		public override int Generation => 2;
		public override string PokedexEntry => "Its soft and pliable body is very bouncy. When it sings continuously with all its might, its body steadily turns a deepening pink color.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Normal, PokemonType.Fairy };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.CuteCharm, AbilityFactory.Competitive, };
		public override Ability AvailableHiddenAbility => AbilityFactory.FriendGuard;
		public override Stats BaseStats => new Stats() {
			HP = 90,
			Attack = 30,
			Defense = 15,
			SpecialAttack = 40,
			SpecialDefense = 20,
			Speed = 15
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Sing, MoveFactory.Pound, MoveFactory.Copycat, },
			[4] = new List<Move>() { MoveFactory.DefenseCurl, },
			[8] = new List<Move>() { MoveFactory.SweetKiss, },
			[12] = new List<Move>() { MoveFactory.DisarmingVoice, },
			[16] = new List<Move>() { MoveFactory.Disable, },
			[20] = new List<Move>() { MoveFactory.Charm, },
		};
	}
}

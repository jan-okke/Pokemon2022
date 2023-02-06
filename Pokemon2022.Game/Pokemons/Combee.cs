using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Combee : Pokemon
	{
		public override string Name => "Combee";
		public override int Generation => 4;
		public override string PokedexEntry => "A Pokémon formed by three others. It busily carries sweet floral honey to Vespiquen.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Bug, PokemonType.Flying };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.HoneyGather, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Hustle;
		public override Stats BaseStats => new Stats() {
			HP = 30,
			Attack = 30,
			Defense = 42,
			SpecialAttack = 30,
			SpecialDefense = 42,
			Speed = 70
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.SweetScent, MoveFactory.Gust, MoveFactory.StruggleBug, MoveFactory.BugBite, },
		};
	}
}

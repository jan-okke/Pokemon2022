using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Simipour : Pokemon
	{
		public override string Name => "Simipour";
		public override int Generation => 5;
		public override string PokedexEntry => "The high-pressure water expelled from its tail is so powerful, it can destroy a concrete wall.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Water };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Gluttony, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Torrent;
		public override Stats BaseStats => new Stats() {
			HP = 75,
			Attack = 98,
			Defense = 63,
			SpecialAttack = 98,
			SpecialDefense = 63,
			Speed = 101
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Leer, MoveFactory.Lick, MoveFactory.FurySwipes, MoveFactory.Scald, },
		};
	}
}

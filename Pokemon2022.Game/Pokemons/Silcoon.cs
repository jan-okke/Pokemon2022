using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Silcoon : Pokemon
	{
		public override string Name => "Silcoon";
		public override int Generation => 3;
		public override string PokedexEntry => "It prepares for evolution using the energy it stored while it was a Wurmple. It keeps watch over the surroundings with its two eyes.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Bug };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.ShedSkin, };
		public override Stats BaseStats => new Stats() {
			HP = 50,
			Attack = 35,
			Defense = 55,
			SpecialAttack = 25,
			SpecialDefense = 25,
			Speed = 15
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[0] = new List<Move>() { MoveFactory.Harden, },
			[1] = new List<Move>() { MoveFactory.Harden, },
		};
	}
}

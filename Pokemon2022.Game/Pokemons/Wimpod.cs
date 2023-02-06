using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Wimpod : Pokemon
	{
		public override string Name => "Wimpod";
		public override int Generation => 7;
		public override string PokedexEntry => "This Pokémon is a coward. As it desperately dashes off, the flailing of its many legs leaves a sparkling clean path in its wake.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Bug, PokemonType.Water };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.WimpOut, };
		public override Stats BaseStats => new Stats() {
			HP = 25,
			Attack = 35,
			Defense = 40,
			SpecialAttack = 20,
			SpecialDefense = 30,
			Speed = 80
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.StruggleBug, MoveFactory.SandAttack, MoveFactory.DefenseCurl, },
		};
	}
}

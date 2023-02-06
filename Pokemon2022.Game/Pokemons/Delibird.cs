using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Delibird : Pokemon
	{
		public override string Name => "Delibird";
		public override int Generation => 2;
		public override string PokedexEntry => "It carries food bundled up in its tail. There was a famous explorer who managed to scale Mt. Everest thanks to a Delibird sharing its food.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Ice, PokemonType.Flying };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.VitalSpirit, AbilityFactory.Hustle, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Insomnia;
		public override Stats BaseStats => new Stats() {
			HP = 45,
			Attack = 55,
			Defense = 45,
			SpecialAttack = 65,
			SpecialDefense = 45,
			Speed = 75
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Present, },
			[25] = new List<Move>() { MoveFactory.DrillPeck, },
		};
	}
}

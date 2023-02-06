using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Toxel : Pokemon
	{
		public override string Name => "Toxel";
		public override int Generation => 8;
		public override string PokedexEntry => "It manipulates the chemical makeup of its poison to produce electricity. The voltage is weak, but it can cause a tingling paralysis.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Electric, PokemonType.Poison };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Rattled, AbilityFactory.Static, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Klutz;
		public override Stats BaseStats => new Stats() {
			HP = 40,
			Attack = 38,
			Defense = 35,
			SpecialAttack = 54,
			SpecialDefense = 35,
			Speed = 40
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Belch, MoveFactory.TearfulLook, MoveFactory.Nuzzle, MoveFactory.Growl, MoveFactory.Flail, MoveFactory.Acid, },
		};
	}
}

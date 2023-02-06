using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Dreepy : Pokemon
	{
		public override string Name => "Dreepy";
		public override int Generation => 8;
		public override string PokedexEntry => "After being reborn as a ghost Pokémon, Dreepy wanders the areas it used to inhabit back when it was alive in prehistoric seas.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Dragon, PokemonType.Ghost };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.ClearBody, AbilityFactory.Infiltrator, };
		public override Ability AvailableHiddenAbility => AbilityFactory.CursedBody;
		public override Stats BaseStats => new Stats() {
			HP = 28,
			Attack = 60,
			Defense = 30,
			SpecialAttack = 40,
			SpecialDefense = 30,
			Speed = 82
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Astonish, MoveFactory.Infestation, MoveFactory.QuickAttack, MoveFactory.Bite, },
		};
	}
}

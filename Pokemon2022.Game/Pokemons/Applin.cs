using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Applin : Pokemon
	{
		public override string Name => "Applin";
		public override int Generation => 8;
		public override string PokedexEntry => "It spends its entire life inside an apple. It hides from its natural enemies, bird Pokémon, by pretending it's just an apple and nothing more.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Grass, PokemonType.Dragon };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Ripen, AbilityFactory.Gluttony, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Bulletproof;
		public override Stats BaseStats => new Stats() {
			HP = 40,
			Attack = 40,
			Defense = 80,
			SpecialAttack = 40,
			SpecialDefense = 40,
			Speed = 20
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Withdraw, MoveFactory.Astonish, },
		};
	}
}

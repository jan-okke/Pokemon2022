using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Beldum : Pokemon
	{
		public override string Name => "Beldum";
		public override int Generation => 3;
		public override string PokedexEntry => "When Beldum gather in a swarm, they move in perfect unison as if they were but one Pokémon. They communicate with each other using brain waves.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Steel, PokemonType.Psychic };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.ClearBody, };
		public override Ability AvailableHiddenAbility => AbilityFactory.LightMetal;
		public override Stats BaseStats => new Stats() {
			HP = 40,
			Attack = 55,
			Defense = 80,
			SpecialAttack = 35,
			SpecialDefense = 60,
			Speed = 30
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Tackle, },
		};
	}
}

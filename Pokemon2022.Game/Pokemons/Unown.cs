using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Unown : Pokemon
	{
		public override string Name => "Unown";
		public override int Generation => 2;
		public override string PokedexEntry => "This Pokémon is shaped like ancient text characters. Although research is ongoing, it is a mystery as to which came first, the ancient writings or the various Unown.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Psychic };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Levitate, };
		public override Stats BaseStats => new Stats() {
			HP = 48,
			Attack = 72,
			Defense = 48,
			SpecialAttack = 72,
			SpecialDefense = 48,
			Speed = 48
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.HiddenPower, },
		};
	}
}

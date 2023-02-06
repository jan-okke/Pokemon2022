using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Abra : Pokemon
	{
		public override string Name => "Abra";
		public override int Generation => 1;
		public override string PokedexEntry => "A Pokémon that sleeps 18 hours a day. Observation revealed that it uses Teleport to change its location once every hour.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Psychic };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Synchronize, AbilityFactory.InnerFocus, };
		public override Ability AvailableHiddenAbility => AbilityFactory.MagicGuard;
		public override Stats BaseStats => new Stats() {
			HP = 25,
			Attack = 20,
			Defense = 15,
			SpecialAttack = 105,
			SpecialDefense = 55,
			Speed = 90
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Teleport, },
		};
	}
}

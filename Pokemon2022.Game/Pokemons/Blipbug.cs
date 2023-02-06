using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Blipbug : Pokemon
	{
		public override string Name => "Blipbug";
		public override int Generation => 8;
		public override string PokedexEntry => "Often found in gardens, this Pokémon has hairs on its body that it uses to assess its surroundings.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Bug };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Swarm, AbilityFactory.CompoundEyes, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Telepathy;
		public override Stats BaseStats => new Stats() {
			HP = 25,
			Attack = 20,
			Defense = 20,
			SpecialAttack = 25,
			SpecialDefense = 45,
			Speed = 45
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.StruggleBug, },
		};
	}
}

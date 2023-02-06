using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Dottler : Pokemon
	{
		public override string Name => "Dottler";
		public override int Generation => 8;
		public override string PokedexEntry => "It barely moves, but it's still alive. Hiding in its shell without food or water seems to have awakened its psychic powers.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Bug, PokemonType.Psychic };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Swarm, AbilityFactory.CompoundEyes, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Telepathy;
		public override Stats BaseStats => new Stats() {
			HP = 50,
			Attack = 35,
			Defense = 80,
			SpecialAttack = 50,
			SpecialDefense = 90,
			Speed = 30
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[0] = new List<Move>() { MoveFactory.Reflect, MoveFactory.LightScreen, MoveFactory.Confusion, },
			[1] = new List<Move>() { MoveFactory.Reflect, MoveFactory.LightScreen, MoveFactory.Confusion, MoveFactory.StruggleBug, },
		};
	}
}

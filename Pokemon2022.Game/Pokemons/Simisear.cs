using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Simisear : Pokemon
	{
		public override string Name => "Simisear";
		public override int Generation => 5;
		public override string PokedexEntry => "A flame burns inside its body. It scatters embers from its head and tail to sear its opponents.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Fire };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Gluttony, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Blaze;
		public override Stats BaseStats => new Stats() {
			HP = 75,
			Attack = 98,
			Defense = 63,
			SpecialAttack = 98,
			SpecialDefense = 63,
			Speed = 101
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Leer, MoveFactory.Lick, MoveFactory.FurySwipes, MoveFactory.FlameBurst, },
		};
	}
}

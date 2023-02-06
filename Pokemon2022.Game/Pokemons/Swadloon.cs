using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Swadloon : Pokemon
	{
		public override string Name => "Swadloon";
		public override int Generation => 5;
		public override string PokedexEntry => "It protects itself from the cold by wrapping up in leaves. It stays on the move, eating leaves in forests.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Bug, PokemonType.Grass };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.LeafGuard, AbilityFactory.Chlorophyll, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Overcoat;
		public override Stats BaseStats => new Stats() {
			HP = 55,
			Attack = 63,
			Defense = 90,
			SpecialAttack = 50,
			SpecialDefense = 80,
			Speed = 42
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[0] = new List<Move>() { MoveFactory.Protect, },
			[1] = new List<Move>() { MoveFactory.Protect, MoveFactory.GrassWhistle, MoveFactory.Tackle, MoveFactory.StringShot, MoveFactory.BugBite, MoveFactory.RazorLeaf, },
		};
	}
}

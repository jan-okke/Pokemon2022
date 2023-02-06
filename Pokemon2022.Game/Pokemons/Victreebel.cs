using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Victreebel : Pokemon
	{
		public override string Name => "Victreebel";
		public override int Generation => 1;
		public override string PokedexEntry => "The long vine extending from its head is waved about as if it were a living thing to attract prey. When an unsuspecting victim approaches, it is swallowed whole.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Grass, PokemonType.Poison };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Chlorophyll, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Gluttony;
		public override Stats BaseStats => new Stats() {
			HP = 80,
			Attack = 105,
			Defense = 65,
			SpecialAttack = 100,
			SpecialDefense = 70,
			Speed = 70
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[0] = new List<Move>() { MoveFactory.LeafTornado, },
			[1] = new List<Move>() { MoveFactory.LeafTornado, MoveFactory.Stockpile, MoveFactory.Swallow, MoveFactory.SpitUp, MoveFactory.VineWhip, MoveFactory.SleepPowder, MoveFactory.SweetScent, MoveFactory.RazorLeaf, },
			[32] = new List<Move>() { MoveFactory.LeafStorm, },
			[44] = new List<Move>() { MoveFactory.LeafBlade, },
		};
	}
}

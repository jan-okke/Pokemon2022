using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Wormadam : Pokemon
	{
		public override string Name => "Wormadam";
		public override int Generation => 4;
		public override string PokedexEntry => "When Burmy evolved, its cloak became a part of this Pokémon's body. The cloak is never shed.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Bug, PokemonType.Grass };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Anticipation, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Overcoat;
		public override Stats BaseStats => new Stats() {
			HP = 60,
			Attack = 59,
			Defense = 85,
			SpecialAttack = 79,
			SpecialDefense = 105,
			Speed = 36
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[0] = new List<Move>() { MoveFactory.QuiverDance, },
			[1] = new List<Move>() { MoveFactory.QuiverDance, MoveFactory.SuckerPunch, MoveFactory.Tackle, MoveFactory.Protect, MoveFactory.BugBite, },
			[10] = new List<Move>() { MoveFactory.Protect, },
			[15] = new List<Move>() { MoveFactory.BugBite, },
			[20] = new List<Move>() { MoveFactory.StringShot, },
			[23] = new List<Move>() { MoveFactory.Confusion, },
			[26] = new List<Move>() { MoveFactory.RazorLeaf, },
			[29] = new List<Move>() { MoveFactory.Growth, },
			[32] = new List<Move>() { MoveFactory.Psybeam, },
			[35] = new List<Move>() { MoveFactory.Infestation, },
			[38] = new List<Move>() { MoveFactory.Flail, },
			[41] = new List<Move>() { MoveFactory.Attract, },
			[44] = new List<Move>() { MoveFactory.Psychic, },
			[47] = new List<Move>() { MoveFactory.LeafStorm, },
			[50] = new List<Move>() { MoveFactory.BugBuzz, },
		};
	}
}

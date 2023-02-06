using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Sewaddle : Pokemon
	{
		public override string Name => "Sewaddle";
		public override int Generation => 5;
		public override string PokedexEntry => "This Pokémon makes clothes for itself. It chews up leaves and sews them with sticky thread extruded from its mouth.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Bug, PokemonType.Grass };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Swarm, AbilityFactory.Chlorophyll, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Overcoat;
		public override Stats BaseStats => new Stats() {
			HP = 45,
			Attack = 53,
			Defense = 70,
			SpecialAttack = 40,
			SpecialDefense = 60,
			Speed = 42
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Tackle, MoveFactory.StringShot, },
			[8] = new List<Move>() { MoveFactory.BugBite, },
			[15] = new List<Move>() { MoveFactory.RazorLeaf, },
			[22] = new List<Move>() { MoveFactory.StruggleBug, },
			[29] = new List<Move>() { MoveFactory.Endure, },
			[31] = new List<Move>() { MoveFactory.StickyWeb, },
			[36] = new List<Move>() { MoveFactory.BugBuzz, },
			[43] = new List<Move>() { MoveFactory.Flail, },
		};
	}
}

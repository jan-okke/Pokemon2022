using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Smeargle : Pokemon
	{
		public override string Name => "Smeargle";
		public override int Generation => 2;
		public override string PokedexEntry => "A Smeargle marks its territory using a fluid that leaks out from the tip of its tail. About 5,000 different marks left by this Pokémon have been found.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Normal };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.OwnTempo, AbilityFactory.Technician, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Moody;
		public override Stats BaseStats => new Stats() {
			HP = 55,
			Attack = 20,
			Defense = 35,
			SpecialAttack = 20,
			SpecialDefense = 45,
			Speed = 75
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Sketch, },
			[11] = new List<Move>() { MoveFactory.Sketch, },
			[21] = new List<Move>() { MoveFactory.Sketch, },
			[31] = new List<Move>() { MoveFactory.Sketch, },
			[41] = new List<Move>() { MoveFactory.Sketch, },
			[51] = new List<Move>() { MoveFactory.Sketch, },
			[61] = new List<Move>() { MoveFactory.Sketch, },
			[71] = new List<Move>() { MoveFactory.Sketch, },
			[81] = new List<Move>() { MoveFactory.Sketch, },
			[91] = new List<Move>() { MoveFactory.Sketch, },
		};
	}
}

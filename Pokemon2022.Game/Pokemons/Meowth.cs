using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Meowth : Pokemon
	{
		public override string Name => "Meowth";
		public override int Generation => 1;
		public override string PokedexEntry => "Meowth withdraw their sharp claws into their paws to silently sneak about. For some reason, this Pokémon loves shiny coins that glitter with light.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Normal };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Pickup, AbilityFactory.Technician, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Unnerve;
		public override Stats BaseStats => new Stats() {
			HP = 40,
			Attack = 45,
			Defense = 35,
			SpecialAttack = 40,
			SpecialDefense = 40,
			Speed = 90
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.FakeOut, MoveFactory.Growl, },
			[4] = new List<Move>() { MoveFactory.Feint, },
			[8] = new List<Move>() { MoveFactory.Scratch, },
			[12] = new List<Move>() { MoveFactory.PayDay, },
			[16] = new List<Move>() { MoveFactory.Bite, },
			[20] = new List<Move>() { MoveFactory.Taunt, },
			[24] = new List<Move>() { MoveFactory.Assurance, },
			[29] = new List<Move>() { MoveFactory.FurySwipes, },
			[32] = new List<Move>() { MoveFactory.Screech, },
			[36] = new List<Move>() { MoveFactory.Slash, },
			[40] = new List<Move>() { MoveFactory.NastyPlot, },
			[44] = new List<Move>() { MoveFactory.PlayRough, },
		};
	}
}

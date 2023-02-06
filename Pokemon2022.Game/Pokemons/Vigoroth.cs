using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Vigoroth : Pokemon
	{
		public override string Name => "Vigoroth";
		public override int Generation => 3;
		public override string PokedexEntry => "It can't keep still because its blood boils with energy. It runs through the fields and mountains all day to calm itself. If it doesn't, it can't sleep at night.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Normal };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.VitalSpirit, };
		public override Stats BaseStats => new Stats() {
			HP = 80,
			Attack = 80,
			Defense = 80,
			SpecialAttack = 55,
			SpecialDefense = 55,
			Speed = 90
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Reversal, MoveFactory.Scratch, MoveFactory.FocusEnergy, MoveFactory.Encore, MoveFactory.Uproar, },
			[6] = new List<Move>() { MoveFactory.Encore, },
			[9] = new List<Move>() { MoveFactory.Uproar, },
			[14] = new List<Move>() { MoveFactory.FurySwipes, },
			[17] = new List<Move>() { MoveFactory.Endure, },
			[23] = new List<Move>() { MoveFactory.Slash, },
			[27] = new List<Move>() { MoveFactory.Headbutt, },
			[33] = new List<Move>() { MoveFactory.Counter, },
			[37] = new List<Move>() { MoveFactory.FocusPunch, },
			[43] = new List<Move>() { MoveFactory.Reversal, },
		};
	}
}

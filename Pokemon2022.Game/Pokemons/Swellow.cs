using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Swellow : Pokemon
	{
		public override string Name => "Swellow";
		public override int Generation => 3;
		public override string PokedexEntry => "A Swellow dives upon prey from far above. It never misses its targets. It takes to the skies in search of lands with a warm climate.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Normal, PokemonType.Flying };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Guts, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Scrappy;
		public override Stats BaseStats => new Stats() {
			HP = 60,
			Attack = 85,
			Defense = 60,
			SpecialAttack = 75,
			SpecialDefense = 50,
			Speed = 125
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.BraveBird, MoveFactory.AirSlash, MoveFactory.Pluck, MoveFactory.Peck, MoveFactory.Growl, MoveFactory.FocusEnergy, MoveFactory.QuickAttack, },
			[5] = new List<Move>() { MoveFactory.FocusEnergy, },
			[9] = new List<Move>() { MoveFactory.QuickAttack, },
			[13] = new List<Move>() { MoveFactory.WingAttack, },
			[17] = new List<Move>() { MoveFactory.DoubleTeam, },
			[21] = new List<Move>() { MoveFactory.AerialAce, },
			[27] = new List<Move>() { MoveFactory.QuickGuard, },
			[33] = new List<Move>() { MoveFactory.Agility, },
			[39] = new List<Move>() { MoveFactory.AirSlash, },
			[45] = new List<Move>() { MoveFactory.Endeavor, },
			[51] = new List<Move>() { MoveFactory.BraveBird, },
			[57] = new List<Move>() { MoveFactory.Reversal, },
		};
	}
}

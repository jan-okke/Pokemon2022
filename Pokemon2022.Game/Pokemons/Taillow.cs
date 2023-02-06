using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Taillow : Pokemon
	{
		public override string Name => "Taillow";
		public override int Generation => 3;
		public override string PokedexEntry => "Although it is small, it is very courageous. It will take on a larger Skarmory on an equal footing. However, its will weakens if it becomes hungry.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Normal, PokemonType.Flying };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Guts, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Scrappy;
		public override Stats BaseStats => new Stats() {
			HP = 40,
			Attack = 55,
			Defense = 30,
			SpecialAttack = 30,
			SpecialDefense = 30,
			Speed = 85
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Peck, MoveFactory.Growl, },
			[5] = new List<Move>() { MoveFactory.FocusEnergy, },
			[9] = new List<Move>() { MoveFactory.QuickAttack, },
			[13] = new List<Move>() { MoveFactory.WingAttack, },
			[17] = new List<Move>() { MoveFactory.DoubleTeam, },
			[21] = new List<Move>() { MoveFactory.AerialAce, },
			[25] = new List<Move>() { MoveFactory.QuickGuard, },
			[29] = new List<Move>() { MoveFactory.Agility, },
			[33] = new List<Move>() { MoveFactory.AirSlash, },
			[37] = new List<Move>() { MoveFactory.Endeavor, },
			[41] = new List<Move>() { MoveFactory.BraveBird, },
			[45] = new List<Move>() { MoveFactory.Reversal, },
		};
	}
}

using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Kartana : Pokemon
	{
		public override string Name => "Kartana";
		public override int Generation => 7;
		public override string PokedexEntry => "One of the Ultra Beast life-forms, it was observed cutting down a gigantic steel tower with one stroke of its blade.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Grass, PokemonType.Steel };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.BeastBoost, };
		public override Stats BaseStats => new Stats() {
			HP = 59,
			Attack = 181,
			Defense = 131,
			SpecialAttack = 59,
			SpecialDefense = 31,
			Speed = 109
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.FuryCutter, MoveFactory.VacuumWave, },
			[5] = new List<Move>() { MoveFactory.RazorLeaf, },
			[10] = new List<Move>() { MoveFactory.FalseSwipe, },
			[15] = new List<Move>() { MoveFactory.Cut, },
			[20] = new List<Move>() { MoveFactory.AirCutter, },
			[25] = new List<Move>() { MoveFactory.AerialAce, },
			[30] = new List<Move>() { MoveFactory.Detect, },
			[35] = new List<Move>() { MoveFactory.NightSlash, },
			[40] = new List<Move>() { MoveFactory.Synthesis, },
			[45] = new List<Move>() { MoveFactory.LaserFocus, },
			[50] = new List<Move>() { MoveFactory.Defog, },
			[55] = new List<Move>() { MoveFactory.LeafBlade, },
			[60] = new List<Move>() { MoveFactory.SacredSword, },
			[65] = new List<Move>() { MoveFactory.SwordsDance, },
			[70] = new List<Move>() { MoveFactory.Guillotine, },
		};
	}
}

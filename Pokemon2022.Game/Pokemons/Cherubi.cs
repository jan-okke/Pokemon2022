using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Cherubi : Pokemon
	{
		public override string Name => "Cherubi";
		public override int Generation => 4;
		public override string PokedexEntry => "The small ball holds the nutrients needed for evolution. Apparently, it is very sweet and tasty.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Grass };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Chlorophyll, };
		public override Stats BaseStats => new Stats() {
			HP = 45,
			Attack = 35,
			Defense = 45,
			SpecialAttack = 62,
			SpecialDefense = 53,
			Speed = 35
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.MorningSun, MoveFactory.Tackle, },
			[5] = new List<Move>() { MoveFactory.Leafage, },
			[10] = new List<Move>() { MoveFactory.Growth, },
			[15] = new List<Move>() { MoveFactory.HelpingHand, },
			[20] = new List<Move>() { MoveFactory.MagicalLeaf, },
			[26] = new List<Move>() { MoveFactory.LeechSeed, },
			[30] = new List<Move>() { MoveFactory.TakeDown, },
			[35] = new List<Move>() { MoveFactory.PetalBlizzard, },
			[40] = new List<Move>() { MoveFactory.WorrySeed, },
			[45] = new List<Move>() { MoveFactory.SolarBeam, },
		};
	}
}

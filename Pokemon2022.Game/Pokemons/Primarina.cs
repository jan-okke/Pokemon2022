using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Primarina : Pokemon
	{
		public override string Name => "Primarina";
		public override int Generation => 7;
		public override string PokedexEntry => "It controls its water balloons with song. The melody is learned from others of its kind and is passed down from one generation to the next.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Water, PokemonType.Fairy };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Torrent, };
		public override Ability AvailableHiddenAbility => AbilityFactory.LiquidVoice;
		public override Stats BaseStats => new Stats() {
			HP = 80,
			Attack = 74,
			Defense = 74,
			SpecialAttack = 126,
			SpecialDefense = 116,
			Speed = 60
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[0] = new List<Move>() { MoveFactory.SparklingAria, },
			[1] = new List<Move>() { MoveFactory.SparklingAria, MoveFactory.Pound, MoveFactory.Growl, MoveFactory.WaterGun, MoveFactory.DisarmingVoice, },
			[9] = new List<Move>() { MoveFactory.AquaJet, },
			[12] = new List<Move>() { MoveFactory.BabyDollEyes, },
			[15] = new List<Move>() { MoveFactory.IcyWind, },
			[20] = new List<Move>() { MoveFactory.Sing, },
			[25] = new List<Move>() { MoveFactory.BubbleBeam, },
			[30] = new List<Move>() { MoveFactory.Encore, },
			[37] = new List<Move>() { MoveFactory.MistyTerrain, },
			[44] = new List<Move>() { MoveFactory.HyperVoice, },
			[51] = new List<Move>() { MoveFactory.Moonblast, },
			[58] = new List<Move>() { MoveFactory.HydroPump, },
		};
	}
}

using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Brionne : Pokemon
	{
		public override string Name => "Brionne";
		public override int Generation => 7;
		public override string PokedexEntry => "It gets excited when it sees a dance it doesn't know. This hard worker practices diligently until it can learn that dance.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Water };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Torrent, };
		public override Ability AvailableHiddenAbility => AbilityFactory.LiquidVoice;
		public override Stats BaseStats => new Stats() {
			HP = 60,
			Attack = 69,
			Defense = 69,
			SpecialAttack = 91,
			SpecialDefense = 81,
			Speed = 50
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Pound, MoveFactory.Growl, MoveFactory.WaterGun, MoveFactory.DisarmingVoice, },
			[9] = new List<Move>() { MoveFactory.AquaJet, },
			[12] = new List<Move>() { MoveFactory.BabyDollEyes, },
			[15] = new List<Move>() { MoveFactory.IcyWind, },
			[20] = new List<Move>() { MoveFactory.Sing, },
			[25] = new List<Move>() { MoveFactory.BubbleBeam, },
			[30] = new List<Move>() { MoveFactory.Encore, },
			[35] = new List<Move>() { MoveFactory.MistyTerrain, },
			[40] = new List<Move>() { MoveFactory.HyperVoice, },
			[45] = new List<Move>() { MoveFactory.Moonblast, },
			[50] = new List<Move>() { MoveFactory.HydroPump, },
		};
	}
}

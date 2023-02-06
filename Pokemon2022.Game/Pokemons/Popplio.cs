using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Popplio : Pokemon
	{
		public override string Name => "Popplio";
		public override int Generation => 7;
		public override string PokedexEntry => "This Pokémon snorts body fluids from its nose, blowing balloons to smash into its foes. It's famous for being a hard worker.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Water };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Torrent, };
		public override Ability AvailableHiddenAbility => AbilityFactory.LiquidVoice;
		public override Stats BaseStats => new Stats() {
			HP = 50,
			Attack = 54,
			Defense = 54,
			SpecialAttack = 66,
			SpecialDefense = 56,
			Speed = 40
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Pound, MoveFactory.Growl, },
			[3] = new List<Move>() { MoveFactory.WaterGun, },
			[6] = new List<Move>() { MoveFactory.DisarmingVoice, },
			[9] = new List<Move>() { MoveFactory.AquaJet, },
			[12] = new List<Move>() { MoveFactory.BabyDollEyes, },
			[15] = new List<Move>() { MoveFactory.IcyWind, },
			[18] = new List<Move>() { MoveFactory.Sing, },
			[21] = new List<Move>() { MoveFactory.BubbleBeam, },
			[24] = new List<Move>() { MoveFactory.Encore, },
			[27] = new List<Move>() { MoveFactory.MistyTerrain, },
			[30] = new List<Move>() { MoveFactory.HyperVoice, },
			[33] = new List<Move>() { MoveFactory.Moonblast, },
			[36] = new List<Move>() { MoveFactory.HydroPump, },
		};
	}
}

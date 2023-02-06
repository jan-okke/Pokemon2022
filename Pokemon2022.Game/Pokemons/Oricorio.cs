using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Oricorio : Pokemon
	{
		public override string Name => "Oricorio";
		public override int Generation => 7;
		public override string PokedexEntry => "It beats its wings together to create fire. As it moves in the steps of its beautiful dance, it bathes opponents in intense flames.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Fire, PokemonType.Flying };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Dancer, };
		public override Stats BaseStats => new Stats() {
			HP = 75,
			Attack = 70,
			Defense = 70,
			SpecialAttack = 98,
			SpecialDefense = 70,
			Speed = 93
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Pound, },
			[4] = new List<Move>() { MoveFactory.Growl, },
			[6] = new List<Move>() { MoveFactory.Peck, },
			[10] = new List<Move>() { MoveFactory.HelpingHand, },
			[13] = new List<Move>() { MoveFactory.AirCutter, },
			[16] = new List<Move>() { MoveFactory.BatonPass, },
			[20] = new List<Move>() { MoveFactory.FeatherDance, },
			[23] = new List<Move>() { MoveFactory.DoubleSlap, },
			[26] = new List<Move>() { MoveFactory.TeeterDance, },
			[30] = new List<Move>() { MoveFactory.Roost, },
			[33] = new List<Move>() { MoveFactory.Captivate, },
			[36] = new List<Move>() { MoveFactory.AirSlash, },
			[40] = new List<Move>() { MoveFactory.RevelationDance, },
			[43] = new List<Move>() { MoveFactory.MirrorMove, },
			[46] = new List<Move>() { MoveFactory.Agility, },
			[50] = new List<Move>() { MoveFactory.Hurricane, },
		};
	}
}

using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Stonjourner : Pokemon
	{
		public override string Name => "Stonjourner";
		public override int Generation => 8;
		public override string PokedexEntry => "Once a year, on a specific date and at a specific time, they gather out of nowhere and form up in a circle.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Rock };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.PowerSpot, };
		public override Stats BaseStats => new Stats() {
			HP = 100,
			Attack = 125,
			Defense = 135,
			SpecialAttack = 20,
			SpecialDefense = 20,
			Speed = 70
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.RockThrow, MoveFactory.Block, },
			[6] = new List<Move>() { MoveFactory.RockPolish, },
			[12] = new List<Move>() { MoveFactory.RockTomb, },
			[18] = new List<Move>() { MoveFactory.Gravity, },
			[24] = new List<Move>() { MoveFactory.Stomp, },
			[30] = new List<Move>() { MoveFactory.StealthRock, },
			[36] = new List<Move>() { MoveFactory.RockSlide, },
			[42] = new List<Move>() { MoveFactory.BodySlam, },
			[48] = new List<Move>() { MoveFactory.WideGuard, },
			[54] = new List<Move>() { MoveFactory.HeavySlam, },
			[60] = new List<Move>() { MoveFactory.StoneEdge, },
			[66] = new List<Move>() { MoveFactory.MegaKick, },
		};
	}
}

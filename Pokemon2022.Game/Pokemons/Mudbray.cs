using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Mudbray : Pokemon
	{
		public override string Name => "Mudbray";
		public override int Generation => 7;
		public override string PokedexEntry => "It loves playing in the mud. If it isn't showered with mud on a daily basis, it gets stressed out and stops listening to its Trainer.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Ground };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.OwnTempo, AbilityFactory.Stamina, };
		public override Ability AvailableHiddenAbility => AbilityFactory.InnerFocus;
		public override Stats BaseStats => new Stats() {
			HP = 70,
			Attack = 100,
			Defense = 70,
			SpecialAttack = 45,
			SpecialDefense = 55,
			Speed = 45
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.MudSlap, MoveFactory.RockSmash, },
			[4] = new List<Move>() { MoveFactory.IronDefense, },
			[8] = new List<Move>() { MoveFactory.DoubleKick, },
			[12] = new List<Move>() { MoveFactory.Bulldoze, },
			[16] = new List<Move>() { MoveFactory.Stomp, },
			[20] = new List<Move>() { MoveFactory.Strength, },
			[24] = new List<Move>() { MoveFactory.Counter, },
			[28] = new List<Move>() { MoveFactory.HighHorsepower, },
			[32] = new List<Move>() { MoveFactory.HeavySlam, },
			[36] = new List<Move>() { MoveFactory.Earthquake, },
			[40] = new List<Move>() { MoveFactory.MegaKick, },
			[44] = new List<Move>() { MoveFactory.Superpower, },
		};
	}
}

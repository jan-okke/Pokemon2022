using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Bonsly : Pokemon
	{
		public override string Name => "Bonsly";
		public override int Generation => 4;
		public override string PokedexEntry => "It looks as if it is always crying. It is actually adjusting its body's fluid levels by eliminating excess.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Rock };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Sturdy, AbilityFactory.RockHead, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Rattled;
		public override Stats BaseStats => new Stats() {
			HP = 50,
			Attack = 80,
			Defense = 95,
			SpecialAttack = 10,
			SpecialDefense = 45,
			Speed = 10
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.FakeTears, MoveFactory.Copycat, },
			[4] = new List<Move>() { MoveFactory.Flail, },
			[8] = new List<Move>() { MoveFactory.RockThrow, },
			[12] = new List<Move>() { MoveFactory.Block, },
			[16] = new List<Move>() { MoveFactory.Mimic, },
			[20] = new List<Move>() { MoveFactory.RockTomb, },
			[24] = new List<Move>() { MoveFactory.TearfulLook, },
			[28] = new List<Move>() { MoveFactory.SuckerPunch, },
			[32] = new List<Move>() { MoveFactory.RockSlide, },
			[36] = new List<Move>() { MoveFactory.LowKick, },
			[40] = new List<Move>() { MoveFactory.Counter, },
			[44] = new List<Move>() { MoveFactory.DoubleEdge, },
		};
	}
}

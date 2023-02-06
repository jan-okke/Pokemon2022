using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Hippopotas : Pokemon
	{
		public override string Name => "Hippopotas";
		public override int Generation => 4;
		public override string PokedexEntry => "It lives in arid places. Instead of perspiration, it expels grainy sand from its body.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Ground };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.SandStream, };
		public override Ability AvailableHiddenAbility => AbilityFactory.SandForce;
		public override Stats BaseStats => new Stats() {
			HP = 68,
			Attack = 72,
			Defense = 78,
			SpecialAttack = 38,
			SpecialDefense = 42,
			Speed = 32
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Tackle, MoveFactory.SandAttack, },
			[4] = new List<Move>() { MoveFactory.Bite, },
			[8] = new List<Move>() { MoveFactory.Yawn, },
			[12] = new List<Move>() { MoveFactory.SandTomb, },
			[16] = new List<Move>() { MoveFactory.Dig, },
			[20] = new List<Move>() { MoveFactory.Crunch, },
			[24] = new List<Move>() { MoveFactory.Sandstorm, },
			[28] = new List<Move>() { MoveFactory.TakeDown, },
			[32] = new List<Move>() { MoveFactory.Roar, },
			[36] = new List<Move>() { MoveFactory.Rest, },
			[40] = new List<Move>() { MoveFactory.Earthquake, },
			[44] = new List<Move>() { MoveFactory.DoubleEdge, },
			[48] = new List<Move>() { MoveFactory.Fissure, },
			[52] = new List<Move>() { MoveFactory.SlackOff, },
		};
	}
}

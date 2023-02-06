using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Graveler : Pokemon
	{
		public override string Name => "Graveler";
		public override int Generation => 1;
		public override string PokedexEntry => "They descend from mountains by tumbling down steep slopes. They are so brutal, they smash aside obstructing trees and huge boulders with thunderous tackles.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Rock, PokemonType.Ground };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.RockHead, AbilityFactory.Sturdy, };
		public override Ability AvailableHiddenAbility => AbilityFactory.SandVeil;
		public override Stats BaseStats => new Stats() {
			HP = 55,
			Attack = 95,
			Defense = 115,
			SpecialAttack = 45,
			SpecialDefense = 45,
			Speed = 35
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Tackle, MoveFactory.DefenseCurl, MoveFactory.RockPolish, },
			[4] = new List<Move>() { MoveFactory.Sandstorm, },
			[6] = new List<Move>() { MoveFactory.RockPolish, },
			[10] = new List<Move>() { MoveFactory.Rollout, },
			[12] = new List<Move>() { MoveFactory.Harden, },
			[16] = new List<Move>() { MoveFactory.RockThrow, },
			[18] = new List<Move>() { MoveFactory.SmackDown, },
			[22] = new List<Move>() { MoveFactory.Bulldoze, },
			[24] = new List<Move>() { MoveFactory.SelfDestruct, },
			[30] = new List<Move>() { MoveFactory.StealthRock, },
			[34] = new List<Move>() { MoveFactory.RockBlast, },
			[40] = new List<Move>() { MoveFactory.Earthquake, },
			[44] = new List<Move>() { MoveFactory.Explosion, },
			[50] = new List<Move>() { MoveFactory.DoubleEdge, },
			[54] = new List<Move>() { MoveFactory.StoneEdge, },
		};
	}
}

using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Geodude : Pokemon
	{
		public override string Name => "Geodude";
		public override int Generation => 1;
		public override string PokedexEntry => "It climbs mountain paths using only the power of its arms. Because they look just like boulders lining paths, hikers may step on them without noticing.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Rock, PokemonType.Ground };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.RockHead, AbilityFactory.Sturdy, };
		public override Ability AvailableHiddenAbility => AbilityFactory.SandVeil;
		public override Stats BaseStats => new Stats() {
			HP = 40,
			Attack = 80,
			Defense = 100,
			SpecialAttack = 30,
			SpecialDefense = 30,
			Speed = 20
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Tackle, MoveFactory.DefenseCurl, },
			[4] = new List<Move>() { MoveFactory.Sandstorm, },
			[6] = new List<Move>() { MoveFactory.RockPolish, },
			[10] = new List<Move>() { MoveFactory.Rollout, },
			[12] = new List<Move>() { MoveFactory.Harden, },
			[16] = new List<Move>() { MoveFactory.RockThrow, },
			[18] = new List<Move>() { MoveFactory.SmackDown, },
			[22] = new List<Move>() { MoveFactory.Bulldoze, },
			[24] = new List<Move>() { MoveFactory.SelfDestruct, },
			[28] = new List<Move>() { MoveFactory.StealthRock, },
			[30] = new List<Move>() { MoveFactory.RockBlast, },
			[34] = new List<Move>() { MoveFactory.Earthquake, },
			[36] = new List<Move>() { MoveFactory.Explosion, },
			[40] = new List<Move>() { MoveFactory.DoubleEdge, },
			[42] = new List<Move>() { MoveFactory.StoneEdge, },
		};
	}
}

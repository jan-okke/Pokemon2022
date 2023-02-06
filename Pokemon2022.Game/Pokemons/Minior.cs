using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Minior : Pokemon
	{
		public override string Name => "Minior";
		public override int Generation => 7;
		public override string PokedexEntry => "Originally making its home in the ozone layer, it hurtles to the ground when the shell enclosing its body grows too heavy.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Rock, PokemonType.Flying };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.ShieldsDown, };
		public override Stats BaseStats => new Stats() {
			HP = 60,
			Attack = 60,
			Defense = 100,
			SpecialAttack = 60,
			SpecialDefense = 100,
			Speed = 60
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Tackle, },
			[3] = new List<Move>() { MoveFactory.DefenseCurl, },
			[8] = new List<Move>() { MoveFactory.Rollout, },
			[10] = new List<Move>() { MoveFactory.ConfuseRay, },
			[15] = new List<Move>() { MoveFactory.Swift, },
			[17] = new List<Move>() { MoveFactory.AncientPower, },
			[22] = new List<Move>() { MoveFactory.SelfDestruct, },
			[24] = new List<Move>() { MoveFactory.StealthRock, },
			[29] = new List<Move>() { MoveFactory.TakeDown, },
			[31] = new List<Move>() { MoveFactory.Autotomize, },
			[36] = new List<Move>() { MoveFactory.CosmicPower, },
			[38] = new List<Move>() { MoveFactory.PowerGem, },
			[43] = new List<Move>() { MoveFactory.DoubleEdge, },
			[45] = new List<Move>() { MoveFactory.ShellSmash, },
			[50] = new List<Move>() { MoveFactory.Explosion, },
		};
	}
}

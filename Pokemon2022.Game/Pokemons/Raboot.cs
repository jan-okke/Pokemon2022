using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Raboot : Pokemon
	{
		public override string Name => "Raboot";
		public override int Generation => 8;
		public override string PokedexEntry => "It kicks berries right off the branches of trees and then juggles them with its feet, practicing its footwork.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Fire };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Blaze, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Libero;
		public override Stats BaseStats => new Stats() {
			HP = 65,
			Attack = 86,
			Defense = 60,
			SpecialAttack = 55,
			SpecialDefense = 60,
			Speed = 94
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Tackle, MoveFactory.Growl, MoveFactory.Ember, MoveFactory.QuickAttack, },
			[12] = new List<Move>() { MoveFactory.DoubleKick, },
			[19] = new List<Move>() { MoveFactory.FlameCharge, },
			[24] = new List<Move>() { MoveFactory.Agility, },
			[30] = new List<Move>() { MoveFactory.Headbutt, },
			[36] = new List<Move>() { MoveFactory.Counter, },
			[42] = new List<Move>() { MoveFactory.Bounce, },
			[48] = new List<Move>() { MoveFactory.DoubleEdge, },
		};
	}
}

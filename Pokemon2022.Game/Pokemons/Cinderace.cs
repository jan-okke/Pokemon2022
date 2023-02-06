using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Cinderace : Pokemon
	{
		public override string Name => "Cinderace";
		public override int Generation => 8;
		public override string PokedexEntry => "It juggles a pebble with its feet, turning it into a burning soccer ball. Its shots strike opponents hard and leave them scorched.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Fire };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Blaze, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Libero;
		public override Stats BaseStats => new Stats() {
			HP = 80,
			Attack = 116,
			Defense = 75,
			SpecialAttack = 65,
			SpecialDefense = 75,
			Speed = 119
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[0] = new List<Move>() { MoveFactory.PyroBall, },
			[1] = new List<Move>() { MoveFactory.PyroBall, MoveFactory.Feint, MoveFactory.Tackle, MoveFactory.Growl, MoveFactory.Ember, MoveFactory.QuickAttack, },
			[12] = new List<Move>() { MoveFactory.DoubleKick, },
			[19] = new List<Move>() { MoveFactory.FlameCharge, },
			[24] = new List<Move>() { MoveFactory.Agility, },
			[30] = new List<Move>() { MoveFactory.Headbutt, },
			[38] = new List<Move>() { MoveFactory.Counter, },
			[46] = new List<Move>() { MoveFactory.Bounce, },
			[54] = new List<Move>() { MoveFactory.DoubleEdge, },
			[62] = new List<Move>() { MoveFactory.CourtChange, },
		};
	}
}

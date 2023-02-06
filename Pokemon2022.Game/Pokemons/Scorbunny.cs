using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Scorbunny : Pokemon
	{
		public override string Name => "Scorbunny";
		public override int Generation => 8;
		public override string PokedexEntry => "A warm-up of running around gets fire energy coursing through this Pokémon's body. Once that happens, it's ready to fight at full power.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Fire };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Blaze, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Libero;
		public override Stats BaseStats => new Stats() {
			HP = 50,
			Attack = 71,
			Defense = 40,
			SpecialAttack = 40,
			SpecialDefense = 40,
			Speed = 69
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Tackle, MoveFactory.Growl, },
			[6] = new List<Move>() { MoveFactory.Ember, },
			[8] = new List<Move>() { MoveFactory.QuickAttack, },
			[12] = new List<Move>() { MoveFactory.DoubleKick, },
			[17] = new List<Move>() { MoveFactory.FlameCharge, },
			[20] = new List<Move>() { MoveFactory.Agility, },
			[24] = new List<Move>() { MoveFactory.Headbutt, },
			[28] = new List<Move>() { MoveFactory.Counter, },
			[32] = new List<Move>() { MoveFactory.Bounce, },
			[36] = new List<Move>() { MoveFactory.DoubleEdge, },
		};
	}
}

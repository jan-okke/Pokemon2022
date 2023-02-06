using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Cyndaquil : Pokemon
	{
		public override string Name => "Cyndaquil";
		public override int Generation => 2;
		public override string PokedexEntry => "It flares flames from its back to protect itself. The fire burns vigorously if the Pokémon is angry. When it is tired, it sputters with incomplete combustion.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Fire };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Blaze, };
		public override Ability AvailableHiddenAbility => AbilityFactory.FlashFire;
		public override Stats BaseStats => new Stats() {
			HP = 39,
			Attack = 52,
			Defense = 43,
			SpecialAttack = 60,
			SpecialDefense = 50,
			Speed = 65
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Tackle, MoveFactory.Leer, },
			[6] = new List<Move>() { MoveFactory.Smokescreen, },
			[10] = new List<Move>() { MoveFactory.Ember, },
			[13] = new List<Move>() { MoveFactory.QuickAttack, },
			[19] = new List<Move>() { MoveFactory.FlameWheel, },
			[22] = new List<Move>() { MoveFactory.DefenseCurl, },
			[28] = new List<Move>() { MoveFactory.FlameCharge, },
			[31] = new List<Move>() { MoveFactory.Swift, },
			[37] = new List<Move>() { MoveFactory.LavaPlume, },
			[40] = new List<Move>() { MoveFactory.Flamethrower, },
			[46] = new List<Move>() { MoveFactory.Inferno, },
			[49] = new List<Move>() { MoveFactory.Rollout, },
			[55] = new List<Move>() { MoveFactory.DoubleEdge, },
			[58] = new List<Move>() { MoveFactory.BurnUp, },
			[64] = new List<Move>() { MoveFactory.Eruption, },
		};
	}
}

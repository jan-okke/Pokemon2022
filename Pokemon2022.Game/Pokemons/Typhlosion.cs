using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Typhlosion : Pokemon
	{
		public override string Name => "Typhlosion";
		public override int Generation => 2;
		public override string PokedexEntry => "It can hide behind a shimmering heat haze that it creates using its intense flames. Typhlosion create blazing explosive blasts that burn everything to cinders.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Fire };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Blaze, };
		public override Ability AvailableHiddenAbility => AbilityFactory.FlashFire;
		public override Stats BaseStats => new Stats() {
			HP = 78,
			Attack = 84,
			Defense = 78,
			SpecialAttack = 109,
			SpecialDefense = 85,
			Speed = 100
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Eruption, MoveFactory.DoubleEdge, MoveFactory.GyroBall, MoveFactory.Tackle, MoveFactory.Leer, MoveFactory.Smokescreen, MoveFactory.Ember, },
			[6] = new List<Move>() { MoveFactory.Smokescreen, },
			[10] = new List<Move>() { MoveFactory.Ember, },
			[13] = new List<Move>() { MoveFactory.QuickAttack, },
			[20] = new List<Move>() { MoveFactory.FlameWheel, },
			[24] = new List<Move>() { MoveFactory.DefenseCurl, },
			[31] = new List<Move>() { MoveFactory.Swift, },
			[35] = new List<Move>() { MoveFactory.FlameCharge, },
			[43] = new List<Move>() { MoveFactory.LavaPlume, },
			[48] = new List<Move>() { MoveFactory.Flamethrower, },
			[56] = new List<Move>() { MoveFactory.Inferno, },
			[61] = new List<Move>() { MoveFactory.Rollout, },
			[69] = new List<Move>() { MoveFactory.DoubleEdge, },
			[74] = new List<Move>() { MoveFactory.BurnUp, },
			[82] = new List<Move>() { MoveFactory.Eruption, },
		};
	}
}

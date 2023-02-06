using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Quilava : Pokemon
	{
		public override string Name => "Quilava";
		public override int Generation => 2;
		public override string PokedexEntry => "It intimidates foes with intense gusts of flames and superheated air. Its quick nimbleness lets it dodge attacks even while scorching an enemy.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Fire };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Blaze, };
		public override Ability AvailableHiddenAbility => AbilityFactory.FlashFire;
		public override Stats BaseStats => new Stats() {
			HP = 58,
			Attack = 64,
			Defense = 58,
			SpecialAttack = 80,
			SpecialDefense = 65,
			Speed = 80
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Tackle, MoveFactory.Leer, MoveFactory.Smokescreen, },
			[6] = new List<Move>() { MoveFactory.Smokescreen, },
			[10] = new List<Move>() { MoveFactory.Ember, },
			[13] = new List<Move>() { MoveFactory.QuickAttack, },
			[20] = new List<Move>() { MoveFactory.FlameWheel, },
			[24] = new List<Move>() { MoveFactory.DefenseCurl, },
			[31] = new List<Move>() { MoveFactory.Swift, },
			[35] = new List<Move>() { MoveFactory.FlameCharge, },
			[42] = new List<Move>() { MoveFactory.LavaPlume, },
			[46] = new List<Move>() { MoveFactory.Flamethrower, },
			[53] = new List<Move>() { MoveFactory.Inferno, },
			[57] = new List<Move>() { MoveFactory.Rollout, },
			[64] = new List<Move>() { MoveFactory.DoubleEdge, },
			[68] = new List<Move>() { MoveFactory.BurnUp, },
			[75] = new List<Move>() { MoveFactory.Eruption, },
		};
	}
}

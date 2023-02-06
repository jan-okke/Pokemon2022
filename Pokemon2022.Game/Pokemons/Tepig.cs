using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Tepig : Pokemon
	{
		public override string Name => "Tepig";
		public override int Generation => 5;
		public override string PokedexEntry => "It blows fire through its nose. When it catches a cold, the fire becomes pitch-black smoke instead.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Fire };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Blaze, };
		public override Ability AvailableHiddenAbility => AbilityFactory.ThickFat;
		public override Stats BaseStats => new Stats() {
			HP = 65,
			Attack = 63,
			Defense = 45,
			SpecialAttack = 45,
			SpecialDefense = 45,
			Speed = 45
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Tackle, },
			[3] = new List<Move>() { MoveFactory.TailWhip, },
			[7] = new List<Move>() { MoveFactory.Ember, },
			[9] = new List<Move>() { MoveFactory.OdorSleuth, },
			[13] = new List<Move>() { MoveFactory.DefenseCurl, },
			[15] = new List<Move>() { MoveFactory.FlameCharge, },
			[19] = new List<Move>() { MoveFactory.Smog, },
			[21] = new List<Move>() { MoveFactory.Rollout, },
			[25] = new List<Move>() { MoveFactory.TakeDown, },
			[27] = new List<Move>() { MoveFactory.HeatCrash, },
			[31] = new List<Move>() { MoveFactory.Assurance, },
			[33] = new List<Move>() { MoveFactory.Flamethrower, },
			[37] = new List<Move>() { MoveFactory.HeadSmash, },
			[39] = new List<Move>() { MoveFactory.Roar, },
			[43] = new List<Move>() { MoveFactory.FlareBlitz, },
		};
	}
}

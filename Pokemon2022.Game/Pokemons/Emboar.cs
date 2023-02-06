using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Emboar : Pokemon
	{
		public override string Name => "Emboar";
		public override int Generation => 5;
		public override string PokedexEntry => "It can throw a fire punch by setting its fists on fire with its fiery chin. It cares deeply about its friends.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Fire, PokemonType.Fighting };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Blaze, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Reckless;
		public override Stats BaseStats => new Stats() {
			HP = 110,
			Attack = 123,
			Defense = 65,
			SpecialAttack = 100,
			SpecialDefense = 65,
			Speed = 65
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.ArmThrust, MoveFactory.HammerArm, MoveFactory.Tackle, MoveFactory.TailWhip, MoveFactory.Ember, MoveFactory.OdorSleuth, },
			[3] = new List<Move>() { MoveFactory.TailWhip, },
			[7] = new List<Move>() { MoveFactory.Ember, },
			[9] = new List<Move>() { MoveFactory.OdorSleuth, },
			[13] = new List<Move>() { MoveFactory.DefenseCurl, },
			[15] = new List<Move>() { MoveFactory.FlameCharge, },
			[20] = new List<Move>() { MoveFactory.Smog, },
			[23] = new List<Move>() { MoveFactory.Rollout, },
			[28] = new List<Move>() { MoveFactory.TakeDown, },
			[31] = new List<Move>() { MoveFactory.HeatCrash, },
			[38] = new List<Move>() { MoveFactory.Assurance, },
			[43] = new List<Move>() { MoveFactory.Flamethrower, },
			[50] = new List<Move>() { MoveFactory.HeadSmash, },
			[55] = new List<Move>() { MoveFactory.Roar, },
			[62] = new List<Move>() { MoveFactory.FlareBlitz, },
		};
	}
}

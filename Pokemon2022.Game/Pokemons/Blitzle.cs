using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Blitzle : Pokemon
	{
		public override string Name => "Blitzle";
		public override int Generation => 5;
		public override string PokedexEntry => "When thunderclouds cover the sky, it will appear. It can catch lightning with its mane and store the electricity.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Electric };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.LightningRod, AbilityFactory.MotorDrive, };
		public override Ability AvailableHiddenAbility => AbilityFactory.SapSipper;
		public override Stats BaseStats => new Stats() {
			HP = 45,
			Attack = 60,
			Defense = 32,
			SpecialAttack = 50,
			SpecialDefense = 32,
			Speed = 76
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.QuickAttack, },
			[4] = new List<Move>() { MoveFactory.TailWhip, },
			[8] = new List<Move>() { MoveFactory.Charge, },
			[11] = new List<Move>() { MoveFactory.ShockWave, },
			[15] = new List<Move>() { MoveFactory.ThunderWave, },
			[18] = new List<Move>() { MoveFactory.FlameCharge, },
			[22] = new List<Move>() { MoveFactory.Pursuit, },
			[25] = new List<Move>() { MoveFactory.Spark, },
			[29] = new List<Move>() { MoveFactory.Stomp, },
			[32] = new List<Move>() { MoveFactory.Discharge, },
			[36] = new List<Move>() { MoveFactory.Agility, },
			[39] = new List<Move>() { MoveFactory.WildCharge, },
			[43] = new List<Move>() { MoveFactory.Thrash, },
		};
	}
}

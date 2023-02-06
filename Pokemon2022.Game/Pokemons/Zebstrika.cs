using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Zebstrika : Pokemon
	{
		public override string Name => "Zebstrika";
		public override int Generation => 5;
		public override string PokedexEntry => "This ill-tempered Pokémon is dangerous because when it's angry, it shoots lightning from its mane in all directions.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Electric };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.LightningRod, AbilityFactory.MotorDrive, };
		public override Ability AvailableHiddenAbility => AbilityFactory.SapSipper;
		public override Stats BaseStats => new Stats() {
			HP = 75,
			Attack = 100,
			Defense = 63,
			SpecialAttack = 80,
			SpecialDefense = 63,
			Speed = 116
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.IonDeluge, MoveFactory.QuickAttack, MoveFactory.TailWhip, MoveFactory.Charge, MoveFactory.ThunderWave, },
			[4] = new List<Move>() { MoveFactory.TailWhip, },
			[8] = new List<Move>() { MoveFactory.Charge, },
			[11] = new List<Move>() { MoveFactory.ShockWave, },
			[15] = new List<Move>() { MoveFactory.ThunderWave, },
			[18] = new List<Move>() { MoveFactory.FlameCharge, },
			[22] = new List<Move>() { MoveFactory.Pursuit, },
			[25] = new List<Move>() { MoveFactory.Spark, },
			[31] = new List<Move>() { MoveFactory.Stomp, },
			[36] = new List<Move>() { MoveFactory.Discharge, },
			[42] = new List<Move>() { MoveFactory.Agility, },
			[47] = new List<Move>() { MoveFactory.WildCharge, },
			[53] = new List<Move>() { MoveFactory.Thrash, },
			[58] = new List<Move>() { MoveFactory.IonDeluge, },
		};
	}
}

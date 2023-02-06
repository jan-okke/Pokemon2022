using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Shinx : Pokemon
	{
		public override string Name => "Shinx";
		public override int Generation => 4;
		public override string PokedexEntry => "All of its fur dazzles if danger is sensed. It flees while the foe is momentarily blinded.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Electric };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Rivalry, AbilityFactory.Intimidate, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Guts;
		public override Stats BaseStats => new Stats() {
			HP = 45,
			Attack = 65,
			Defense = 34,
			SpecialAttack = 40,
			SpecialDefense = 34,
			Speed = 45
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Tackle, MoveFactory.Leer, },
			[4] = new List<Move>() { MoveFactory.ThunderShock, },
			[8] = new List<Move>() { MoveFactory.Charge, },
			[12] = new List<Move>() { MoveFactory.Bite, },
			[16] = new List<Move>() { MoveFactory.Spark, },
			[20] = new List<Move>() { MoveFactory.Roar, },
			[24] = new List<Move>() { MoveFactory.VoltSwitch, },
			[28] = new List<Move>() { MoveFactory.ScaryFace, },
			[32] = new List<Move>() { MoveFactory.ThunderWave, },
			[36] = new List<Move>() { MoveFactory.Crunch, },
			[40] = new List<Move>() { MoveFactory.Discharge, },
			[44] = new List<Move>() { MoveFactory.Swagger, },
			[48] = new List<Move>() { MoveFactory.WildCharge, },
		};
	}
}

using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Luxio : Pokemon
	{
		public override string Name => "Luxio";
		public override int Generation => 4;
		public override string PokedexEntry => "Its claws loose electricity with enough amperage to cause fainting. They live in small groups.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Electric };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Rivalry, AbilityFactory.Intimidate, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Guts;
		public override Stats BaseStats => new Stats() {
			HP = 60,
			Attack = 85,
			Defense = 49,
			SpecialAttack = 60,
			SpecialDefense = 49,
			Speed = 60
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Tackle, MoveFactory.Leer, MoveFactory.ThunderShock, MoveFactory.Charge, },
			[12] = new List<Move>() { MoveFactory.Bite, },
			[18] = new List<Move>() { MoveFactory.Spark, },
			[24] = new List<Move>() { MoveFactory.Roar, },
			[31] = new List<Move>() { MoveFactory.VoltSwitch, },
			[36] = new List<Move>() { MoveFactory.ScaryFace, },
			[42] = new List<Move>() { MoveFactory.ThunderWave, },
			[48] = new List<Move>() { MoveFactory.Crunch, },
			[54] = new List<Move>() { MoveFactory.Discharge, },
			[60] = new List<Move>() { MoveFactory.Swagger, },
			[68] = new List<Move>() { MoveFactory.WildCharge, },
		};
	}
}

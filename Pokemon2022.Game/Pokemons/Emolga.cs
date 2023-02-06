using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Emolga : Pokemon
	{
		public override string Name => "Emolga";
		public override int Generation => 5;
		public override string PokedexEntry => "They live on treetops and glide using the inside of a cape-like membrane while discharging electricity.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Electric, PokemonType.Flying };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Static, };
		public override Ability AvailableHiddenAbility => AbilityFactory.MotorDrive;
		public override Stats BaseStats => new Stats() {
			HP = 55,
			Attack = 75,
			Defense = 60,
			SpecialAttack = 75,
			SpecialDefense = 60,
			Speed = 103
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Nuzzle, MoveFactory.TailWhip, },
			[5] = new List<Move>() { MoveFactory.DoubleTeam, },
			[10] = new List<Move>() { MoveFactory.QuickAttack, },
			[15] = new List<Move>() { MoveFactory.ThunderShock, },
			[20] = new List<Move>() { MoveFactory.Charge, },
			[25] = new List<Move>() { MoveFactory.Acrobatics, },
			[30] = new List<Move>() { MoveFactory.Spark, },
			[35] = new List<Move>() { MoveFactory.Encore, },
			[40] = new List<Move>() { MoveFactory.VoltSwitch, },
			[45] = new List<Move>() { MoveFactory.LightScreen, },
			[50] = new List<Move>() { MoveFactory.Discharge, },
			[55] = new List<Move>() { MoveFactory.Agility, },
		};
	}
}

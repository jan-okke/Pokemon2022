using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Togedemaru : Pokemon
	{
		public override string Name => "Togedemaru";
		public override int Generation => 7;
		public override string PokedexEntry => "The long hairs on its back act as lightning rods. The bolts of lightning it attracts are stored as energy in its electric sac.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Electric, PokemonType.Steel };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.IronBarbs, AbilityFactory.LightningRod, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Sturdy;
		public override Stats BaseStats => new Stats() {
			HP = 65,
			Attack = 98,
			Defense = 63,
			SpecialAttack = 40,
			SpecialDefense = 73,
			Speed = 96
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Nuzzle, MoveFactory.Tackle, },
			[5] = new List<Move>() { MoveFactory.DefenseCurl, },
			[10] = new List<Move>() { MoveFactory.Charge, },
			[15] = new List<Move>() { MoveFactory.ThunderShock, },
			[20] = new List<Move>() { MoveFactory.FellStinger, },
			[25] = new List<Move>() { MoveFactory.Spark, },
			[30] = new List<Move>() { MoveFactory.PinMissile, },
			[35] = new List<Move>() { MoveFactory.MagnetRise, },
			[40] = new List<Move>() { MoveFactory.ZingZap, },
			[45] = new List<Move>() { MoveFactory.Discharge, },
			[50] = new List<Move>() { MoveFactory.ElectricTerrain, },
			[55] = new List<Move>() { MoveFactory.WildCharge, },
			[60] = new List<Move>() { MoveFactory.SpikyShield, },
		};
	}
}

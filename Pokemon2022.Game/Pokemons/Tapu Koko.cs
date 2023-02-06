using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class TapuKoko : Pokemon
	{
		public override string Name => "Tapu Koko";
		public override int Generation => 7;
		public override string PokedexEntry => "Although it's called a guardian deity, if a person or Pokémon puts it in a bad mood, it will become a malevolent deity and attack.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Electric, PokemonType.Fairy };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.ElectricSurge, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Telepathy;
		public override Stats BaseStats => new Stats() {
			HP = 70,
			Attack = 115,
			Defense = 85,
			SpecialAttack = 95,
			SpecialDefense = 75,
			Speed = 130
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.QuickAttack, MoveFactory.ThunderShock, },
			[5] = new List<Move>() { MoveFactory.Withdraw, },
			[10] = new List<Move>() { MoveFactory.FairyWind, },
			[15] = new List<Move>() { MoveFactory.FalseSwipe, },
			[20] = new List<Move>() { MoveFactory.Spark, },
			[25] = new List<Move>() { MoveFactory.ShockWave, },
			[30] = new List<Move>() { MoveFactory.Charge, },
			[35] = new List<Move>() { MoveFactory.Agility, },
			[40] = new List<Move>() { MoveFactory.Screech, },
			[45] = new List<Move>() { MoveFactory.Discharge, },
			[50] = new List<Move>() { MoveFactory.MeanLook, },
			[55] = new List<Move>() { MoveFactory.NaturesMadness, },
			[60] = new List<Move>() { MoveFactory.WildCharge, },
			[65] = new List<Move>() { MoveFactory.BraveBird, },
			[70] = new List<Move>() { MoveFactory.PowerSwap, },
			[75] = new List<Move>() { MoveFactory.ElectricTerrain, },
		};
	}
}

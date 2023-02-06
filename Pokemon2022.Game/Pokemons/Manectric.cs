using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Manectric : Pokemon
	{
		public override string Name => "Manectric";
		public override int Generation => 3;
		public override string PokedexEntry => "Because lightning falls in their vicinities, Manectric were thought to have been born from lightning. In battle, they create thunderclouds.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Electric };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Static, AbilityFactory.LightningRod, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Minus;
		public override Stats BaseStats => new Stats() {
			HP = 70,
			Attack = 75,
			Defense = 60,
			SpecialAttack = 105,
			SpecialDefense = 60,
			Speed = 105
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.FireFang, MoveFactory.Tackle, MoveFactory.ThunderWave, MoveFactory.Leer, MoveFactory.Howl, },
			[12] = new List<Move>() { MoveFactory.QuickAttack, },
			[16] = new List<Move>() { MoveFactory.ShockWave, },
			[20] = new List<Move>() { MoveFactory.Bite, },
			[24] = new List<Move>() { MoveFactory.ThunderFang, },
			[30] = new List<Move>() { MoveFactory.Roar, },
			[36] = new List<Move>() { MoveFactory.Discharge, },
			[42] = new List<Move>() { MoveFactory.Charge, },
			[48] = new List<Move>() { MoveFactory.WildCharge, },
			[54] = new List<Move>() { MoveFactory.Thunder, },
			[60] = new List<Move>() { MoveFactory.ElectricTerrain, },
		};
	}
}

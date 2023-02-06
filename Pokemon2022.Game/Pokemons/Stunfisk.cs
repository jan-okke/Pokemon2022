using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Stunfisk : Pokemon
	{
		public override string Name => "Stunfisk";
		public override int Generation => 5;
		public override string PokedexEntry => "It conceals itself in the mud of the seashore. Then it waits. When prey touch it, it delivers a jolt of energy.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Ground, PokemonType.Electric };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Static, AbilityFactory.Limber, };
		public override Ability AvailableHiddenAbility => AbilityFactory.SandVeil;
		public override Stats BaseStats => new Stats() {
			HP = 109,
			Attack = 66,
			Defense = 84,
			SpecialAttack = 81,
			SpecialDefense = 99,
			Speed = 32
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.MudSlap, MoveFactory.Tackle, MoveFactory.WaterGun, MoveFactory.ThunderShock, },
			[5] = new List<Move>() { MoveFactory.Endure, },
			[10] = new List<Move>() { MoveFactory.MudShot, },
			[15] = new List<Move>() { MoveFactory.Revenge, },
			[20] = new List<Move>() { MoveFactory.Charge, },
			[25] = new List<Move>() { MoveFactory.SuckerPunch, },
			[30] = new List<Move>() { MoveFactory.ElectricTerrain, },
			[35] = new List<Move>() { MoveFactory.Bounce, },
			[40] = new List<Move>() { MoveFactory.MuddyWater, },
			[45] = new List<Move>() { MoveFactory.Discharge, },
			[50] = new List<Move>() { MoveFactory.Flail, },
			[55] = new List<Move>() { MoveFactory.Fissure, },
		};
	}
}

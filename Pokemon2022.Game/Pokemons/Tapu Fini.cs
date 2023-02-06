using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class TapuFini : Pokemon
	{
		public override string Name => "Tapu Fini";
		public override int Generation => 7;
		public override string PokedexEntry => "The dense fog it creates brings the downfall and destruction of its confused enemies. Ocean currents are the source of its energy.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Water, PokemonType.Fairy };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.MistySurge, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Telepathy;
		public override Stats BaseStats => new Stats() {
			HP = 70,
			Attack = 75,
			Defense = 115,
			SpecialAttack = 95,
			SpecialDefense = 130,
			Speed = 85
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.DisarmingVoice, MoveFactory.WaterGun, },
			[5] = new List<Move>() { MoveFactory.Withdraw, },
			[10] = new List<Move>() { MoveFactory.Mist, MoveFactory.Haze, },
			[15] = new List<Move>() { MoveFactory.AquaRing, },
			[20] = new List<Move>() { MoveFactory.WaterPulse, },
			[25] = new List<Move>() { MoveFactory.Brine, },
			[30] = new List<Move>() { MoveFactory.Defog, },
			[35] = new List<Move>() { MoveFactory.HealPulse, },
			[40] = new List<Move>() { MoveFactory.Surf, },
			[45] = new List<Move>() { MoveFactory.MuddyWater, },
			[50] = new List<Move>() { MoveFactory.MeanLook, },
			[55] = new List<Move>() { MoveFactory.NaturesMadness, },
			[60] = new List<Move>() { MoveFactory.Moonblast, },
			[65] = new List<Move>() { MoveFactory.HydroPump, },
			[70] = new List<Move>() { MoveFactory.Soak, },
			[75] = new List<Move>() { MoveFactory.MistyTerrain, },
		};
	}
}

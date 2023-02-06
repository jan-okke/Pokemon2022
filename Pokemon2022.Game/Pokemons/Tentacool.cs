using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Tentacool : Pokemon
	{
		public override string Name => "Tentacool";
		public override int Generation => 1;
		public override string PokedexEntry => "Its body is almost entirely composed of water. It ensnares its foe with its two long tentacles, then stabs with the poison stingers at their tips.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Water, PokemonType.Poison };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.ClearBody, AbilityFactory.LiquidOoze, };
		public override Ability AvailableHiddenAbility => AbilityFactory.RainDish;
		public override Stats BaseStats => new Stats() {
			HP = 40,
			Attack = 40,
			Defense = 35,
			SpecialAttack = 50,
			SpecialDefense = 100,
			Speed = 70
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.PoisonSting, MoveFactory.WaterGun, },
			[4] = new List<Move>() { MoveFactory.Acid, },
			[8] = new List<Move>() { MoveFactory.Wrap, },
			[12] = new List<Move>() { MoveFactory.Supersonic, },
			[16] = new List<Move>() { MoveFactory.WaterPulse, },
			[20] = new List<Move>() { MoveFactory.Screech, },
			[24] = new List<Move>() { MoveFactory.BubbleBeam, },
			[28] = new List<Move>() { MoveFactory.Hex, },
			[32] = new List<Move>() { MoveFactory.AcidArmor, },
			[36] = new List<Move>() { MoveFactory.PoisonJab, },
			[40] = new List<Move>() { MoveFactory.Surf, },
			[44] = new List<Move>() { MoveFactory.SludgeWave, },
			[48] = new List<Move>() { MoveFactory.HydroPump, },
		};
	}
}

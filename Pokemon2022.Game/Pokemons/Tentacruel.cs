using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Tentacruel : Pokemon
	{
		public override string Name => "Tentacruel";
		public override int Generation => 1;
		public override string PokedexEntry => "It lives in complex rock formations on the ocean floor and traps prey using its 80 tentacles. Its red orbs glow when it grows excited or agitated.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Water, PokemonType.Poison };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.ClearBody, AbilityFactory.LiquidOoze, };
		public override Ability AvailableHiddenAbility => AbilityFactory.RainDish;
		public override Stats BaseStats => new Stats() {
			HP = 80,
			Attack = 70,
			Defense = 65,
			SpecialAttack = 80,
			SpecialDefense = 120,
			Speed = 100
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.ReflectType, MoveFactory.PoisonSting, MoveFactory.WaterGun, MoveFactory.Acid, MoveFactory.Wrap, },
			[12] = new List<Move>() { MoveFactory.Supersonic, },
			[16] = new List<Move>() { MoveFactory.WaterPulse, },
			[20] = new List<Move>() { MoveFactory.Screech, },
			[24] = new List<Move>() { MoveFactory.BubbleBeam, },
			[28] = new List<Move>() { MoveFactory.Hex, },
			[34] = new List<Move>() { MoveFactory.AcidArmor, },
			[40] = new List<Move>() { MoveFactory.PoisonJab, },
			[46] = new List<Move>() { MoveFactory.Surf, },
			[52] = new List<Move>() { MoveFactory.SludgeWave, },
			[58] = new List<Move>() { MoveFactory.HydroPump, },
		};
	}
}

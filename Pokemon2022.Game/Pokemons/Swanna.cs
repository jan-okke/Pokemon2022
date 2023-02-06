using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Swanna : Pokemon
	{
		public override string Name => "Swanna";
		public override int Generation => 5;
		public override string PokedexEntry => "It administers sharp, powerful pecks with its bill. It whips its long neck to deliver forceful repeated strikes.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Water, PokemonType.Flying };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.KeenEye, AbilityFactory.BigPecks, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Hydration;
		public override Stats BaseStats => new Stats() {
			HP = 75,
			Attack = 87,
			Defense = 63,
			SpecialAttack = 87,
			SpecialDefense = 63,
			Speed = 98
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.WaterGun, MoveFactory.WaterSport, MoveFactory.Defog, MoveFactory.WingAttack, },
			[3] = new List<Move>() { MoveFactory.WaterSport, },
			[6] = new List<Move>() { MoveFactory.Defog, },
			[9] = new List<Move>() { MoveFactory.WingAttack, },
			[13] = new List<Move>() { MoveFactory.WaterPulse, },
			[15] = new List<Move>() { MoveFactory.AerialAce, },
			[19] = new List<Move>() { MoveFactory.BubbleBeam, },
			[21] = new List<Move>() { MoveFactory.FeatherDance, },
			[24] = new List<Move>() { MoveFactory.AquaRing, },
			[27] = new List<Move>() { MoveFactory.AirSlash, },
			[30] = new List<Move>() { MoveFactory.Roost, },
			[34] = new List<Move>() { MoveFactory.RainDance, },
			[40] = new List<Move>() { MoveFactory.Tailwind, },
			[47] = new List<Move>() { MoveFactory.BraveBird, },
			[55] = new List<Move>() { MoveFactory.Hurricane, },
		};
	}
}

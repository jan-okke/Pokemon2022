using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Finneon : Pokemon
	{
		public override string Name => "Finneon";
		public override int Generation => 4;
		public override string PokedexEntry => "After long exposure to sunlight, the patterns on its tail fins shine vividly when darkness arrives.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Water };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.SwiftSwim, AbilityFactory.StormDrain, };
		public override Ability AvailableHiddenAbility => AbilityFactory.WaterVeil;
		public override Stats BaseStats => new Stats() {
			HP = 49,
			Attack = 49,
			Defense = 56,
			SpecialAttack = 49,
			SpecialDefense = 61,
			Speed = 66
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Pound, },
			[6] = new List<Move>() { MoveFactory.WaterGun, },
			[10] = new List<Move>() { MoveFactory.Attract, },
			[13] = new List<Move>() { MoveFactory.RainDance, },
			[17] = new List<Move>() { MoveFactory.Gust, },
			[22] = new List<Move>() { MoveFactory.WaterPulse, },
			[26] = new List<Move>() { MoveFactory.Flail, },
			[29] = new List<Move>() { MoveFactory.Safeguard, },
			[33] = new List<Move>() { MoveFactory.AquaRing, },
			[38] = new List<Move>() { MoveFactory.Whirlpool, },
			[42] = new List<Move>() { MoveFactory.Uturn, },
			[45] = new List<Move>() { MoveFactory.Bounce, },
			[49] = new List<Move>() { MoveFactory.Tailwind, },
			[54] = new List<Move>() { MoveFactory.Soak, },
		};
	}
}

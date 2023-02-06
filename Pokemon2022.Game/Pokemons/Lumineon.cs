using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Lumineon : Pokemon
	{
		public override string Name => "Lumineon";
		public override int Generation => 4;
		public override string PokedexEntry => "It lives on the deep-sea floor. It attracts prey by flashing the patterns on its four tail fins.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Water };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.SwiftSwim, AbilityFactory.StormDrain, };
		public override Ability AvailableHiddenAbility => AbilityFactory.WaterVeil;
		public override Stats BaseStats => new Stats() {
			HP = 69,
			Attack = 69,
			Defense = 76,
			SpecialAttack = 69,
			SpecialDefense = 86,
			Speed = 91
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Soak, MoveFactory.Gust, MoveFactory.Pound, MoveFactory.WaterGun, MoveFactory.Attract, },
			[6] = new List<Move>() { MoveFactory.WaterGun, },
			[10] = new List<Move>() { MoveFactory.Attract, },
			[13] = new List<Move>() { MoveFactory.RainDance, },
			[17] = new List<Move>() { MoveFactory.Gust, },
			[22] = new List<Move>() { MoveFactory.WaterPulse, },
			[26] = new List<Move>() { MoveFactory.Flail, },
			[29] = new List<Move>() { MoveFactory.Safeguard, },
			[35] = new List<Move>() { MoveFactory.AquaRing, },
			[42] = new List<Move>() { MoveFactory.Whirlpool, },
			[48] = new List<Move>() { MoveFactory.Uturn, },
			[53] = new List<Move>() { MoveFactory.Bounce, },
			[59] = new List<Move>() { MoveFactory.Tailwind, },
			[66] = new List<Move>() { MoveFactory.Soak, },
		};
	}
}

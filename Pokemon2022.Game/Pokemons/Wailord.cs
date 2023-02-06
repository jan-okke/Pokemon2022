using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Wailord : Pokemon
	{
		public override string Name => "Wailord";
		public override int Generation => 3;
		public override string PokedexEntry => "It breathes through nostrils that it raises above the sea. By inhaling to its maximum capacity, a Wailord can dive close to 10,000 feet beneath the waves.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Water };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.WaterVeil, AbilityFactory.Oblivious, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Pressure;
		public override Stats BaseStats => new Stats() {
			HP = 170,
			Attack = 90,
			Defense = 45,
			SpecialAttack = 90,
			SpecialDefense = 45,
			Speed = 60
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Soak, MoveFactory.NobleRoar, MoveFactory.Splash, MoveFactory.Growl, MoveFactory.Astonish, MoveFactory.WaterGun, },
			[15] = new List<Move>() { MoveFactory.Mist, },
			[18] = new List<Move>() { MoveFactory.WaterPulse, },
			[21] = new List<Move>() { MoveFactory.HeavySlam, },
			[24] = new List<Move>() { MoveFactory.Brine, },
			[27] = new List<Move>() { MoveFactory.Whirlpool, },
			[30] = new List<Move>() { MoveFactory.Dive, },
			[33] = new List<Move>() { MoveFactory.Bounce, },
			[36] = new List<Move>() { MoveFactory.BodySlam, },
			[39] = new List<Move>() { MoveFactory.Rest, },
			[44] = new List<Move>() { MoveFactory.Amnesia, },
			[49] = new List<Move>() { MoveFactory.HydroPump, },
			[54] = new List<Move>() { MoveFactory.WaterSpout, },
		};
	}
}

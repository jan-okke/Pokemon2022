using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Volcanion : Pokemon
	{
		public override string Name => "Volcanion";
		public override int Generation => 6;
		public override string PokedexEntry => "It lets out billows of steam and disappears into the dense fog. It's said to live in mountains where humans do not tread.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Fire, PokemonType.Water };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.WaterAbsorb, };
		public override Stats BaseStats => new Stats() {
			HP = 80,
			Attack = 110,
			Defense = 120,
			SpecialAttack = 130,
			SpecialDefense = 90,
			Speed = 70
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.FireSpin, MoveFactory.WaterGun, },
			[6] = new List<Move>() { MoveFactory.Leer, },
			[12] = new List<Move>() { MoveFactory.WeatherBall, },
			[18] = new List<Move>() { MoveFactory.FlameCharge, },
			[24] = new List<Move>() { MoveFactory.WaterPulse, },
			[30] = new List<Move>() { MoveFactory.ScaryFace, },
			[36] = new List<Move>() { MoveFactory.Incinerate, },
			[42] = new List<Move>() { MoveFactory.Stomp, },
			[48] = new List<Move>() { MoveFactory.Scald, },
			[54] = new List<Move>() { MoveFactory.TakeDown, },
			[60] = new List<Move>() { MoveFactory.Mist, MoveFactory.Haze, },
			[66] = new List<Move>() { MoveFactory.HydroPump, },
			[72] = new List<Move>() { MoveFactory.SteamEruption, },
			[78] = new List<Move>() { MoveFactory.FlareBlitz, },
			[84] = new List<Move>() { MoveFactory.Overheat, },
			[90] = new List<Move>() { MoveFactory.Explosion, },
		};
	}
}

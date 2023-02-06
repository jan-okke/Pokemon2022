using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Swampert : Pokemon
	{
		public override string Name => "Swampert";
		public override int Generation => 3;
		public override string PokedexEntry => "If it senses the approach of a storm and a tidal wave, it protects its seaside nest by piling up boulders. It swims as fast as a jet ski.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Water, PokemonType.Ground };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Torrent, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Damp;
		public override Stats BaseStats => new Stats() {
			HP = 100,
			Attack = 110,
			Defense = 90,
			SpecialAttack = 85,
			SpecialDefense = 90,
			Speed = 60
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.MudShot, MoveFactory.HammerArm, MoveFactory.Earthquake, MoveFactory.Surf, MoveFactory.Tackle, MoveFactory.Growl, MoveFactory.WaterGun, MoveFactory.RockSmash, },
			[9] = new List<Move>() { MoveFactory.RockThrow, },
			[12] = new List<Move>() { MoveFactory.Protect, },
			[15] = new List<Move>() { MoveFactory.Supersonic, },
			[20] = new List<Move>() { MoveFactory.WaterPulse, },
			[25] = new List<Move>() { MoveFactory.RockSlide, },
			[30] = new List<Move>() { MoveFactory.TakeDown, },
			[35] = new List<Move>() { MoveFactory.Amnesia, },
			[42] = new List<Move>() { MoveFactory.MuddyWater, },
			[49] = new List<Move>() { MoveFactory.Screech, },
			[56] = new List<Move>() { MoveFactory.Endeavor, },
			[63] = new List<Move>() { MoveFactory.HydroPump, },
		};
	}
}

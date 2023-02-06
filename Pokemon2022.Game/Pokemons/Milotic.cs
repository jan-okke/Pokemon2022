using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Milotic : Pokemon
	{
		public override string Name => "Milotic";
		public override int Generation => 3;
		public override string PokedexEntry => "It is said to live at the bottom of large lakes. Considered to be the most beautiful of all Pokémon, it has been depicted in paintings and statues.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Water };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.MarvelScale, AbilityFactory.Competitive, };
		public override Ability AvailableHiddenAbility => AbilityFactory.CuteCharm;
		public override Stats BaseStats => new Stats() {
			HP = 95,
			Attack = 60,
			Defense = 79,
			SpecialAttack = 100,
			SpecialDefense = 125,
			Speed = 81
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[0] = new List<Move>() { MoveFactory.WaterPulse, },
			[1] = new List<Move>() { MoveFactory.WaterPulse, MoveFactory.Flail, MoveFactory.Splash, MoveFactory.Tackle, MoveFactory.Wrap, MoveFactory.WaterGun, },
			[4] = new List<Move>() { MoveFactory.DisarmingVoice, },
			[8] = new List<Move>() { MoveFactory.Twister, },
			[12] = new List<Move>() { MoveFactory.AquaRing, },
			[16] = new List<Move>() { MoveFactory.Attract, },
			[20] = new List<Move>() { MoveFactory.LifeDew, },
			[24] = new List<Move>() { MoveFactory.DragonTail, },
			[28] = new List<Move>() { MoveFactory.Recover, },
			[32] = new List<Move>() { MoveFactory.AquaTail, },
			[36] = new List<Move>() { MoveFactory.Safeguard, },
			[40] = new List<Move>() { MoveFactory.Surf, },
			[44] = new List<Move>() { MoveFactory.RainDance, },
			[48] = new List<Move>() { MoveFactory.Coil, },
			[52] = new List<Move>() { MoveFactory.HydroPump, },
		};
	}
}

using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Zygarde : Pokemon
	{
		public override string Name => "Zygarde";
		public override int Generation => 6;
		public override string PokedexEntry => "It's thought to be monitoring the ecosystem. There are rumors that even greater power lies hidden within it.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Dragon, PokemonType.Ground };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.AuraBreak, AbilityFactory.PowerConstruct, };
		public override Stats BaseStats => new Stats() {
			HP = 108,
			Attack = 100,
			Defense = 121,
			SpecialAttack = 81,
			SpecialDefense = 95,
			Speed = 95
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.ThousandArrows, MoveFactory.ThousandWaves, MoveFactory.CoreEnforcer, MoveFactory.Bind, MoveFactory.Bulldoze, MoveFactory.DragonBreath, MoveFactory.Bite, },
			[8] = new List<Move>() { MoveFactory.Haze, },
			[16] = new List<Move>() { MoveFactory.Dig, },
			[24] = new List<Move>() { MoveFactory.Safeguard, },
			[32] = new List<Move>() { MoveFactory.Crunch, },
			[40] = new List<Move>() { MoveFactory.DragonPulse, },
			[48] = new List<Move>() { MoveFactory.LandsWrath, },
			[56] = new List<Move>() { MoveFactory.Glare, },
			[64] = new List<Move>() { MoveFactory.Sandstorm, },
			[72] = new List<Move>() { MoveFactory.Coil, },
			[80] = new List<Move>() { MoveFactory.Earthquake, },
			[88] = new List<Move>() { MoveFactory.Outrage, },
		};
	}
}

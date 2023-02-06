using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Arctozolt : Pokemon
	{
		public override string Name => "Arctozolt";
		public override int Generation => 8;
		public override string PokedexEntry => "The shaking of its freezing upper half is what generates its electricity. It has a hard time walking around.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Electric, PokemonType.Ice };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.VoltAbsorb, AbilityFactory.Static, };
		public override Ability AvailableHiddenAbility => AbilityFactory.SlushRush;
		public override Stats BaseStats => new Stats() {
			HP = 90,
			Attack = 100,
			Defense = 90,
			SpecialAttack = 90,
			SpecialDefense = 80,
			Speed = 55
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.PowderSnow, MoveFactory.ThunderShock, },
			[7] = new List<Move>() { MoveFactory.Charge, },
			[14] = new List<Move>() { MoveFactory.EchoedVoice, },
			[21] = new List<Move>() { MoveFactory.AncientPower, },
			[28] = new List<Move>() { MoveFactory.Pluck, },
			[35] = new List<Move>() { MoveFactory.Avalanche, },
			[42] = new List<Move>() { MoveFactory.FreezeDry, },
			[49] = new List<Move>() { MoveFactory.Slam, },
			[56] = new List<Move>() { MoveFactory.Discharge, },
			[63] = new List<Move>() { MoveFactory.BoltBeak, },
			[70] = new List<Move>() { MoveFactory.IcicleCrash, },
			[77] = new List<Move>() { MoveFactory.Blizzard, },
		};
	}
}

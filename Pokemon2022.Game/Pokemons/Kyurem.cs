using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Kyurem : Pokemon
	{
		public override string Name => "Kyurem";
		public override int Generation => 5;
		public override string PokedexEntry => "It generates a powerful, freezing energy inside itself, but its body became frozen when the energy leaked out.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Dragon, PokemonType.Ice };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Pressure, };
		public override Stats BaseStats => new Stats() {
			HP = 125,
			Attack = 130,
			Defense = 90,
			SpecialAttack = 130,
			SpecialDefense = 90,
			Speed = 95
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.DragonBreath, MoveFactory.NobleRoar, MoveFactory.AncientPower, MoveFactory.FreezeDry, },
			[8] = new List<Move>() { MoveFactory.Slash, },
			[16] = new List<Move>() { MoveFactory.Endeavor, },
			[24] = new List<Move>() { MoveFactory.DragonPulse, },
			[32] = new List<Move>() { MoveFactory.IceBeam, },
			[40] = new List<Move>() { MoveFactory.HyperVoice, },
			[48] = new List<Move>() { MoveFactory.ScaryFace, },
			[56] = new List<Move>() { MoveFactory.Blizzard, },
			[64] = new List<Move>() { MoveFactory.Imprison, },
			[72] = new List<Move>() { MoveFactory.Outrage, },
			[80] = new List<Move>() { MoveFactory.Glaciate, },
			[88] = new List<Move>() { MoveFactory.SheerCold, },
		};
	}
}

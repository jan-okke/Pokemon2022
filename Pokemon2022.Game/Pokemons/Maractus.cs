using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Maractus : Pokemon
	{
		public override string Name => "Maractus";
		public override int Generation => 5;
		public override string PokedexEntry => "Arid regions are their habitat. They move rhythmically, making a sound similar to maracas.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Grass };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.WaterAbsorb, AbilityFactory.Chlorophyll, };
		public override Ability AvailableHiddenAbility => AbilityFactory.StormDrain;
		public override Stats BaseStats => new Stats() {
			HP = 75,
			Attack = 86,
			Defense = 67,
			SpecialAttack = 106,
			SpecialDefense = 67,
			Speed = 60
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.SpikyShield, MoveFactory.Peck, MoveFactory.Absorb, MoveFactory.AfterYou, MoveFactory.Ingrain, },
			[4] = new List<Move>() { MoveFactory.Growth, },
			[8] = new List<Move>() { MoveFactory.MegaDrain, },
			[12] = new List<Move>() { MoveFactory.LeechSeed, },
			[16] = new List<Move>() { MoveFactory.SuckerPunch, },
			[20] = new List<Move>() { MoveFactory.PinMissile, },
			[24] = new List<Move>() { MoveFactory.GigaDrain, },
			[28] = new List<Move>() { MoveFactory.SweetScent, },
			[32] = new List<Move>() { MoveFactory.Synthesis, },
			[36] = new List<Move>() { MoveFactory.PetalBlizzard, },
			[40] = new List<Move>() { MoveFactory.CottonSpore, },
			[44] = new List<Move>() { MoveFactory.SunnyDay, },
			[48] = new List<Move>() { MoveFactory.SolarBeam, },
			[52] = new List<Move>() { MoveFactory.Acupressure, },
			[56] = new List<Move>() { MoveFactory.PetalDance, },
			[60] = new List<Move>() { MoveFactory.CottonGuard, },
		};
	}
}

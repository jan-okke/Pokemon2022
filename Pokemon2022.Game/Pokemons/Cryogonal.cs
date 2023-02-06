using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Cryogonal : Pokemon
	{
		public override string Name => "Cryogonal";
		public override int Generation => 5;
		public override string PokedexEntry => "They are born in snow clouds. They use chains made of ice crystals to capture prey.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Ice };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Levitate, };
		public override Stats BaseStats => new Stats() {
			HP = 80,
			Attack = 50,
			Defense = 50,
			SpecialAttack = 95,
			SpecialDefense = 135,
			Speed = 105
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Bind, MoveFactory.IceShard, },
			[4] = new List<Move>() { MoveFactory.ConfuseRay, },
			[8] = new List<Move>() { MoveFactory.RapidSpin, },
			[12] = new List<Move>() { MoveFactory.LaserFocus, },
			[16] = new List<Move>() { MoveFactory.IcyWind, },
			[20] = new List<Move>() { MoveFactory.Mist, MoveFactory.Haze, },
			[24] = new List<Move>() { MoveFactory.AncientPower, },
			[28] = new List<Move>() { MoveFactory.AuroraBeam, },
			[32] = new List<Move>() { MoveFactory.Slash, MoveFactory.NightSlash, },
			[36] = new List<Move>() { MoveFactory.FreezeDry, },
			[40] = new List<Move>() { MoveFactory.LightScreen, MoveFactory.Reflect, },
			[44] = new List<Move>() { MoveFactory.Recover, },
			[48] = new List<Move>() { MoveFactory.IceBeam, },
			[52] = new List<Move>() { MoveFactory.AcidArmor, },
			[56] = new List<Move>() { MoveFactory.SolarBeam, },
			[60] = new List<Move>() { MoveFactory.SheerCold, },
		};
	}
}

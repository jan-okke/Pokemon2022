using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Seel : Pokemon
	{
		public override string Name => "Seel";
		public override int Generation => 1;
		public override string PokedexEntry => "Seel hunt for prey in frigid, ice-covered seas. When it needs to breathe, it punches a hole through the ice with the sharply protruding section of its head.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Water };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.ThickFat, AbilityFactory.Hydration, };
		public override Ability AvailableHiddenAbility => AbilityFactory.IceBody;
		public override Stats BaseStats => new Stats() {
			HP = 65,
			Attack = 45,
			Defense = 55,
			SpecialAttack = 45,
			SpecialDefense = 70,
			Speed = 45
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Headbutt, },
			[3] = new List<Move>() { MoveFactory.Growl, },
			[7] = new List<Move>() { MoveFactory.WaterGun, },
			[11] = new List<Move>() { MoveFactory.IcyWind, },
			[13] = new List<Move>() { MoveFactory.Encore, },
			[17] = new List<Move>() { MoveFactory.IceShard, },
			[21] = new List<Move>() { MoveFactory.Rest, },
			[23] = new List<Move>() { MoveFactory.AquaRing, },
			[27] = new List<Move>() { MoveFactory.AuroraBeam, },
			[31] = new List<Move>() { MoveFactory.AquaJet, },
			[33] = new List<Move>() { MoveFactory.Brine, },
			[37] = new List<Move>() { MoveFactory.TakeDown, },
			[41] = new List<Move>() { MoveFactory.Dive, },
			[43] = new List<Move>() { MoveFactory.AquaTail, },
			[47] = new List<Move>() { MoveFactory.IceBeam, },
			[51] = new List<Move>() { MoveFactory.Safeguard, },
			[53] = new List<Move>() { MoveFactory.Hail, },
		};
	}
}

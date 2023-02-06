using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Arctovish : Pokemon
	{
		public override string Name => "Arctovish";
		public override int Generation => 8;
		public override string PokedexEntry => "Though it's able to capture prey by freezing its surroundings, it has trouble eating the prey afterward because its mouth is on top of its head.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Water, PokemonType.Ice };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.WaterAbsorb, AbilityFactory.IceBody, };
		public override Ability AvailableHiddenAbility => AbilityFactory.SlushRush;
		public override Stats BaseStats => new Stats() {
			HP = 90,
			Attack = 90,
			Defense = 100,
			SpecialAttack = 80,
			SpecialDefense = 90,
			Speed = 55
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.PowderSnow, MoveFactory.WaterGun, },
			[7] = new List<Move>() { MoveFactory.Protect, },
			[14] = new List<Move>() { MoveFactory.IcyWind, },
			[21] = new List<Move>() { MoveFactory.AncientPower, },
			[28] = new List<Move>() { MoveFactory.Bite, },
			[35] = new List<Move>() { MoveFactory.AuroraVeil, },
			[42] = new List<Move>() { MoveFactory.FreezeDry, },
			[49] = new List<Move>() { MoveFactory.SuperFang, },
			[56] = new List<Move>() { MoveFactory.Crunch, },
			[63] = new List<Move>() { MoveFactory.FishiousRend, },
			[70] = new List<Move>() { MoveFactory.IcicleCrash, },
			[77] = new List<Move>() { MoveFactory.Blizzard, },
		};
	}
}

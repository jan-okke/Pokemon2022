using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Corsola : Pokemon
	{
		public override string Name => "Corsola";
		public override int Generation => 2;
		public override string PokedexEntry => "Corsola live in warm southern seas. If the sea becomes polluted, the beautiful coral stalks become discolored and crumble away in tatters.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Water, PokemonType.Rock };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Hustle, AbilityFactory.NaturalCure, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Regenerator;
		public override Stats BaseStats => new Stats() {
			HP = 65,
			Attack = 55,
			Defense = 95,
			SpecialAttack = 65,
			SpecialDefense = 95,
			Speed = 35
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Tackle, MoveFactory.Harden, },
			[5] = new List<Move>() { MoveFactory.WaterGun, },
			[10] = new List<Move>() { MoveFactory.AquaRing, },
			[15] = new List<Move>() { MoveFactory.Endure, },
			[20] = new List<Move>() { MoveFactory.AncientPower, },
			[25] = new List<Move>() { MoveFactory.BubbleBeam, },
			[30] = new List<Move>() { MoveFactory.Flail, },
			[35] = new List<Move>() { MoveFactory.LifeDew, },
			[40] = new List<Move>() { MoveFactory.PowerGem, },
			[45] = new List<Move>() { MoveFactory.EarthPower, },
			[50] = new List<Move>() { MoveFactory.Recover, },
			[55] = new List<Move>() { MoveFactory.MirrorCoat, },
		};
	}
}

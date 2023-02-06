using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Sunflora : Pokemon
	{
		public override string Name => "Sunflora";
		public override int Generation => 2;
		public override string PokedexEntry => "Sunflora convert solar energy into nutrition. They are highly active in the warm daytime but suddenly stop moving as soon as the sun sets.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Grass };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Chlorophyll, AbilityFactory.SolarPower, };
		public override Ability AvailableHiddenAbility => AbilityFactory.EarlyBird;
		public override Stats BaseStats => new Stats() {
			HP = 75,
			Attack = 75,
			Defense = 55,
			SpecialAttack = 105,
			SpecialDefense = 85,
			Speed = 30
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.FlowerShield, MoveFactory.Pound, MoveFactory.Growth, },
			[4] = new List<Move>() { MoveFactory.Ingrain, },
			[7] = new List<Move>() { MoveFactory.Absorb, },
			[10] = new List<Move>() { MoveFactory.MegaDrain, },
			[13] = new List<Move>() { MoveFactory.LeechSeed, },
			[16] = new List<Move>() { MoveFactory.RazorLeaf, },
			[19] = new List<Move>() { MoveFactory.WorrySeed, },
			[22] = new List<Move>() { MoveFactory.GigaDrain, },
			[25] = new List<Move>() { MoveFactory.BulletSeed, },
			[28] = new List<Move>() { MoveFactory.PetalDance, },
			[34] = new List<Move>() { MoveFactory.SolarBeam, },
			[37] = new List<Move>() { MoveFactory.DoubleEdge, },
			[40] = new List<Move>() { MoveFactory.SunnyDay, },
			[43] = new List<Move>() { MoveFactory.LeafStorm, },
			[50] = new List<Move>() { MoveFactory.PetalBlizzard, },
		};
	}
}

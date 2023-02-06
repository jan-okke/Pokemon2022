using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Quagsire : Pokemon
	{
		public override string Name => "Quagsire";
		public override int Generation => 2;
		public override string PokedexEntry => "A Quagsire hunts by leaving its mouth wide open in water and waiting for its prey to blunder in. Because it doesn't move, it does not get very hungry.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Water, PokemonType.Ground };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Damp, AbilityFactory.WaterAbsorb, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Unaware;
		public override Stats BaseStats => new Stats() {
			HP = 95,
			Attack = 85,
			Defense = 85,
			SpecialAttack = 65,
			SpecialDefense = 65,
			Speed = 35
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.WaterGun, MoveFactory.TailWhip, MoveFactory.RainDance, MoveFactory.MudShot, },
			[12] = new List<Move>() { MoveFactory.Mist, MoveFactory.Haze, },
			[16] = new List<Move>() { MoveFactory.Slam, },
			[23] = new List<Move>() { MoveFactory.Yawn, },
			[28] = new List<Move>() { MoveFactory.AquaTail, },
			[34] = new List<Move>() { MoveFactory.MuddyWater, },
			[40] = new List<Move>() { MoveFactory.Amnesia, },
			[46] = new List<Move>() { MoveFactory.Toxic, },
			[52] = new List<Move>() { MoveFactory.Earthquake, },
		};
	}
}

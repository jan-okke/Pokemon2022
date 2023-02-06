using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Wooper : Pokemon
	{
		public override string Name => "Wooper";
		public override int Generation => 2;
		public override string PokedexEntry => "Wooper usually live in water but come out onto land seeking food occasionally. On land, they coat their bodies with a gooey, toxic film.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Water, PokemonType.Ground };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Damp, AbilityFactory.WaterAbsorb, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Unaware;
		public override Stats BaseStats => new Stats() {
			HP = 55,
			Attack = 45,
			Defense = 45,
			SpecialAttack = 25,
			SpecialDefense = 25,
			Speed = 15
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.WaterGun, MoveFactory.TailWhip, },
			[4] = new List<Move>() { MoveFactory.RainDance, },
			[8] = new List<Move>() { MoveFactory.MudShot, },
			[12] = new List<Move>() { MoveFactory.Mist, MoveFactory.Haze, },
			[16] = new List<Move>() { MoveFactory.Slam, },
			[21] = new List<Move>() { MoveFactory.Yawn, },
			[24] = new List<Move>() { MoveFactory.AquaTail, },
			[28] = new List<Move>() { MoveFactory.MuddyWater, },
			[32] = new List<Move>() { MoveFactory.Amnesia, },
			[36] = new List<Move>() { MoveFactory.Toxic, },
			[40] = new List<Move>() { MoveFactory.Earthquake, },
		};
	}
}

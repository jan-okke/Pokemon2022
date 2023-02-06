using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Ducklett : Pokemon
	{
		public override string Name => "Ducklett";
		public override int Generation => 5;
		public override string PokedexEntry => "When attacked, it uses its feathers to splash water, escaping under cover of the spray.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Water, PokemonType.Flying };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.KeenEye, AbilityFactory.BigPecks, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Hydration;
		public override Stats BaseStats => new Stats() {
			HP = 62,
			Attack = 44,
			Defense = 50,
			SpecialAttack = 44,
			SpecialDefense = 50,
			Speed = 55
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.WaterGun, },
			[3] = new List<Move>() { MoveFactory.WaterSport, },
			[6] = new List<Move>() { MoveFactory.Defog, },
			[9] = new List<Move>() { MoveFactory.WingAttack, },
			[13] = new List<Move>() { MoveFactory.WaterPulse, },
			[15] = new List<Move>() { MoveFactory.AerialAce, },
			[19] = new List<Move>() { MoveFactory.BubbleBeam, },
			[21] = new List<Move>() { MoveFactory.FeatherDance, },
			[24] = new List<Move>() { MoveFactory.AquaRing, },
			[27] = new List<Move>() { MoveFactory.AirSlash, },
			[30] = new List<Move>() { MoveFactory.Roost, },
			[34] = new List<Move>() { MoveFactory.RainDance, },
			[37] = new List<Move>() { MoveFactory.Tailwind, },
			[41] = new List<Move>() { MoveFactory.BraveBird, },
			[46] = new List<Move>() { MoveFactory.Hurricane, },
		};
	}
}

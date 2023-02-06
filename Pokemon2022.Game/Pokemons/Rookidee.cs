using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Rookidee : Pokemon
	{
		public override string Name => "Rookidee";
		public override int Generation => 8;
		public override string PokedexEntry => "Jumping nimbly about, this small-bodied Pokémon takes advantage of even the slightest opportunity to disorient larger opponents.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Flying };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.KeenEye, AbilityFactory.Unnerve, };
		public override Ability AvailableHiddenAbility => AbilityFactory.BigPecks;
		public override Stats BaseStats => new Stats() {
			HP = 38,
			Attack = 47,
			Defense = 35,
			SpecialAttack = 33,
			SpecialDefense = 35,
			Speed = 57
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Peck, MoveFactory.Leer, },
			[4] = new List<Move>() { MoveFactory.PowerTrip, },
			[8] = new List<Move>() { MoveFactory.HoneClaws, },
			[12] = new List<Move>() { MoveFactory.FuryAttack, },
			[16] = new List<Move>() { MoveFactory.Pluck, },
			[20] = new List<Move>() { MoveFactory.Taunt, },
			[24] = new List<Move>() { MoveFactory.ScaryFace, },
			[28] = new List<Move>() { MoveFactory.DrillPeck, },
			[32] = new List<Move>() { MoveFactory.Swagger, },
			[36] = new List<Move>() { MoveFactory.BraveBird, },
		};
	}
}

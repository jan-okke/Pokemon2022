using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Corvisquire : Pokemon
	{
		public override string Name => "Corvisquire";
		public override int Generation => 8;
		public override string PokedexEntry => "Smart enough to use tools in battle, these Pokémon have been seen picking up rocks and flinging them or using ropes to wrap up enemies.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Flying };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.KeenEye, AbilityFactory.Unnerve, };
		public override Ability AvailableHiddenAbility => AbilityFactory.BigPecks;
		public override Stats BaseStats => new Stats() {
			HP = 68,
			Attack = 67,
			Defense = 55,
			SpecialAttack = 43,
			SpecialDefense = 55,
			Speed = 77
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Peck, MoveFactory.Leer, MoveFactory.PowerTrip, MoveFactory.HoneClaws, },
			[12] = new List<Move>() { MoveFactory.FuryAttack, },
			[16] = new List<Move>() { MoveFactory.Pluck, },
			[22] = new List<Move>() { MoveFactory.Taunt, },
			[28] = new List<Move>() { MoveFactory.ScaryFace, },
			[34] = new List<Move>() { MoveFactory.DrillPeck, },
			[40] = new List<Move>() { MoveFactory.Swagger, },
			[46] = new List<Move>() { MoveFactory.BraveBird, },
		};
	}
}

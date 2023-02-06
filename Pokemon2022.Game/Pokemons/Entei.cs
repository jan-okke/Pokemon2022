using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Entei : Pokemon
	{
		public override string Name => "Entei";
		public override int Generation => 2;
		public override string PokedexEntry => "Entei embodies the passion of magma. It is thought to have been born in the eruption of a volcano. It blasts fire that consumes all that it touches.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Fire };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Pressure, };
		public override Ability AvailableHiddenAbility => AbilityFactory.InnerFocus;
		public override Stats BaseStats => new Stats() {
			HP = 115,
			Attack = 115,
			Defense = 85,
			SpecialAttack = 90,
			SpecialDefense = 75,
			Speed = 100
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.SacredFire, MoveFactory.ExtremeSpeed, MoveFactory.Ember, MoveFactory.Leer, MoveFactory.Stomp, MoveFactory.Smokescreen, },
			[6] = new List<Move>() { MoveFactory.FlameWheel, },
			[12] = new List<Move>() { MoveFactory.Bite, },
			[18] = new List<Move>() { MoveFactory.CalmMind, },
			[24] = new List<Move>() { MoveFactory.Roar, },
			[30] = new List<Move>() { MoveFactory.FireFang, },
			[36] = new List<Move>() { MoveFactory.ScaryFace, },
			[42] = new List<Move>() { MoveFactory.Crunch, },
			[48] = new List<Move>() { MoveFactory.Extrasensory, },
			[54] = new List<Move>() { MoveFactory.LavaPlume, },
			[60] = new List<Move>() { MoveFactory.Swagger, },
			[66] = new List<Move>() { MoveFactory.SunnyDay, },
			[72] = new List<Move>() { MoveFactory.FireBlast, },
			[78] = new List<Move>() { MoveFactory.Eruption, },
		};
	}
}

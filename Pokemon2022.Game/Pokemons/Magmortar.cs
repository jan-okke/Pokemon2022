using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Magmortar : Pokemon
	{
		public override string Name => "Magmortar";
		public override int Generation => 4;
		public override string PokedexEntry => "It blasts fireballs of over 3,600 degrees F from the ends of its arms. It lives in volcanic craters.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Fire };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.FlameBody, };
		public override Ability AvailableHiddenAbility => AbilityFactory.VitalSpirit;
		public override Stats BaseStats => new Stats() {
			HP = 75,
			Attack = 95,
			Defense = 67,
			SpecialAttack = 125,
			SpecialDefense = 95,
			Speed = 83
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Smog, MoveFactory.Leer, MoveFactory.Ember, MoveFactory.Smokescreen, },
			[12] = new List<Move>() { MoveFactory.ClearSmog, },
			[16] = new List<Move>() { MoveFactory.FlameWheel, },
			[20] = new List<Move>() { MoveFactory.ConfuseRay, },
			[24] = new List<Move>() { MoveFactory.ScaryFace, },
			[28] = new List<Move>() { MoveFactory.FirePunch, },
			[34] = new List<Move>() { MoveFactory.LavaPlume, },
			[40] = new List<Move>() { MoveFactory.LowKick, },
			[46] = new List<Move>() { MoveFactory.Flamethrower, },
			[52] = new List<Move>() { MoveFactory.SunnyDay, },
			[58] = new List<Move>() { MoveFactory.FireBlast, },
			[64] = new List<Move>() { MoveFactory.HyperBeam, },
		};
	}
}

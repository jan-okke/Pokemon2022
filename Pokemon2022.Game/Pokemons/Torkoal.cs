using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Torkoal : Pokemon
	{
		public override string Name => "Torkoal";
		public override int Generation => 3;
		public override string PokedexEntry => "It battles using energy it gets from burning coal. When loosing smoke from its nostrils, it lets off a sound that is similar to a locomotive's horn.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Fire };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.WhiteSmoke, AbilityFactory.Drought, };
		public override Ability AvailableHiddenAbility => AbilityFactory.ShellArmor;
		public override Stats BaseStats => new Stats() {
			HP = 70,
			Attack = 85,
			Defense = 140,
			SpecialAttack = 85,
			SpecialDefense = 70,
			Speed = 20
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Smog, MoveFactory.Ember, },
			[4] = new List<Move>() { MoveFactory.Withdraw, },
			[8] = new List<Move>() { MoveFactory.RapidSpin, },
			[12] = new List<Move>() { MoveFactory.Smokescreen, },
			[16] = new List<Move>() { MoveFactory.ClearSmog, },
			[20] = new List<Move>() { MoveFactory.FlameWheel, },
			[24] = new List<Move>() { MoveFactory.Protect, },
			[28] = new List<Move>() { MoveFactory.LavaPlume, },
			[32] = new List<Move>() { MoveFactory.BodySlam, },
			[36] = new List<Move>() { MoveFactory.IronDefense, },
			[40] = new List<Move>() { MoveFactory.Flamethrower, },
			[44] = new List<Move>() { MoveFactory.Curse, },
			[48] = new List<Move>() { MoveFactory.HeatWave, },
			[52] = new List<Move>() { MoveFactory.Amnesia, },
			[56] = new List<Move>() { MoveFactory.Inferno, },
			[60] = new List<Move>() { MoveFactory.ShellSmash, },
			[64] = new List<Move>() { MoveFactory.Eruption, },
		};
	}
}

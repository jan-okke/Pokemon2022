using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Volcarona : Pokemon
	{
		public override string Name => "Volcarona";
		public override int Generation => 5;
		public override string PokedexEntry => "A sea of fire engulfs the surroundings of their battles, since they use their six wings to scatter their ember scales.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Bug, PokemonType.Fire };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.FlameBody, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Swarm;
		public override Stats BaseStats => new Stats() {
			HP = 85,
			Attack = 60,
			Defense = 65,
			SpecialAttack = 135,
			SpecialDefense = 105,
			Speed = 100
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[0] = new List<Move>() { MoveFactory.QuiverDance, },
			[1] = new List<Move>() { MoveFactory.QuiverDance, MoveFactory.FieryDance, MoveFactory.Whirlwind, MoveFactory.Ember, MoveFactory.FlameCharge, MoveFactory.TakeDown, MoveFactory.DoubleEdge, MoveFactory.FlareBlitz, MoveFactory.FireSpin, MoveFactory.StringShot, MoveFactory.Gust, MoveFactory.StruggleBug, },
			[18] = new List<Move>() { MoveFactory.FlameWheel, },
			[24] = new List<Move>() { MoveFactory.BugBite, },
			[30] = new List<Move>() { MoveFactory.Screech, },
			[36] = new List<Move>() { MoveFactory.LeechLife, },
			[42] = new List<Move>() { MoveFactory.BugBuzz, },
			[48] = new List<Move>() { MoveFactory.HeatWave, },
			[54] = new List<Move>() { MoveFactory.Amnesia, },
			[62] = new List<Move>() { MoveFactory.Hurricane, },
			[70] = new List<Move>() { MoveFactory.FireBlast, },
			[78] = new List<Move>() { MoveFactory.RagePowder, },
		};
	}
}

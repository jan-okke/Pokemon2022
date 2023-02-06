using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Heatran : Pokemon
	{
		public override string Name => "Heatran";
		public override int Generation => 4;
		public override string PokedexEntry => "It dwells in volcanic caves. It digs in with its cross-shaped feet to crawl on ceilings and walls.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Fire, PokemonType.Steel };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.FlashFire, };
		public override Ability AvailableHiddenAbility => AbilityFactory.FlameBody;
		public override Stats BaseStats => new Stats() {
			HP = 91,
			Attack = 90,
			Defense = 106,
			SpecialAttack = 130,
			SpecialDefense = 106,
			Speed = 77
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.FireSpin, MoveFactory.Leer, },
			[6] = new List<Move>() { MoveFactory.MetalClaw, },
			[12] = new List<Move>() { MoveFactory.AncientPower, },
			[18] = new List<Move>() { MoveFactory.FireFang, },
			[24] = new List<Move>() { MoveFactory.ScaryFace, },
			[30] = new List<Move>() { MoveFactory.IronHead, },
			[36] = new List<Move>() { MoveFactory.Crunch, },
			[42] = new List<Move>() { MoveFactory.LavaPlume, },
			[48] = new List<Move>() { MoveFactory.MetalSound, },
			[54] = new List<Move>() { MoveFactory.EarthPower, },
			[60] = new List<Move>() { MoveFactory.HeatWave, },
			[66] = new List<Move>() { MoveFactory.StoneEdge, },
			[72] = new List<Move>() { MoveFactory.MagmaStorm, },
		};
	}
}

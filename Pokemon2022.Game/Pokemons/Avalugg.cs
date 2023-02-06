using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Avalugg : Pokemon
	{
		public override string Name => "Avalugg";
		public override int Generation => 6;
		public override string PokedexEntry => "Its ice-covered body is as hard as steel. Its cumbersome frame crushes anything that stands in its way.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Ice };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.OwnTempo, AbilityFactory.IceBody, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Sturdy;
		public override Stats BaseStats => new Stats() {
			HP = 95,
			Attack = 117,
			Defense = 184,
			SpecialAttack = 44,
			SpecialDefense = 46,
			Speed = 28
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[0] = new List<Move>() { MoveFactory.BodySlam, },
			[1] = new List<Move>() { MoveFactory.BodySlam, MoveFactory.WideGuard, MoveFactory.RapidSpin, MoveFactory.Harden, MoveFactory.Tackle, MoveFactory.PowderSnow, },
			[9] = new List<Move>() { MoveFactory.Curse, },
			[12] = new List<Move>() { MoveFactory.IcyWind, },
			[15] = new List<Move>() { MoveFactory.Protect, },
			[18] = new List<Move>() { MoveFactory.Avalanche, },
			[21] = new List<Move>() { MoveFactory.Bite, },
			[24] = new List<Move>() { MoveFactory.IceFang, },
			[27] = new List<Move>() { MoveFactory.IronDefense, },
			[30] = new List<Move>() { MoveFactory.Recover, },
			[33] = new List<Move>() { MoveFactory.Crunch, },
			[36] = new List<Move>() { MoveFactory.TakeDown, },
			[41] = new List<Move>() { MoveFactory.Blizzard, },
			[46] = new List<Move>() { MoveFactory.DoubleEdge, },
			[51] = new List<Move>() { MoveFactory.SkullBash, },
		};
	}
}

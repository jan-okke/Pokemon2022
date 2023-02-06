using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Hoopa : Pokemon
	{
		public override string Name => "Hoopa";
		public override int Generation => 6;
		public override string PokedexEntry => "This troublemaker sends anything and everything to faraway places using its loop, which can warp space.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Psychic, PokemonType.Ghost };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Magician, };
		public override Stats BaseStats => new Stats() {
			HP = 80,
			Attack = 110,
			Defense = 60,
			SpecialAttack = 150,
			SpecialDefense = 130,
			Speed = 70
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.HyperspaceHole, MoveFactory.Trick, MoveFactory.DestinyBond, MoveFactory.AllySwitch, MoveFactory.Confusion, },
			[6] = new List<Move>() { MoveFactory.Astonish, },
			[10] = new List<Move>() { MoveFactory.MagicCoat, },
			[15] = new List<Move>() { MoveFactory.LightScreen, },
			[19] = new List<Move>() { MoveFactory.Psybeam, },
			[25] = new List<Move>() { MoveFactory.SkillSwap, },
			[29] = new List<Move>() { MoveFactory.PowerSplit, MoveFactory.GuardSplit, },
			[35] = new List<Move>() { MoveFactory.PhantomForce, },
			[46] = new List<Move>() { MoveFactory.ZenHeadbutt, },
			[50] = new List<Move>() { MoveFactory.WonderRoom, MoveFactory.TrickRoom, },
			[55] = new List<Move>() { MoveFactory.ShadowBall, },
			[68] = new List<Move>() { MoveFactory.NastyPlot, },
			[75] = new List<Move>() { MoveFactory.Psychic, },
			[85] = new List<Move>() { MoveFactory.HyperspaceHole, },
		};
	}
}

using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Gastly : Pokemon
	{
		public override string Name => "Gastly";
		public override int Generation => 1;
		public override string PokedexEntry => "When exposed to a strong wind, a Gastly's gaseous body quickly dwindles away. They cluster under the eaves of houses to escape the ravages of wind.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Ghost, PokemonType.Poison };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Levitate, };
		public override Stats BaseStats => new Stats() {
			HP = 30,
			Attack = 35,
			Defense = 30,
			SpecialAttack = 100,
			SpecialDefense = 35,
			Speed = 80
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Lick, MoveFactory.ConfuseRay, },
			[4] = new List<Move>() { MoveFactory.Hypnosis, },
			[8] = new List<Move>() { MoveFactory.MeanLook, },
			[12] = new List<Move>() { MoveFactory.Payback, },
			[16] = new List<Move>() { MoveFactory.Spite, },
			[20] = new List<Move>() { MoveFactory.Curse, },
			[24] = new List<Move>() { MoveFactory.Hex, },
			[28] = new List<Move>() { MoveFactory.NightShade, },
			[32] = new List<Move>() { MoveFactory.SuckerPunch, },
			[36] = new List<Move>() { MoveFactory.DarkPulse, },
			[40] = new List<Move>() { MoveFactory.ShadowBall, },
			[44] = new List<Move>() { MoveFactory.DestinyBond, },
			[48] = new List<Move>() { MoveFactory.DreamEater, },
		};
	}
}

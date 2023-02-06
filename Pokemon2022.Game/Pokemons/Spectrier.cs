using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Spectrier : Pokemon
	{
		public override string Name => "Spectrier";
		public override int Generation => 8;
		public override string PokedexEntry => "As it dashes through the night, Spectrier absorbs the life-force of sleeping creatures. It craves silence and solitude.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Ghost };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.GrimNeigh, };
		public override Stats BaseStats => new Stats() {
			HP = 100,
			Attack = 65,
			Defense = 60,
			SpecialAttack = 145,
			SpecialDefense = 80,
			Speed = 130
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Tackle, MoveFactory.TailWhip, },
			[6] = new List<Move>() { MoveFactory.DoubleKick, },
			[12] = new List<Move>() { MoveFactory.Hex, },
			[18] = new List<Move>() { MoveFactory.Stomp, },
			[24] = new List<Move>() { MoveFactory.ConfuseRay, },
			[30] = new List<Move>() { MoveFactory.Haze, },
			[36] = new List<Move>() { MoveFactory.ShadowBall, },
			[42] = new List<Move>() { MoveFactory.TakeDown, },
			[48] = new List<Move>() { MoveFactory.Agility, },
			[54] = new List<Move>() { MoveFactory.Thrash, },
			[60] = new List<Move>() { MoveFactory.Disable, },
			[66] = new List<Move>() { MoveFactory.DoubleEdge, },
			[72] = new List<Move>() { MoveFactory.NastyPlot, },
		};
	}
}

using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Glastrier : Pokemon
	{
		public override string Name => "Glastrier";
		public override int Generation => 8;
		public override string PokedexEntry => "Glastrier has tremendous physical strength, and the mask of ice covering its face is 100 times harder than diamond.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Ice };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.ChillingNeigh, };
		public override Stats BaseStats => new Stats() {
			HP = 100,
			Attack = 145,
			Defense = 130,
			SpecialAttack = 65,
			SpecialDefense = 110,
			Speed = 30
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Tackle, MoveFactory.TailWhip, },
			[6] = new List<Move>() { MoveFactory.DoubleKick, },
			[12] = new List<Move>() { MoveFactory.Avalanche, },
			[18] = new List<Move>() { MoveFactory.Stomp, },
			[24] = new List<Move>() { MoveFactory.Torment, },
			[30] = new List<Move>() { MoveFactory.Mist, },
			[36] = new List<Move>() { MoveFactory.IcicleCrash, },
			[42] = new List<Move>() { MoveFactory.TakeDown, },
			[48] = new List<Move>() { MoveFactory.IronDefense, },
			[54] = new List<Move>() { MoveFactory.Thrash, },
			[60] = new List<Move>() { MoveFactory.Taunt, },
			[66] = new List<Move>() { MoveFactory.DoubleEdge, },
			[72] = new List<Move>() { MoveFactory.SwordsDance, },
		};
	}
}

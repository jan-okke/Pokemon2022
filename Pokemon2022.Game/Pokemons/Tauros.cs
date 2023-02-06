using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Tauros : Pokemon
	{
		public override string Name => "Tauros";
		public override int Generation => 1;
		public override string PokedexEntry => "It is not satisfied unless it is rampaging at all times. If there is no opponent for Tauros to battle, it will charge at thick trees and knock them down to calm itself.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Normal };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Intimidate, AbilityFactory.AngerPoint, };
		public override Ability AvailableHiddenAbility => AbilityFactory.SheerForce;
		public override Stats BaseStats => new Stats() {
			HP = 75,
			Attack = 100,
			Defense = 95,
			SpecialAttack = 40,
			SpecialDefense = 70,
			Speed = 110
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Tackle, MoveFactory.TailWhip, },
			[5] = new List<Move>() { MoveFactory.WorkUp, },
			[10] = new List<Move>() { MoveFactory.Payback, },
			[15] = new List<Move>() { MoveFactory.Assurance, },
			[20] = new List<Move>() { MoveFactory.HornAttack, },
			[25] = new List<Move>() { MoveFactory.ScaryFace, },
			[30] = new List<Move>() { MoveFactory.ZenHeadbutt, },
			[35] = new List<Move>() { MoveFactory.TakeDown, },
			[40] = new List<Move>() { MoveFactory.Rest, },
			[45] = new List<Move>() { MoveFactory.Swagger, },
			[50] = new List<Move>() { MoveFactory.Thrash, },
			[55] = new List<Move>() { MoveFactory.DoubleEdge, },
			[60] = new List<Move>() { MoveFactory.GigaImpact, },
		};
	}
}

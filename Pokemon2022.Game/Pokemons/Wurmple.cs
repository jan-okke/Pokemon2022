using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Wurmple : Pokemon
	{
		public override string Name => "Wurmple";
		public override int Generation => 3;
		public override string PokedexEntry => "It sticks to tree branches and eats leaves. The thread it spits from its mouth becomes gooey when it touches air and slows the movement of its foes.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Bug };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.ShieldDust, };
		public override Ability AvailableHiddenAbility => AbilityFactory.RunAway;
		public override Stats BaseStats => new Stats() {
			HP = 45,
			Attack = 45,
			Defense = 35,
			SpecialAttack = 20,
			SpecialDefense = 30,
			Speed = 20
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Tackle, MoveFactory.StringShot, },
			[5] = new List<Move>() { MoveFactory.PoisonSting, },
			[15] = new List<Move>() { MoveFactory.BugBite, },
		};
	}
}

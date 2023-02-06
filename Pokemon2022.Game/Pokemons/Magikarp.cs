using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Magikarp : Pokemon
	{
		public override string Name => "Magikarp";
		public override int Generation => 1;
		public override string PokedexEntry => "Its swimming muscles are weak, so it is easily washed away by currents. In places where water pools, you can see many Magikarp deposited there by the flow.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Water };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.SwiftSwim, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Rattled;
		public override Stats BaseStats => new Stats() {
			HP = 20,
			Attack = 10,
			Defense = 55,
			SpecialAttack = 15,
			SpecialDefense = 20,
			Speed = 80
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Splash, },
			[15] = new List<Move>() { MoveFactory.Tackle, },
			[25] = new List<Move>() { MoveFactory.Flail, },
		};
	}
}

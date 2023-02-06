using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Chandelure : Pokemon
	{
		public override string Name => "Chandelure";
		public override int Generation => 5;
		public override string PokedexEntry => "Being consumed in Chandelure's flame burns up the spirit, leaving the body behind.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Ghost, PokemonType.Fire };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.FlashFire, AbilityFactory.FlameBody, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Infiltrator;
		public override Stats BaseStats => new Stats() {
			HP = 60,
			Attack = 55,
			Defense = 90,
			SpecialAttack = 145,
			SpecialDefense = 90,
			Speed = 80
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.ConfuseRay, MoveFactory.Hex, MoveFactory.WillOWisp, MoveFactory.FireSpin, MoveFactory.NightShade, MoveFactory.Curse, MoveFactory.ShadowBall, MoveFactory.Inferno, MoveFactory.Imprison, MoveFactory.PainSplit, MoveFactory.Overheat, MoveFactory.Memento, MoveFactory.Astonish, MoveFactory.Smog, MoveFactory.Ember, MoveFactory.Minimize, },
		};
	}
}

using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Ninetales : Pokemon
	{
		public override string Name => "Ninetales";
		public override int Generation => 1;
		public override string PokedexEntry => "It has long been said that each of the nine tails embody an enchanted power. A long-lived Ninetales will have fur that shines like gold.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Fire };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.FlashFire, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Drought;
		public override Stats BaseStats => new Stats() {
			HP = 73,
			Attack = 76,
			Defense = 75,
			SpecialAttack = 81,
			SpecialDefense = 100,
			Speed = 100
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.NastyPlot, MoveFactory.Incinerate, MoveFactory.Spite, MoveFactory.Incinerate, MoveFactory.ConfuseRay, MoveFactory.WillOWisp, MoveFactory.Extrasensory, MoveFactory.Flamethrower, MoveFactory.Imprison, MoveFactory.FireSpin, MoveFactory.Safeguard, MoveFactory.Inferno, MoveFactory.Grudge, MoveFactory.FireBlast, MoveFactory.Ember, MoveFactory.TailWhip, MoveFactory.Disable, MoveFactory.QuickAttack, },
		};
	}
}

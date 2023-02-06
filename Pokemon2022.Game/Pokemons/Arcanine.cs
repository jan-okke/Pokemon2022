using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Arcanine : Pokemon
	{
		public override string Name => "Arcanine";
		public override int Generation => 1;
		public override string PokedexEntry => "This fleet-footed Pokémon is said to run over 6,200 miles in a single day and night. The fire that blazes wildly within its body is its source of power.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Fire };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Intimidate, AbilityFactory.FlashFire, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Justified;
		public override Stats BaseStats => new Stats() {
			HP = 90,
			Attack = 110,
			Defense = 80,
			SpecialAttack = 100,
			SpecialDefense = 80,
			Speed = 95
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[0] = new List<Move>() { MoveFactory.ExtremeSpeed, },
			[1] = new List<Move>() { MoveFactory.ExtremeSpeed, MoveFactory.BurnUp, MoveFactory.FlameWheel, MoveFactory.HelpingHand, MoveFactory.Agility, MoveFactory.FireFang, MoveFactory.Retaliate, MoveFactory.Crunch, MoveFactory.TakeDown, MoveFactory.Flamethrower, MoveFactory.Roar, MoveFactory.PlayRough, MoveFactory.Reversal, MoveFactory.FlareBlitz, MoveFactory.Ember, MoveFactory.Leer, MoveFactory.Howl, MoveFactory.Bite, },
		};
	}
}

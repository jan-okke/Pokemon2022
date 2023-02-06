using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Talonflame : Pokemon
	{
		public override string Name => "Talonflame";
		public override int Generation => 6;
		public override string PokedexEntry => "In the fever of an exciting battle, it showers embers from the gaps between its feathers and takes to the air.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Fire, PokemonType.Flying };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.FlameBody, };
		public override Ability AvailableHiddenAbility => AbilityFactory.GaleWings;
		public override Stats BaseStats => new Stats() {
			HP = 78,
			Attack = 81,
			Defense = 71,
			SpecialAttack = 74,
			SpecialDefense = 69,
			Speed = 126
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.FlameCharge, MoveFactory.FlareBlitz, MoveFactory.Feint, MoveFactory.Peck, MoveFactory.Growl, MoveFactory.QuickAttack, MoveFactory.Ember, },
			[15] = new List<Move>() { MoveFactory.Flail, },
			[22] = new List<Move>() { MoveFactory.Acrobatics, },
			[29] = new List<Move>() { MoveFactory.Agility, },
			[38] = new List<Move>() { MoveFactory.AerialAce, },
			[47] = new List<Move>() { MoveFactory.Tailwind, },
			[56] = new List<Move>() { MoveFactory.SteelWing, },
			[65] = new List<Move>() { MoveFactory.Roost, },
			[74] = new List<Move>() { MoveFactory.Fly, },
			[83] = new List<Move>() { MoveFactory.BraveBird, },
		};
	}
}

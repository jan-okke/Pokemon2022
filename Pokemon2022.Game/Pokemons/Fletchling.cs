using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Fletchling : Pokemon
	{
		public override string Name => "Fletchling";
		public override int Generation => 6;
		public override string PokedexEntry => "These friendly Pokémon send signals to one another with beautiful chirps and tail-feather movements.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Normal, PokemonType.Flying };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.BigPecks, };
		public override Ability AvailableHiddenAbility => AbilityFactory.GaleWings;
		public override Stats BaseStats => new Stats() {
			HP = 45,
			Attack = 50,
			Defense = 43,
			SpecialAttack = 40,
			SpecialDefense = 38,
			Speed = 62
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Peck, MoveFactory.Growl, },
			[5] = new List<Move>() { MoveFactory.QuickAttack, },
			[10] = new List<Move>() { MoveFactory.Ember, },
			[15] = new List<Move>() { MoveFactory.Flail, },
			[20] = new List<Move>() { MoveFactory.Acrobatics, },
			[25] = new List<Move>() { MoveFactory.Agility, },
			[30] = new List<Move>() { MoveFactory.AerialAce, },
			[35] = new List<Move>() { MoveFactory.Tailwind, },
			[40] = new List<Move>() { MoveFactory.SteelWing, },
			[45] = new List<Move>() { MoveFactory.Roost, },
			[50] = new List<Move>() { MoveFactory.Fly, },
		};
	}
}

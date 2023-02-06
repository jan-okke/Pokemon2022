using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Feebas : Pokemon
	{
		public override string Name => "Feebas";
		public override int Generation => 3;
		public override string PokedexEntry => "Feebas live in ponds that are heavily infested with weeds. Because of its hopelessly shabby appearance, it seems as if few trainers raise it.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Water };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.SwiftSwim, AbilityFactory.Oblivious, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Adaptability;
		public override Stats BaseStats => new Stats() {
			HP = 20,
			Attack = 15,
			Defense = 20,
			SpecialAttack = 10,
			SpecialDefense = 55,
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

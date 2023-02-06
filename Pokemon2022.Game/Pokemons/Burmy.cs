using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Burmy : Pokemon
	{
		public override string Name => "Burmy";
		public override int Generation => 4;
		public override string PokedexEntry => "To shelter itself from cold, wintry winds, it covers itself with a cloak made of twigs and leaves.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Bug };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.ShedSkin, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Overcoat;
		public override Stats BaseStats => new Stats() {
			HP = 40,
			Attack = 29,
			Defense = 45,
			SpecialAttack = 29,
			SpecialDefense = 45,
			Speed = 36
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Protect, },
			[10] = new List<Move>() { MoveFactory.Tackle, },
			[15] = new List<Move>() { MoveFactory.BugBite, },
			[20] = new List<Move>() { MoveFactory.StringShot, },
		};
	}
}

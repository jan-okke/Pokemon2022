using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Weedle : Pokemon
	{
		public override string Name => "Weedle";
		public override int Generation => 1;
		public override string PokedexEntry => "A Weedle has an extremely acute sense of smell. It distinguishes its favorite kinds of leaves from those it dislikes by sniffing with its big red proboscis (nose).";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Bug, PokemonType.Poison };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.ShieldDust, };
		public override Ability AvailableHiddenAbility => AbilityFactory.RunAway;
		public override Stats BaseStats => new Stats() {
			HP = 40,
			Attack = 35,
			Defense = 30,
			SpecialAttack = 20,
			SpecialDefense = 20,
			Speed = 50
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.PoisonSting, MoveFactory.StringShot, },
			[9] = new List<Move>() { MoveFactory.BugBite, },
		};
	}
}

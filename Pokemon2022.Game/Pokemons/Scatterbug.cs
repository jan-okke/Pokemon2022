using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Scatterbug : Pokemon
	{
		public override string Name => "Scatterbug";
		public override int Generation => 6;
		public override string PokedexEntry => "When under attack from bird Pokémon, it spews a poisonous black powder that causes paralysis on contact.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Bug };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.ShieldDust, AbilityFactory.CompoundEyes, };
		public override Ability AvailableHiddenAbility => AbilityFactory.FriendGuard;
		public override Stats BaseStats => new Stats() {
			HP = 38,
			Attack = 35,
			Defense = 40,
			SpecialAttack = 27,
			SpecialDefense = 25,
			Speed = 35
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Tackle, MoveFactory.StringShot, },
			[6] = new List<Move>() { MoveFactory.StunSpore, },
			[15] = new List<Move>() { MoveFactory.BugBite, },
		};
	}
}

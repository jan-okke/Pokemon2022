using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Spewpa : Pokemon
	{
		public override string Name => "Spewpa";
		public override int Generation => 6;
		public override string PokedexEntry => "It lives hidden within thicket shadows. When predators attack, it quickly bristles the fur covering its body in an effort to threaten them.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Bug };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.ShedSkin, };
		public override Ability AvailableHiddenAbility => AbilityFactory.FriendGuard;
		public override Stats BaseStats => new Stats() {
			HP = 45,
			Attack = 22,
			Defense = 60,
			SpecialAttack = 27,
			SpecialDefense = 30,
			Speed = 29
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[0] = new List<Move>() { MoveFactory.Protect, },
			[1] = new List<Move>() { MoveFactory.Protect, MoveFactory.Harden, },
		};
	}
}

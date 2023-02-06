using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Snom : Pokemon
	{
		public override string Name => "Snom";
		public override int Generation => 8;
		public override string PokedexEntry => "It spits out thread imbued with a frigid sort of energy and uses it to tie its body to branches, disguising itself as an icicle while it sleeps.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Ice, PokemonType.Bug };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.ShieldDust, };
		public override Ability AvailableHiddenAbility => AbilityFactory.IceScales;
		public override Stats BaseStats => new Stats() {
			HP = 30,
			Attack = 25,
			Defense = 35,
			SpecialAttack = 45,
			SpecialDefense = 30,
			Speed = 20
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.PowderSnow, MoveFactory.StruggleBug, },
		};
	}
}

using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Centiskorch : Pokemon
	{
		public override string Name => "Centiskorch";
		public override int Generation => 8;
		public override string PokedexEntry => "While its burning body is already dangerous on its own, this excessively hostile Pokémon also has large and very sharp fangs.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Fire, PokemonType.Bug };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.FlashFire, AbilityFactory.WhiteSmoke, };
		public override Ability AvailableHiddenAbility => AbilityFactory.FlameBody;
		public override Stats BaseStats => new Stats() {
			HP = 100,
			Attack = 115,
			Defense = 65,
			SpecialAttack = 90,
			SpecialDefense = 90,
			Speed = 65
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Inferno, MoveFactory.Ember, MoveFactory.Smokescreen, MoveFactory.Wrap, MoveFactory.Bite, },
			[15] = new List<Move>() { MoveFactory.FlameWheel, },
			[20] = new List<Move>() { MoveFactory.BugBite, },
			[25] = new List<Move>() { MoveFactory.Coil, },
			[32] = new List<Move>() { MoveFactory.Slam, },
			[39] = new List<Move>() { MoveFactory.FireSpin, },
			[46] = new List<Move>() { MoveFactory.Crunch, },
			[53] = new List<Move>() { MoveFactory.FireLash, },
			[60] = new List<Move>() { MoveFactory.Lunge, },
			[67] = new List<Move>() { MoveFactory.BurnUp, },
		};
	}
}

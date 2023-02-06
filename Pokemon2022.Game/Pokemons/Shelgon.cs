using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Shelgon : Pokemon
	{
		public override string Name => "Shelgon";
		public override int Generation => 3;
		public override string PokedexEntry => "It hardly eats while it awaits evolution. It becomes hardier by enduring hunger. Its shell peels off the instant it begins to evolve.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Dragon };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.RockHead, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Overcoat;
		public override Stats BaseStats => new Stats() {
			HP = 65,
			Attack = 95,
			Defense = 100,
			SpecialAttack = 60,
			SpecialDefense = 50,
			Speed = 50
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[0] = new List<Move>() { MoveFactory.Protect, },
			[1] = new List<Move>() { MoveFactory.Protect, MoveFactory.Ember, MoveFactory.Leer, MoveFactory.Bite, MoveFactory.DragonBreath, },
			[15] = new List<Move>() { MoveFactory.Headbutt, },
			[20] = new List<Move>() { MoveFactory.ScaryFace, },
			[25] = new List<Move>() { MoveFactory.Crunch, },
			[33] = new List<Move>() { MoveFactory.DragonClaw, },
			[39] = new List<Move>() { MoveFactory.ZenHeadbutt, },
			[46] = new List<Move>() { MoveFactory.FocusEnergy, },
			[53] = new List<Move>() { MoveFactory.Flamethrower, },
			[60] = new List<Move>() { MoveFactory.Outrage, },
			[67] = new List<Move>() { MoveFactory.DoubleEdge, },
		};
	}
}

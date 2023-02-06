using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Fraxure : Pokemon
	{
		public override string Name => "Fraxure";
		public override int Generation => 5;
		public override string PokedexEntry => "Their tusks can shatter rocks. Territory battles between Fraxure can be intensely violent.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Dragon };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Rivalry, AbilityFactory.MoldBreaker, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Unnerve;
		public override Stats BaseStats => new Stats() {
			HP = 66,
			Attack = 117,
			Defense = 70,
			SpecialAttack = 40,
			SpecialDefense = 50,
			Speed = 67
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Scratch, MoveFactory.Leer, MoveFactory.Bite, MoveFactory.FalseSwipe, },
			[9] = new List<Move>() { MoveFactory.Assurance, },
			[12] = new List<Move>() { MoveFactory.Taunt, },
			[15] = new List<Move>() { MoveFactory.Slash, },
			[18] = new List<Move>() { MoveFactory.DragonClaw, },
			[21] = new List<Move>() { MoveFactory.ScaryFace, },
			[24] = new List<Move>() { MoveFactory.Crunch, },
			[27] = new List<Move>() { MoveFactory.DragonDance, },
			[30] = new List<Move>() { MoveFactory.DualChop, },
			[33] = new List<Move>() { MoveFactory.LaserFocus, },
			[36] = new List<Move>() { MoveFactory.DragonPulse, },
			[41] = new List<Move>() { MoveFactory.SwordsDance, },
			[46] = new List<Move>() { MoveFactory.Outrage, },
			[51] = new List<Move>() { MoveFactory.Guillotine, },
			[56] = new List<Move>() { MoveFactory.GigaImpact, },
		};
	}
}

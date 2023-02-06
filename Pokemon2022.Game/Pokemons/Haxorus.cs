using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Haxorus : Pokemon
	{
		public override string Name => "Haxorus";
		public override int Generation => 5;
		public override string PokedexEntry => "Their sturdy tusks will stay sharp even if used to cut steel beams. These Pokémon are covered in hard armor.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Dragon };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Rivalry, AbilityFactory.MoldBreaker, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Unnerve;
		public override Stats BaseStats => new Stats() {
			HP = 76,
			Attack = 147,
			Defense = 90,
			SpecialAttack = 60,
			SpecialDefense = 70,
			Speed = 97
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
			[53] = new List<Move>() { MoveFactory.Guillotine, },
			[60] = new List<Move>() { MoveFactory.GigaImpact, },
		};
	}
}

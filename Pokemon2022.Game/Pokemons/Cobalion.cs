using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Cobalion : Pokemon
	{
		public override string Name => "Cobalion";
		public override int Generation => 5;
		public override string PokedexEntry => "It has a body and heart of steel. Its glare is sufficient to make even an unruly Pokémon obey it.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Steel, PokemonType.Fighting };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Justified, };
		public override Stats BaseStats => new Stats() {
			HP = 91,
			Attack = 90,
			Defense = 129,
			SpecialAttack = 90,
			SpecialDefense = 72,
			Speed = 108
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.QuickAttack, MoveFactory.Leer, MoveFactory.HelpingHand, MoveFactory.WorkUp, },
			[7] = new List<Move>() { MoveFactory.MetalClaw, },
			[14] = new List<Move>() { MoveFactory.QuickGuard, },
			[21] = new List<Move>() { MoveFactory.DoubleKick, },
			[28] = new List<Move>() { MoveFactory.Retaliate, },
			[35] = new List<Move>() { MoveFactory.MetalBurst, },
			[42] = new List<Move>() { MoveFactory.TakeDown, },
			[49] = new List<Move>() { MoveFactory.SacredSword, },
			[56] = new List<Move>() { MoveFactory.SwordsDance, },
			[63] = new List<Move>() { MoveFactory.IronHead, },
			[70] = new List<Move>() { MoveFactory.CloseCombat, },
		};
	}
}

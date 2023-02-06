using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Virizion : Pokemon
	{
		public override string Name => "Virizion";
		public override int Generation => 5;
		public override string PokedexEntry => "Its head sprouts horns as sharp as blades. Using whirlwind-like movements, it confounds and swiftly cuts opponents.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Grass, PokemonType.Fighting };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Justified, };
		public override Stats BaseStats => new Stats() {
			HP = 91,
			Attack = 90,
			Defense = 72,
			SpecialAttack = 90,
			SpecialDefense = 129,
			Speed = 108
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.QuickAttack, MoveFactory.Leer, MoveFactory.HelpingHand, MoveFactory.WorkUp, },
			[7] = new List<Move>() { MoveFactory.MagicalLeaf, },
			[14] = new List<Move>() { MoveFactory.QuickGuard, },
			[21] = new List<Move>() { MoveFactory.DoubleKick, },
			[28] = new List<Move>() { MoveFactory.Retaliate, },
			[35] = new List<Move>() { MoveFactory.GigaDrain, },
			[42] = new List<Move>() { MoveFactory.TakeDown, },
			[49] = new List<Move>() { MoveFactory.SacredSword, },
			[56] = new List<Move>() { MoveFactory.SwordsDance, },
			[63] = new List<Move>() { MoveFactory.LeafBlade, },
			[70] = new List<Move>() { MoveFactory.CloseCombat, },
		};
	}
}

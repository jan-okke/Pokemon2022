using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Terrakion : Pokemon
	{
		public override string Name => "Terrakion";
		public override int Generation => 5;
		public override string PokedexEntry => "Its charge is strong enough to break through a giant castle wall in one blow. This Pokémon is spoken of in legends.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Rock, PokemonType.Fighting };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Justified, };
		public override Stats BaseStats => new Stats() {
			HP = 91,
			Attack = 129,
			Defense = 90,
			SpecialAttack = 72,
			SpecialDefense = 90,
			Speed = 108
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.QuickAttack, MoveFactory.Leer, MoveFactory.HelpingHand, MoveFactory.WorkUp, },
			[7] = new List<Move>() { MoveFactory.SmackDown, },
			[14] = new List<Move>() { MoveFactory.QuickGuard, },
			[21] = new List<Move>() { MoveFactory.DoubleKick, },
			[28] = new List<Move>() { MoveFactory.Retaliate, },
			[35] = new List<Move>() { MoveFactory.RockSlide, },
			[42] = new List<Move>() { MoveFactory.TakeDown, },
			[49] = new List<Move>() { MoveFactory.SacredSword, },
			[56] = new List<Move>() { MoveFactory.SwordsDance, },
			[63] = new List<Move>() { MoveFactory.StoneEdge, },
			[70] = new List<Move>() { MoveFactory.CloseCombat, },
		};
	}
}

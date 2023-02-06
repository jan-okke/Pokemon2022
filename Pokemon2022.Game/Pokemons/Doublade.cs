using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Doublade : Pokemon
	{
		public override string Name => "Doublade";
		public override int Generation => 6;
		public override string PokedexEntry => "The complex attack patterns of its two swords are unstoppable, even for an opponent greatly accomplished at swordplay.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Steel, PokemonType.Ghost };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.NoGuard, };
		public override Stats BaseStats => new Stats() {
			HP = 59,
			Attack = 110,
			Defense = 150,
			SpecialAttack = 45,
			SpecialDefense = 49,
			Speed = 35
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Tackle, MoveFactory.FuryCutter, MoveFactory.ShadowSneak, MoveFactory.Autotomize, },
			[12] = new List<Move>() { MoveFactory.AerialAce, },
			[16] = new List<Move>() { MoveFactory.MetalSound, },
			[20] = new List<Move>() { MoveFactory.Slash, },
			[24] = new List<Move>() { MoveFactory.NightSlash, },
			[28] = new List<Move>() { MoveFactory.Retaliate, },
			[32] = new List<Move>() { MoveFactory.IronDefense, },
			[38] = new List<Move>() { MoveFactory.IronHead, },
			[44] = new List<Move>() { MoveFactory.PowerTrick, },
			[50] = new List<Move>() { MoveFactory.SwordsDance, },
			[56] = new List<Move>() { MoveFactory.SacredSword, },
		};
	}
}

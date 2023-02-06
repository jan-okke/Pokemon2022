using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Honedge : Pokemon
	{
		public override string Name => "Honedge";
		public override int Generation => 6;
		public override string PokedexEntry => "Apparently this Pokémon is born when a departed spirit inhabits a sword. It attaches itself to people and drinks their life force.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Steel, PokemonType.Ghost };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.NoGuard, };
		public override Stats BaseStats => new Stats() {
			HP = 45,
			Attack = 80,
			Defense = 100,
			SpecialAttack = 35,
			SpecialDefense = 37,
			Speed = 28
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Tackle, MoveFactory.FuryCutter, },
			[4] = new List<Move>() { MoveFactory.ShadowSneak, },
			[8] = new List<Move>() { MoveFactory.Autotomize, },
			[12] = new List<Move>() { MoveFactory.AerialAce, },
			[16] = new List<Move>() { MoveFactory.MetalSound, },
			[20] = new List<Move>() { MoveFactory.Slash, },
			[24] = new List<Move>() { MoveFactory.NightSlash, },
			[28] = new List<Move>() { MoveFactory.Retaliate, },
			[32] = new List<Move>() { MoveFactory.IronDefense, },
			[36] = new List<Move>() { MoveFactory.IronHead, },
			[40] = new List<Move>() { MoveFactory.PowerTrick, },
			[44] = new List<Move>() { MoveFactory.SwordsDance, },
			[48] = new List<Move>() { MoveFactory.SacredSword, },
		};
	}
}

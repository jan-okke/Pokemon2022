using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Karrablast : Pokemon
	{
		public override string Name => "Karrablast";
		public override int Generation => 5;
		public override string PokedexEntry => "When they feel threatened, they spit an acidic liquid to drive attackers away. This Pokémon targets Shelmet.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Bug };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Swarm, AbilityFactory.ShedSkin, };
		public override Ability AvailableHiddenAbility => AbilityFactory.NoGuard;
		public override Stats BaseStats => new Stats() {
			HP = 50,
			Attack = 75,
			Defense = 45,
			SpecialAttack = 40,
			SpecialDefense = 45,
			Speed = 60
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Peck, MoveFactory.Leer, },
			[4] = new List<Move>() { MoveFactory.FuryCutter, },
			[8] = new List<Move>() { MoveFactory.Endure, },
			[12] = new List<Move>() { MoveFactory.FalseSwipe, },
			[16] = new List<Move>() { MoveFactory.AcidSpray, },
			[20] = new List<Move>() { MoveFactory.Headbutt, },
			[24] = new List<Move>() { MoveFactory.Flail, },
			[28] = new List<Move>() { MoveFactory.ScaryFace, },
			[32] = new List<Move>() { MoveFactory.XScissor, },
			[36] = new List<Move>() { MoveFactory.SwordsDance, },
			[40] = new List<Move>() { MoveFactory.TakeDown, },
			[44] = new List<Move>() { MoveFactory.BugBuzz, },
			[48] = new List<Move>() { MoveFactory.DoubleEdge, },
		};
	}
}

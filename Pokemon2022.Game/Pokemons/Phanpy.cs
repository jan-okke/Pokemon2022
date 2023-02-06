using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Phanpy : Pokemon
	{
		public override string Name => "Phanpy";
		public override int Generation => 2;
		public override string PokedexEntry => "Phanpy's big ears serve as broad fans. When it becomes hot, it flaps the ears busily to cool down. Even the young are very strong.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Ground };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Pickup, };
		public override Ability AvailableHiddenAbility => AbilityFactory.SandVeil;
		public override Stats BaseStats => new Stats() {
			HP = 90,
			Attack = 60,
			Defense = 60,
			SpecialAttack = 40,
			SpecialDefense = 40,
			Speed = 40
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Tackle, MoveFactory.Growl, MoveFactory.DefenseCurl, },
			[6] = new List<Move>() { MoveFactory.Flail, },
			[10] = new List<Move>() { MoveFactory.Rollout, },
			[15] = new List<Move>() { MoveFactory.Bulldoze, },
			[19] = new List<Move>() { MoveFactory.Endure, },
			[24] = new List<Move>() { MoveFactory.Slam, },
			[28] = new List<Move>() { MoveFactory.TakeDown, },
			[33] = new List<Move>() { MoveFactory.Charm, },
			[37] = new List<Move>() { MoveFactory.LastResort, },
			[42] = new List<Move>() { MoveFactory.DoubleEdge, },
		};
	}
}

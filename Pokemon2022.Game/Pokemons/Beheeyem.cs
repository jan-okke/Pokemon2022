using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Beheeyem : Pokemon
	{
		public override string Name => "Beheeyem";
		public override int Generation => 5;
		public override string PokedexEntry => "It uses psychic power to control an opponent's brain and tamper with its memories.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Psychic };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Telepathy, AbilityFactory.Synchronize, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Analytic;
		public override Stats BaseStats => new Stats() {
			HP = 75,
			Attack = 75,
			Defense = 75,
			SpecialAttack = 125,
			SpecialDefense = 95,
			Speed = 40
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.PsychicTerrain, MoveFactory.Confusion, MoveFactory.Growl, MoveFactory.Imprison, MoveFactory.Teleport, },
			[18] = new List<Move>() { MoveFactory.Psybeam, },
			[24] = new List<Move>() { MoveFactory.PowerSplit, MoveFactory.GuardSplit, },
			[30] = new List<Move>() { MoveFactory.Headbutt, },
			[36] = new List<Move>() { MoveFactory.ZenHeadbutt, },
			[45] = new List<Move>() { MoveFactory.Recover, },
			[52] = new List<Move>() { MoveFactory.CalmMind, },
			[60] = new List<Move>() { MoveFactory.WonderRoom, },
			[68] = new List<Move>() { MoveFactory.Psychic, },
		};
	}
}

using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Elgyem : Pokemon
	{
		public override string Name => "Elgyem";
		public override int Generation => 5;
		public override string PokedexEntry => "This Pokémon had never been seen until it appeared from far in the desert 50 years ago.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Psychic };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Telepathy, AbilityFactory.Synchronize, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Analytic;
		public override Stats BaseStats => new Stats() {
			HP = 55,
			Attack = 55,
			Defense = 55,
			SpecialAttack = 85,
			SpecialDefense = 55,
			Speed = 30
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Confusion, MoveFactory.Growl, },
			[6] = new List<Move>() { MoveFactory.Imprison, },
			[12] = new List<Move>() { MoveFactory.Teleport, },
			[18] = new List<Move>() { MoveFactory.Psybeam, },
			[24] = new List<Move>() { MoveFactory.PowerSplit, MoveFactory.GuardSplit, },
			[30] = new List<Move>() { MoveFactory.Headbutt, },
			[36] = new List<Move>() { MoveFactory.ZenHeadbutt, },
			[43] = new List<Move>() { MoveFactory.Recover, },
			[48] = new List<Move>() { MoveFactory.CalmMind, },
			[54] = new List<Move>() { MoveFactory.WonderRoom, },
			[60] = new List<Move>() { MoveFactory.Psychic, },
		};
	}
}

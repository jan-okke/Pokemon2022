using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Meditite : Pokemon
	{
		public override string Name => "Meditite";
		public override int Generation => 3;
		public override string PokedexEntry => "It continually meditates for hours every day. As a result of rigorous and dedicated yoga training, it has tempered its spiritual power so much it can fly.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Fighting, PokemonType.Psychic };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.PurePower, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Telepathy;
		public override Stats BaseStats => new Stats() {
			HP = 30,
			Attack = 40,
			Defense = 55,
			SpecialAttack = 40,
			SpecialDefense = 55,
			Speed = 60
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Pound, },
			[4] = new List<Move>() { MoveFactory.LowKick, },
			[7] = new List<Move>() { MoveFactory.Confusion, },
			[9] = new List<Move>() { MoveFactory.Detect, },
			[12] = new List<Move>() { MoveFactory.Endure, },
			[15] = new List<Move>() { MoveFactory.Feint, },
			[17] = new List<Move>() { MoveFactory.ForcePalm, },
			[20] = new List<Move>() { MoveFactory.Psybeam, },
			[23] = new List<Move>() { MoveFactory.CalmMind, },
			[25] = new List<Move>() { MoveFactory.MindReader, },
			[28] = new List<Move>() { MoveFactory.HighJumpKick, },
			[31] = new List<Move>() { MoveFactory.PsychUp, },
			[33] = new List<Move>() { MoveFactory.Acupressure, },
			[36] = new List<Move>() { MoveFactory.PowerTrick, },
			[39] = new List<Move>() { MoveFactory.Reversal, },
			[41] = new List<Move>() { MoveFactory.Recover, },
			[44] = new List<Move>() { MoveFactory.Counter, },
		};
	}
}

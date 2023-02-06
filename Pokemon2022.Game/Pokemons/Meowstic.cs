using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Meowstic : Pokemon
	{
		public override string Name => "Meowstic";
		public override int Generation => 6;
		public override string PokedexEntry => "Revealing the eyelike patterns on the insides of its ears will unleash its psychic powers. It normally keeps the patterns hidden, however.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Psychic };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.KeenEye, AbilityFactory.Infiltrator, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Prankster;
		public override Stats BaseStats => new Stats() {
			HP = 74,
			Attack = 48,
			Defense = 76,
			SpecialAttack = 83,
			SpecialDefense = 81,
			Speed = 104
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.MeanLook, MoveFactory.Scratch, MoveFactory.Leer, MoveFactory.FakeOut, MoveFactory.DisarmingVoice, },
			[9] = new List<Move>() { MoveFactory.Confusion, },
			[12] = new List<Move>() { MoveFactory.HelpingHand, },
			[15] = new List<Move>() { MoveFactory.Charm, },
			[18] = new List<Move>() { MoveFactory.Covet, },
			[21] = new List<Move>() { MoveFactory.Psybeam, },
			[24] = new List<Move>() { MoveFactory.SuckerPunch, },
			[29] = new List<Move>() { MoveFactory.RolePlay, },
			[34] = new List<Move>() { MoveFactory.LightScreen, MoveFactory.Reflect, },
			[39] = new List<Move>() { MoveFactory.Psyshock, },
			[44] = new List<Move>() { MoveFactory.Imprison, },
			[49] = new List<Move>() { MoveFactory.QuickGuard, },
			[54] = new List<Move>() { MoveFactory.Psychic, },
			[59] = new List<Move>() { MoveFactory.MistyTerrain, },
		};
	}
}

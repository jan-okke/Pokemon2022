using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Gallade : Pokemon
	{
		public override string Name => "Gallade";
		public override int Generation => 4;
		public override string PokedexEntry => "A master of courtesy and swordsmanship, it fights using extending swords on its elbows.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Psychic, PokemonType.Fighting };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Steadfast, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Justified;
		public override Stats BaseStats => new Stats() {
			HP = 68,
			Attack = 125,
			Defense = 65,
			SpecialAttack = 65,
			SpecialDefense = 115,
			Speed = 80
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[0] = new List<Move>() { MoveFactory.Slash, },
			[1] = new List<Move>() { MoveFactory.Slash, MoveFactory.NightSlash, MoveFactory.Growl, MoveFactory.DisarmingVoice, MoveFactory.Hypnosis, MoveFactory.DrainingKiss, MoveFactory.Imprison, MoveFactory.Psybeam, MoveFactory.LifeDew, MoveFactory.Charm, MoveFactory.CalmMind, MoveFactory.Psychic, MoveFactory.DreamEater, MoveFactory.FutureSight, MoveFactory.Leer, MoveFactory.FuryCutter, MoveFactory.DoubleTeam, MoveFactory.Confusion, },
			[9] = new List<Move>() { MoveFactory.HelpingHand, },
			[12] = new List<Move>() { MoveFactory.Feint, },
			[15] = new List<Move>() { MoveFactory.Teleport, },
			[18] = new List<Move>() { MoveFactory.AerialAce, },
			[23] = new List<Move>() { MoveFactory.FalseSwipe, },
			[28] = new List<Move>() { MoveFactory.Protect, },
			[35] = new List<Move>() { MoveFactory.SwordsDance, },
			[42] = new List<Move>() { MoveFactory.PsychoCut, },
			[49] = new List<Move>() { MoveFactory.HealPulse, },
			[56] = new List<Move>() { MoveFactory.QuickGuard, MoveFactory.WideGuard, },
			[63] = new List<Move>() { MoveFactory.CloseCombat, },
		};
	}
}

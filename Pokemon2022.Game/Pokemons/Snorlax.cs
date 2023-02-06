using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Snorlax : Pokemon
	{
		public override string Name => "Snorlax";
		public override int Generation => 1;
		public override string PokedexEntry => "Snorlax's typical day consists of nothing more than eating and sleeping. It is such a docile Pokémon that there are children who use its big belly as a place to play.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Normal };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Immunity, AbilityFactory.ThickFat, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Gluttony;
		public override Stats BaseStats => new Stats() {
			HP = 160,
			Attack = 110,
			Defense = 65,
			SpecialAttack = 65,
			SpecialDefense = 110,
			Speed = 30
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Recycle, MoveFactory.Covet, MoveFactory.Stockpile, MoveFactory.Swallow, MoveFactory.Screech, MoveFactory.Fling, MoveFactory.Metronome, MoveFactory.Flail, MoveFactory.LastResort, MoveFactory.Lick, MoveFactory.Tackle, MoveFactory.DefenseCurl, MoveFactory.Block, },
			[12] = new List<Move>() { MoveFactory.Yawn, },
			[16] = new List<Move>() { MoveFactory.Bite, },
			[20] = new List<Move>() { MoveFactory.Rest, MoveFactory.Snore, MoveFactory.SleepTalk, },
			[24] = new List<Move>() { MoveFactory.Crunch, },
			[28] = new List<Move>() { MoveFactory.BodySlam, },
			[32] = new List<Move>() { MoveFactory.HeavySlam, },
			[36] = new List<Move>() { MoveFactory.Amnesia, },
			[40] = new List<Move>() { MoveFactory.HighHorsepower, },
			[44] = new List<Move>() { MoveFactory.HammerArm, },
			[48] = new List<Move>() { MoveFactory.BellyDrum, },
			[52] = new List<Move>() { MoveFactory.Belch, },
			[56] = new List<Move>() { MoveFactory.GigaImpact, },
		};
	}
}

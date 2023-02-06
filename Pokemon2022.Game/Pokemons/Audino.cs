using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Audino : Pokemon
	{
		public override string Name => "Audino";
		public override int Generation => 5;
		public override string PokedexEntry => "Its auditory sense is astounding. It has a radar-like ability to understand its surrounding through slight sounds.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Normal };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Healer, AbilityFactory.Regenerator, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Klutz;
		public override Stats BaseStats => new Stats() {
			HP = 103,
			Attack = 60,
			Defense = 86,
			SpecialAttack = 60,
			SpecialDefense = 86,
			Speed = 50
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Pound, MoveFactory.PlayNice, },
			[4] = new List<Move>() { MoveFactory.DisarmingVoice, },
			[9] = new List<Move>() { MoveFactory.BabyDollEyes, },
			[12] = new List<Move>() { MoveFactory.HelpingHand, },
			[16] = new List<Move>() { MoveFactory.Growl, },
			[20] = new List<Move>() { MoveFactory.ZenHeadbutt, },
			[24] = new List<Move>() { MoveFactory.LifeDew, },
			[28] = new List<Move>() { MoveFactory.AfterYou, },
			[32] = new List<Move>() { MoveFactory.TakeDown, },
			[36] = new List<Move>() { MoveFactory.SimpleBeam, },
			[40] = new List<Move>() { MoveFactory.HyperVoice, },
			[44] = new List<Move>() { MoveFactory.HealPulse, },
			[48] = new List<Move>() { MoveFactory.DoubleEdge, },
			[52] = new List<Move>() { MoveFactory.Entrainment, },
			[56] = new List<Move>() { MoveFactory.MistyTerrain, },
			[60] = new List<Move>() { MoveFactory.LastResort, },
		};
	}
}

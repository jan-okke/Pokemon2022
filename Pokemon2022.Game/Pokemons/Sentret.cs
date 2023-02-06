using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Sentret : Pokemon
	{
		public override string Name => "Sentret";
		public override int Generation => 2;
		public override string PokedexEntry => "They take turns standing guard when it is time to sleep. The sentry awakens the others if it senses danger. If one gets separated, it turns sleepless with fear.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Normal };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.RunAway, AbilityFactory.KeenEye, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Frisk;
		public override Stats BaseStats => new Stats() {
			HP = 35,
			Attack = 46,
			Defense = 34,
			SpecialAttack = 35,
			SpecialDefense = 45,
			Speed = 20
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Scratch, MoveFactory.Growl, },
			[4] = new List<Move>() { MoveFactory.DefenseCurl, },
			[7] = new List<Move>() { MoveFactory.QuickAttack, },
			[13] = new List<Move>() { MoveFactory.FurySwipes, },
			[16] = new List<Move>() { MoveFactory.HelpingHand, },
			[19] = new List<Move>() { MoveFactory.FollowMe, },
			[25] = new List<Move>() { MoveFactory.Slam, },
			[28] = new List<Move>() { MoveFactory.Rest, },
			[31] = new List<Move>() { MoveFactory.SuckerPunch, },
			[36] = new List<Move>() { MoveFactory.Amnesia, },
			[39] = new List<Move>() { MoveFactory.BatonPass, },
			[42] = new List<Move>() { MoveFactory.Reversal, },
			[47] = new List<Move>() { MoveFactory.HyperVoice, },
		};
	}
}

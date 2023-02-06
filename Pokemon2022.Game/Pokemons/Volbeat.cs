using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Volbeat : Pokemon
	{
		public override string Name => "Volbeat";
		public override int Generation => 3;
		public override string PokedexEntry => "With their taillights lit, Volbeat fly in a swarm, drawing geometric designs in the night sky. They move their nests if their pond water becomes dirty.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Bug };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Illuminate, AbilityFactory.Swarm, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Prankster;
		public override Stats BaseStats => new Stats() {
			HP = 65,
			Attack = 73,
			Defense = 75,
			SpecialAttack = 47,
			SpecialDefense = 85,
			Speed = 85
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.PlayNice, MoveFactory.Tackle, },
			[5] = new List<Move>() { MoveFactory.DoubleTeam, },
			[8] = new List<Move>() { MoveFactory.ConfuseRay, },
			[12] = new List<Move>() { MoveFactory.QuickAttack, },
			[15] = new List<Move>() { MoveFactory.StruggleBug, },
			[19] = new List<Move>() { MoveFactory.Moonlight, },
			[22] = new List<Move>() { MoveFactory.TailGlow, },
			[26] = new List<Move>() { MoveFactory.Encore, },
			[29] = new List<Move>() { MoveFactory.Protect, },
			[33] = new List<Move>() { MoveFactory.ZenHeadbutt, },
			[36] = new List<Move>() { MoveFactory.HelpingHand, },
			[40] = new List<Move>() { MoveFactory.BugBuzz, },
			[43] = new List<Move>() { MoveFactory.PlayRough, },
			[47] = new List<Move>() { MoveFactory.DoubleEdge, },
			[50] = new List<Move>() { MoveFactory.Infestation, },
		};
	}
}

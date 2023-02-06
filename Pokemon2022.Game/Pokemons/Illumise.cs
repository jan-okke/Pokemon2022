using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Illumise : Pokemon
	{
		public override string Name => "Illumise";
		public override int Generation => 3;
		public override string PokedexEntry => "A nocturnal Pokémon that becomes active upon nightfall. It leads a Volbeat swarm to draw patterns in the night sky. Over 200 different patterns have been seen.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Bug };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Oblivious, AbilityFactory.TintedLens, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Prankster;
		public override Stats BaseStats => new Stats() {
			HP = 65,
			Attack = 47,
			Defense = 75,
			SpecialAttack = 73,
			SpecialDefense = 85,
			Speed = 85
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.PlayNice, MoveFactory.Tackle, },
			[5] = new List<Move>() { MoveFactory.SweetScent, },
			[9] = new List<Move>() { MoveFactory.Charm, },
			[12] = new List<Move>() { MoveFactory.QuickAttack, },
			[15] = new List<Move>() { MoveFactory.StruggleBug, },
			[19] = new List<Move>() { MoveFactory.Moonlight, },
			[22] = new List<Move>() { MoveFactory.Wish, },
			[26] = new List<Move>() { MoveFactory.Encore, },
			[29] = new List<Move>() { MoveFactory.Flatter, },
			[33] = new List<Move>() { MoveFactory.ZenHeadbutt, },
			[36] = new List<Move>() { MoveFactory.HelpingHand, },
			[40] = new List<Move>() { MoveFactory.BugBuzz, },
			[43] = new List<Move>() { MoveFactory.PlayRough, },
			[47] = new List<Move>() { MoveFactory.Covet, },
			[50] = new List<Move>() { MoveFactory.Infestation, },
		};
	}
}

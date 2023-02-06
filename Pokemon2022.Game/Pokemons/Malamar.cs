using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Malamar : Pokemon
	{
		public override string Name => "Malamar";
		public override int Generation => 6;
		public override string PokedexEntry => "It lures prey close with hypnotic motions, then wraps its tentacles around it before finishing it off with digestive fluids.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Dark, PokemonType.Psychic };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Contrary, AbilityFactory.SuctionCups, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Infiltrator;
		public override Stats BaseStats => new Stats() {
			HP = 86,
			Attack = 92,
			Defense = 88,
			SpecialAttack = 68,
			SpecialDefense = 75,
			Speed = 73
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Reversal, MoveFactory.Peck, MoveFactory.Tackle, MoveFactory.Hypnosis, MoveFactory.Wrap, },
			[9] = new List<Move>() { MoveFactory.Payback, },
			[12] = new List<Move>() { MoveFactory.Pluck, },
			[15] = new List<Move>() { MoveFactory.Psybeam, },
			[18] = new List<Move>() { MoveFactory.Swagger, },
			[21] = new List<Move>() { MoveFactory.Slash, },
			[24] = new List<Move>() { MoveFactory.NightSlash, },
			[27] = new List<Move>() { MoveFactory.PsychoCut, },
			[33] = new List<Move>() { MoveFactory.Switcheroo, },
			[37] = new List<Move>() { MoveFactory.FoulPlay, },
			[42] = new List<Move>() { MoveFactory.TopsyTurvy, },
			[47] = new List<Move>() { MoveFactory.Superpower, },
		};
	}
}

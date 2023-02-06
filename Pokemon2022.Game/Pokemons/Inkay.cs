using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Inkay : Pokemon
	{
		public override string Name => "Inkay";
		public override int Generation => 6;
		public override string PokedexEntry => "It flashes the light-emitting spots on its body, which drains its opponent's will to fight. It takes the opportunity to scuttle away and hide.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Dark, PokemonType.Psychic };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Contrary, AbilityFactory.SuctionCups, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Infiltrator;
		public override Stats BaseStats => new Stats() {
			HP = 53,
			Attack = 54,
			Defense = 53,
			SpecialAttack = 37,
			SpecialDefense = 46,
			Speed = 45
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Peck, MoveFactory.Tackle, },
			[3] = new List<Move>() { MoveFactory.Hypnosis, },
			[6] = new List<Move>() { MoveFactory.Wrap, },
			[9] = new List<Move>() { MoveFactory.Payback, },
			[12] = new List<Move>() { MoveFactory.Pluck, },
			[15] = new List<Move>() { MoveFactory.Psybeam, },
			[18] = new List<Move>() { MoveFactory.Swagger, },
			[21] = new List<Move>() { MoveFactory.Slash, },
			[24] = new List<Move>() { MoveFactory.NightSlash, },
			[27] = new List<Move>() { MoveFactory.PsychoCut, },
			[31] = new List<Move>() { MoveFactory.Switcheroo, },
			[33] = new List<Move>() { MoveFactory.FoulPlay, },
			[36] = new List<Move>() { MoveFactory.TopsyTurvy, },
			[39] = new List<Move>() { MoveFactory.Superpower, },
		};
	}
}

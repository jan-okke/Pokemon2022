using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Gothita : Pokemon
	{
		public override string Name => "Gothita";
		public override int Generation => 5;
		public override string PokedexEntry => "They intently observe both Trainers and Pokémon. Apparently, they are looking at something that only Gothita can see.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Psychic };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Frisk, AbilityFactory.Competitive, };
		public override Ability AvailableHiddenAbility => AbilityFactory.ShadowTag;
		public override Stats BaseStats => new Stats() {
			HP = 45,
			Attack = 30,
			Defense = 50,
			SpecialAttack = 55,
			SpecialDefense = 65,
			Speed = 45
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Pound, MoveFactory.Confusion, },
			[4] = new List<Move>() { MoveFactory.PlayNice, },
			[8] = new List<Move>() { MoveFactory.Tickle, },
			[12] = new List<Move>() { MoveFactory.Psybeam, },
			[16] = new List<Move>() { MoveFactory.Charm, },
			[20] = new List<Move>() { MoveFactory.Psyshock, },
			[24] = new List<Move>() { MoveFactory.Hypnosis, },
			[28] = new List<Move>() { MoveFactory.FakeTears, },
			[33] = new List<Move>() { MoveFactory.PsychUp, },
			[36] = new List<Move>() { MoveFactory.Psychic, },
			[40] = new List<Move>() { MoveFactory.Flatter, },
			[44] = new List<Move>() { MoveFactory.FutureSight, },
			[48] = new List<Move>() { MoveFactory.MagicRoom, },
		};
	}
}

using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Gothitelle : Pokemon
	{
		public override string Name => "Gothitelle";
		public override int Generation => 5;
		public override string PokedexEntry => "They can predict the future from the placement and movement of the stars. They can see Trainers' life spans.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Psychic };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Frisk, AbilityFactory.Competitive, };
		public override Ability AvailableHiddenAbility => AbilityFactory.ShadowTag;
		public override Stats BaseStats => new Stats() {
			HP = 70,
			Attack = 55,
			Defense = 95,
			SpecialAttack = 95,
			SpecialDefense = 110,
			Speed = 65
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Pound, MoveFactory.Confusion, MoveFactory.PlayNice, MoveFactory.Tickle, },
			[12] = new List<Move>() { MoveFactory.Psybeam, },
			[16] = new List<Move>() { MoveFactory.Charm, },
			[20] = new List<Move>() { MoveFactory.Psyshock, },
			[24] = new List<Move>() { MoveFactory.Hypnosis, },
			[28] = new List<Move>() { MoveFactory.FakeTears, },
			[35] = new List<Move>() { MoveFactory.PsychUp, },
			[40] = new List<Move>() { MoveFactory.Psychic, },
			[48] = new List<Move>() { MoveFactory.Flatter, },
			[56] = new List<Move>() { MoveFactory.FutureSight, },
			[64] = new List<Move>() { MoveFactory.MagicRoom, },
		};
	}
}

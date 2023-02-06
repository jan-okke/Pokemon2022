using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Munna : Pokemon
	{
		public override string Name => "Munna";
		public override int Generation => 5;
		public override string PokedexEntry => "It eats the dreams of people and Pokémon. When it eats a pleasant dreams, it expels pink-colored mist.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Psychic };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Forewarn, AbilityFactory.Synchronize, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Telepathy;
		public override Stats BaseStats => new Stats() {
			HP = 76,
			Attack = 25,
			Defense = 45,
			SpecialAttack = 67,
			SpecialDefense = 55,
			Speed = 24
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.StoredPower, MoveFactory.DefenseCurl, },
			[4] = new List<Move>() { MoveFactory.Hypnosis, },
			[8] = new List<Move>() { MoveFactory.Psybeam, },
			[12] = new List<Move>() { MoveFactory.Imprison, },
			[16] = new List<Move>() { MoveFactory.Moonlight, },
			[20] = new List<Move>() { MoveFactory.MagicCoat, },
			[24] = new List<Move>() { MoveFactory.ZenHeadbutt, },
			[28] = new List<Move>() { MoveFactory.CalmMind, },
			[32] = new List<Move>() { MoveFactory.Yawn, },
			[36] = new List<Move>() { MoveFactory.Psychic, },
			[40] = new List<Move>() { MoveFactory.Moonblast, },
			[44] = new List<Move>() { MoveFactory.DreamEater, },
			[48] = new List<Move>() { MoveFactory.FutureSight, },
			[52] = new List<Move>() { MoveFactory.WonderRoom, },
		};
	}
}

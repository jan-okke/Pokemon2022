using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Meloetta : Pokemon
	{
		public override string Name => "Meloetta";
		public override int Generation => 5;
		public override string PokedexEntry => "Many famous songs have been inspired by the melodies that Meloetta plays.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Normal, PokemonType.Psychic };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.SereneGrace, };
		public override Stats BaseStats => new Stats() {
			HP = 100,
			Attack = 77,
			Defense = 77,
			SpecialAttack = 128,
			SpecialDefense = 128,
			Speed = 90
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Round, MoveFactory.QuickAttack, MoveFactory.Confusion, MoveFactory.Sing, },
			[6] = new List<Move>() { MoveFactory.QuickAttack, },
			[11] = new List<Move>() { MoveFactory.Confusion, },
			[16] = new List<Move>() { MoveFactory.Sing, },
			[21] = new List<Move>() { MoveFactory.TeeterDance, },
			[26] = new List<Move>() { MoveFactory.Acrobatics, },
			[31] = new List<Move>() { MoveFactory.Psybeam, },
			[36] = new List<Move>() { MoveFactory.EchoedVoice, },
			[43] = new List<Move>() { MoveFactory.Uturn, },
			[50] = new List<Move>() { MoveFactory.WakeUpSlap, },
			[57] = new List<Move>() { MoveFactory.Psychic, },
			[64] = new List<Move>() { MoveFactory.HyperVoice, },
			[71] = new List<Move>() { MoveFactory.RolePlay, },
			[78] = new List<Move>() { MoveFactory.CloseCombat, },
			[85] = new List<Move>() { MoveFactory.PerishSong, },
		};
	}
}

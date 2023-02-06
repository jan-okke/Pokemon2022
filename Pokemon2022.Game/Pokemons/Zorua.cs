using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Zorua : Pokemon
	{
		public override string Name => "Zorua";
		public override int Generation => 5;
		public override string PokedexEntry => "To protect themselves from danger, they hide their true identities by transforming into people and Pokémon.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Dark };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Illusion, };
		public override Stats BaseStats => new Stats() {
			HP = 40,
			Attack = 65,
			Defense = 40,
			SpecialAttack = 80,
			SpecialDefense = 40,
			Speed = 65
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Scratch, MoveFactory.Leer, },
			[4] = new List<Move>() { MoveFactory.Torment, },
			[8] = new List<Move>() { MoveFactory.HoneClaws, },
			[12] = new List<Move>() { MoveFactory.FurySwipes, },
			[16] = new List<Move>() { MoveFactory.ScaryFace, },
			[20] = new List<Move>() { MoveFactory.Taunt, },
			[24] = new List<Move>() { MoveFactory.KnockOff, },
			[28] = new List<Move>() { MoveFactory.FakeTears, },
			[32] = new List<Move>() { MoveFactory.Agility, },
			[36] = new List<Move>() { MoveFactory.Imprison, },
			[40] = new List<Move>() { MoveFactory.NightDaze, },
			[44] = new List<Move>() { MoveFactory.NastyPlot, },
			[48] = new List<Move>() { MoveFactory.FoulPlay, },
		};
	}
}

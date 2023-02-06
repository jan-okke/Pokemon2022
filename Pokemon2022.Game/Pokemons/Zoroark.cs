using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Zoroark : Pokemon
	{
		public override string Name => "Zoroark";
		public override int Generation => 5;
		public override string PokedexEntry => "Each has the ability to fool a large group of people simultaneously. They protect their lair with illusory scenery.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Dark };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Illusion, };
		public override Stats BaseStats => new Stats() {
			HP = 60,
			Attack = 105,
			Defense = 60,
			SpecialAttack = 120,
			SpecialDefense = 60,
			Speed = 105
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[0] = new List<Move>() { MoveFactory.NightSlash, },
			[1] = new List<Move>() { MoveFactory.NightSlash, MoveFactory.Uturn, MoveFactory.Scratch, MoveFactory.Leer, MoveFactory.Torment, MoveFactory.HoneClaws, },
			[12] = new List<Move>() { MoveFactory.FurySwipes, },
			[16] = new List<Move>() { MoveFactory.ScaryFace, },
			[20] = new List<Move>() { MoveFactory.Taunt, },
			[24] = new List<Move>() { MoveFactory.KnockOff, },
			[28] = new List<Move>() { MoveFactory.FakeTears, },
			[34] = new List<Move>() { MoveFactory.Agility, },
			[40] = new List<Move>() { MoveFactory.Imprison, },
			[46] = new List<Move>() { MoveFactory.NightDaze, },
			[52] = new List<Move>() { MoveFactory.NastyPlot, },
			[58] = new List<Move>() { MoveFactory.FoulPlay, },
		};
	}
}

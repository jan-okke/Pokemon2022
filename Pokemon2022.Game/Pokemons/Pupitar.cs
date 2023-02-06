using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Pupitar : Pokemon
	{
		public override string Name => "Pupitar";
		public override int Generation => 2;
		public override string PokedexEntry => "A Pupitar creates a gas inside its body that it ejects under compression to propel itself like a jet. Its body can withstand a collision with solid steel.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Rock, PokemonType.Ground };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.ShedSkin, };
		public override Stats BaseStats => new Stats() {
			HP = 70,
			Attack = 84,
			Defense = 70,
			SpecialAttack = 65,
			SpecialDefense = 70,
			Speed = 51
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[0] = new List<Move>() { MoveFactory.IronDefense, },
			[1] = new List<Move>() { MoveFactory.IronDefense, MoveFactory.Tackle, MoveFactory.Leer, MoveFactory.RockThrow, MoveFactory.Payback, },
			[9] = new List<Move>() { MoveFactory.Bite, },
			[12] = new List<Move>() { MoveFactory.ScaryFace, },
			[15] = new List<Move>() { MoveFactory.RockSlide, },
			[18] = new List<Move>() { MoveFactory.StompingTantrum, },
			[21] = new List<Move>() { MoveFactory.Screech, },
			[24] = new List<Move>() { MoveFactory.DarkPulse, },
			[27] = new List<Move>() { MoveFactory.Crunch, },
			[33] = new List<Move>() { MoveFactory.Earthquake, },
			[37] = new List<Move>() { MoveFactory.StoneEdge, },
			[42] = new List<Move>() { MoveFactory.Thrash, },
			[47] = new List<Move>() { MoveFactory.Sandstorm, },
			[52] = new List<Move>() { MoveFactory.HyperBeam, },
		};
	}
}

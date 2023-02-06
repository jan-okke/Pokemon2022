using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Tyranitar : Pokemon
	{
		public override string Name => "Tyranitar";
		public override int Generation => 2;
		public override string PokedexEntry => "A Tyranitar is so overwhelmingly powerful, it can bring down a whole mountain to make its nest. It roams in mountains seeking new opponents to fight.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Rock, PokemonType.Dark };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.SandStream, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Unnerve;
		public override Stats BaseStats => new Stats() {
			HP = 100,
			Attack = 134,
			Defense = 110,
			SpecialAttack = 95,
			SpecialDefense = 100,
			Speed = 61
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.IronDefense, MoveFactory.ThunderFang, MoveFactory.IceFang, MoveFactory.FireFang, MoveFactory.Tackle, MoveFactory.Leer, MoveFactory.RockThrow, MoveFactory.Payback, },
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
			[59] = new List<Move>() { MoveFactory.GigaImpact, },
		};
	}
}

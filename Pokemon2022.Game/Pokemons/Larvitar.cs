using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Larvitar : Pokemon
	{
		public override string Name => "Larvitar";
		public override int Generation => 2;
		public override string PokedexEntry => "A Larvitar is born deep under the ground. It must eat its way through the soil above and reach the surface for it to see its parents' faces.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Rock, PokemonType.Ground };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Guts, };
		public override Ability AvailableHiddenAbility => AbilityFactory.SandVeil;
		public override Stats BaseStats => new Stats() {
			HP = 50,
			Attack = 64,
			Defense = 50,
			SpecialAttack = 45,
			SpecialDefense = 50,
			Speed = 41
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Tackle, MoveFactory.Leer, },
			[3] = new List<Move>() { MoveFactory.RockThrow, },
			[6] = new List<Move>() { MoveFactory.Payback, },
			[9] = new List<Move>() { MoveFactory.Bite, },
			[12] = new List<Move>() { MoveFactory.ScaryFace, },
			[15] = new List<Move>() { MoveFactory.RockSlide, },
			[18] = new List<Move>() { MoveFactory.StompingTantrum, },
			[21] = new List<Move>() { MoveFactory.Screech, },
			[24] = new List<Move>() { MoveFactory.DarkPulse, },
			[27] = new List<Move>() { MoveFactory.Crunch, },
			[31] = new List<Move>() { MoveFactory.Earthquake, },
			[33] = new List<Move>() { MoveFactory.StoneEdge, },
			[36] = new List<Move>() { MoveFactory.Thrash, },
			[39] = new List<Move>() { MoveFactory.Sandstorm, },
			[42] = new List<Move>() { MoveFactory.HyperBeam, },
		};
	}
}

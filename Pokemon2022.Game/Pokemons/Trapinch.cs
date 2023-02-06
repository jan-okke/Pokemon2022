using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Trapinch : Pokemon
	{
		public override string Name => "Trapinch";
		public override int Generation => 3;
		public override string PokedexEntry => "Its big jaws crunch through boulders. Because its head is so big, it has a hard time getting back upright if it tips over onto its back.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Ground };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.HyperCutter, AbilityFactory.ArenaTrap, };
		public override Ability AvailableHiddenAbility => AbilityFactory.SheerForce;
		public override Stats BaseStats => new Stats() {
			HP = 45,
			Attack = 100,
			Defense = 45,
			SpecialAttack = 45,
			SpecialDefense = 45,
			Speed = 10
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.SandAttack, MoveFactory.Astonish, },
			[4] = new List<Move>() { MoveFactory.LaserFocus, },
			[8] = new List<Move>() { MoveFactory.Bite, },
			[12] = new List<Move>() { MoveFactory.MudSlap, },
			[16] = new List<Move>() { MoveFactory.SandTomb, },
			[20] = new List<Move>() { MoveFactory.Bulldoze, },
			[24] = new List<Move>() { MoveFactory.Dig, },
			[28] = new List<Move>() { MoveFactory.Crunch, },
			[32] = new List<Move>() { MoveFactory.Sandstorm, },
			[36] = new List<Move>() { MoveFactory.EarthPower, },
			[40] = new List<Move>() { MoveFactory.Earthquake, },
			[44] = new List<Move>() { MoveFactory.Superpower, },
			[48] = new List<Move>() { MoveFactory.Fissure, },
		};
	}
}

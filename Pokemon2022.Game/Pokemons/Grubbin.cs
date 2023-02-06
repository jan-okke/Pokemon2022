using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Grubbin : Pokemon
	{
		public override string Name => "Grubbin";
		public override int Generation => 7;
		public override string PokedexEntry => "It spits a sticky thread to stop opponents in their tracks, and then it grabs them in its sharp, sturdy mandibles to take them down.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Bug };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Swarm, };
		public override Stats BaseStats => new Stats() {
			HP = 47,
			Attack = 62,
			Defense = 45,
			SpecialAttack = 55,
			SpecialDefense = 45,
			Speed = 46
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.ViseGrip, MoveFactory.MudSlap, },
			[5] = new List<Move>() { MoveFactory.StringShot, },
			[10] = new List<Move>() { MoveFactory.BugBite, },
			[15] = new List<Move>() { MoveFactory.Bite, },
			[21] = new List<Move>() { MoveFactory.Spark, },
			[25] = new List<Move>() { MoveFactory.StickyWeb, },
			[30] = new List<Move>() { MoveFactory.XScissor, },
			[35] = new List<Move>() { MoveFactory.Crunch, },
			[40] = new List<Move>() { MoveFactory.Dig, },
		};
	}
}

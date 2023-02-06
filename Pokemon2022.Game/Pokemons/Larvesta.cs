using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Larvesta : Pokemon
	{
		public override string Name => "Larvesta";
		public override int Generation => 5;
		public override string PokedexEntry => "The base of volcanoes is where they make their homes. They shoot fire from their five horns to repel attacking enemies.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Bug, PokemonType.Fire };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.FlameBody, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Swarm;
		public override Stats BaseStats => new Stats() {
			HP = 55,
			Attack = 85,
			Defense = 55,
			SpecialAttack = 50,
			SpecialDefense = 55,
			Speed = 60
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Ember, MoveFactory.StringShot, },
			[6] = new List<Move>() { MoveFactory.FlameCharge, },
			[12] = new List<Move>() { MoveFactory.StruggleBug, },
			[18] = new List<Move>() { MoveFactory.FlameWheel, },
			[24] = new List<Move>() { MoveFactory.BugBite, },
			[30] = new List<Move>() { MoveFactory.Screech, },
			[36] = new List<Move>() { MoveFactory.LeechLife, },
			[42] = new List<Move>() { MoveFactory.BugBuzz, },
			[48] = new List<Move>() { MoveFactory.TakeDown, },
			[54] = new List<Move>() { MoveFactory.Amnesia, },
			[60] = new List<Move>() { MoveFactory.DoubleEdge, },
			[66] = new List<Move>() { MoveFactory.FlareBlitz, },
		};
	}
}

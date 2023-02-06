using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Drakloak : Pokemon
	{
		public override string Name => "Drakloak";
		public override int Generation => 8;
		public override string PokedexEntry => "It's capable of flying faster than 120 mph. It battles alongside Dreepy and dotes on them until they successfully evolve.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Dragon, PokemonType.Ghost };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.ClearBody, AbilityFactory.Infiltrator, };
		public override Ability AvailableHiddenAbility => AbilityFactory.CursedBody;
		public override Stats BaseStats => new Stats() {
			HP = 68,
			Attack = 80,
			Defense = 50,
			SpecialAttack = 60,
			SpecialDefense = 50,
			Speed = 102
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[0] = new List<Move>() { MoveFactory.DragonPulse, },
			[1] = new List<Move>() { MoveFactory.DragonPulse, MoveFactory.Astonish, MoveFactory.Infestation, MoveFactory.QuickAttack, MoveFactory.Bite, },
			[6] = new List<Move>() { MoveFactory.LockOn, },
			[12] = new List<Move>() { MoveFactory.Assurance, },
			[18] = new List<Move>() { MoveFactory.Hex, },
			[24] = new List<Move>() { MoveFactory.Agility, },
			[30] = new List<Move>() { MoveFactory.DoubleHit, },
			[36] = new List<Move>() { MoveFactory.Uturn, },
			[42] = new List<Move>() { MoveFactory.DragonDance, },
			[48] = new List<Move>() { MoveFactory.PhantomForce, },
			[54] = new List<Move>() { MoveFactory.TakeDown, },
			[61] = new List<Move>() { MoveFactory.DragonRush, },
			[66] = new List<Move>() { MoveFactory.DoubleEdge, },
			[72] = new List<Move>() { MoveFactory.LastResort, },
		};
	}
}

using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Dragapult : Pokemon
	{
		public override string Name => "Dragapult";
		public override int Generation => 8;
		public override string PokedexEntry => "When it isn't battling, it keeps Dreepy in the holes on its horns. Once a fight starts, it launches the Dreepy like supersonic missiles.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Dragon, PokemonType.Ghost };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.ClearBody, AbilityFactory.Infiltrator, };
		public override Ability AvailableHiddenAbility => AbilityFactory.CursedBody;
		public override Stats BaseStats => new Stats() {
			HP = 88,
			Attack = 120,
			Defense = 75,
			SpecialAttack = 100,
			SpecialDefense = 75,
			Speed = 142
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[0] = new List<Move>() { MoveFactory.DragonDarts, },
			[1] = new List<Move>() { MoveFactory.DragonDarts, MoveFactory.DragonBreath, MoveFactory.SuckerPunch, MoveFactory.Astonish, MoveFactory.Infestation, MoveFactory.QuickAttack, MoveFactory.Bite, },
			[6] = new List<Move>() { MoveFactory.LockOn, },
			[12] = new List<Move>() { MoveFactory.Assurance, },
			[18] = new List<Move>() { MoveFactory.Hex, },
			[24] = new List<Move>() { MoveFactory.Agility, },
			[30] = new List<Move>() { MoveFactory.DoubleHit, },
			[36] = new List<Move>() { MoveFactory.Uturn, },
			[42] = new List<Move>() { MoveFactory.DragonDance, },
			[48] = new List<Move>() { MoveFactory.PhantomForce, },
			[54] = new List<Move>() { MoveFactory.TakeDown, },
			[63] = new List<Move>() { MoveFactory.DragonRush, },
			[70] = new List<Move>() { MoveFactory.DoubleEdge, },
			[78] = new List<Move>() { MoveFactory.LastResort, },
		};
	}
}

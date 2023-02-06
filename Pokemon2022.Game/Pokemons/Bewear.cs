using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Bewear : Pokemon
	{
		public override string Name => "Bewear";
		public override int Generation => 7;
		public override string PokedexEntry => "It waves its hands wildly in intimidation and warning. Life is over for anyone who doesn't run away as fast as possible.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Normal, PokemonType.Fighting };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Fluffy, AbilityFactory.Klutz, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Unnerve;
		public override Stats BaseStats => new Stats() {
			HP = 120,
			Attack = 125,
			Defense = 80,
			SpecialAttack = 55,
			SpecialDefense = 60,
			Speed = 60
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[0] = new List<Move>() { MoveFactory.Bind, },
			[1] = new List<Move>() { MoveFactory.Bind, MoveFactory.Tackle, MoveFactory.Leer, MoveFactory.BabyDollEyes, MoveFactory.Payback, },
			[12] = new List<Move>() { MoveFactory.BrutalSwing, },
			[16] = new List<Move>() { MoveFactory.Endure, },
			[20] = new List<Move>() { MoveFactory.Strength, },
			[24] = new List<Move>() { MoveFactory.TakeDown, },
			[30] = new List<Move>() { MoveFactory.Flail, },
			[36] = new List<Move>() { MoveFactory.HammerArm, },
			[42] = new List<Move>() { MoveFactory.Thrash, },
			[48] = new List<Move>() { MoveFactory.PainSplit, },
			[54] = new List<Move>() { MoveFactory.DoubleEdge, },
			[60] = new List<Move>() { MoveFactory.Superpower, },
		};
	}
}

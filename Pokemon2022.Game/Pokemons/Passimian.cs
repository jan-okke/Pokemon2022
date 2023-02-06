using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Passimian : Pokemon
	{
		public override string Name => "Passimian";
		public override int Generation => 7;
		public override string PokedexEntry => "Berries are its weapons as well as the staple of its diet. The one that can throw a berry the farthest is the boss of the troop.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Fighting };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Receiver, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Defiant;
		public override Stats BaseStats => new Stats() {
			HP = 100,
			Attack = 120,
			Defense = 90,
			SpecialAttack = 40,
			SpecialDefense = 60,
			Speed = 80
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Tackle, MoveFactory.Leer, },
			[5] = new List<Move>() { MoveFactory.RockSmash, },
			[10] = new List<Move>() { MoveFactory.FocusEnergy, },
			[15] = new List<Move>() { MoveFactory.BeatUp, },
			[20] = new List<Move>() { MoveFactory.ScaryFace, },
			[25] = new List<Move>() { MoveFactory.TakeDown, },
			[30] = new List<Move>() { MoveFactory.Fling, },
			[35] = new List<Move>() { MoveFactory.BulkUp, },
			[40] = new List<Move>() { MoveFactory.Thrash, },
			[45] = new List<Move>() { MoveFactory.DoubleEdge, },
			[50] = new List<Move>() { MoveFactory.CloseCombat, },
			[55] = new List<Move>() { MoveFactory.Reversal, },
			[60] = new List<Move>() { MoveFactory.GigaImpact, },
		};
	}
}

using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Heracross : Pokemon
	{
		public override string Name => "Heracross";
		public override int Generation => 2;
		public override string PokedexEntry => "They gather in forests seeking the sweet sap of trees. It is completely clad in a steel-hard shell. It is proud of its horn, which it uses to fling foes.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Bug, PokemonType.Fighting };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Swarm, AbilityFactory.Guts, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Moxie;
		public override Stats BaseStats => new Stats() {
			HP = 80,
			Attack = 125,
			Defense = 75,
			SpecialAttack = 40,
			SpecialDefense = 95,
			Speed = 85
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Tackle, MoveFactory.Leer, },
			[5] = new List<Move>() { MoveFactory.FuryAttack, },
			[10] = new List<Move>() { MoveFactory.Endure, },
			[15] = new List<Move>() { MoveFactory.AerialAce, },
			[20] = new List<Move>() { MoveFactory.HornAttack, },
			[25] = new List<Move>() { MoveFactory.Counter, },
			[30] = new List<Move>() { MoveFactory.BrickBreak, },
			[35] = new List<Move>() { MoveFactory.PinMissile, },
			[40] = new List<Move>() { MoveFactory.ThroatChop, },
			[45] = new List<Move>() { MoveFactory.Thrash, },
			[50] = new List<Move>() { MoveFactory.SwordsDance, },
			[55] = new List<Move>() { MoveFactory.Megahorn, },
			[60] = new List<Move>() { MoveFactory.CloseCombat, },
		};
	}
}

using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Crabrawler : Pokemon
	{
		public override string Name => "Crabrawler";
		public override int Generation => 7;
		public override string PokedexEntry => "It punches so much, its pincers often come off from overuse, but they grow back quickly. What little meat they contain is rich and delicious.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Fighting };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.HyperCutter, AbilityFactory.IronFist, };
		public override Ability AvailableHiddenAbility => AbilityFactory.AngerPoint;
		public override Stats BaseStats => new Stats() {
			HP = 47,
			Attack = 82,
			Defense = 57,
			SpecialAttack = 42,
			SpecialDefense = 47,
			Speed = 63
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Bubble, },
			[5] = new List<Move>() { MoveFactory.RockSmash, },
			[9] = new List<Move>() { MoveFactory.Leer, },
			[13] = new List<Move>() { MoveFactory.Pursuit, },
			[17] = new List<Move>() { MoveFactory.BubbleBeam, },
			[22] = new List<Move>() { MoveFactory.PowerUpPunch, },
			[25] = new List<Move>() { MoveFactory.DizzyPunch, },
			[29] = new List<Move>() { MoveFactory.Payback, },
			[33] = new List<Move>() { MoveFactory.Reversal, },
			[37] = new List<Move>() { MoveFactory.Crabhammer, },
			[42] = new List<Move>() { MoveFactory.IronDefense, },
			[45] = new List<Move>() { MoveFactory.DynamicPunch, },
			[49] = new List<Move>() { MoveFactory.CloseCombat, },
		};
	}
}

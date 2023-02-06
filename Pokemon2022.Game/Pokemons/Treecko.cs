using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Treecko : Pokemon
	{
		public override string Name => "Treecko";
		public override int Generation => 3;
		public override string PokedexEntry => "It makes its nest in a giant tree in the forest. It ferociously guards against anything nearing its territory. It is said to be the protector of the trees.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Grass };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Overgrow, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Unburden;
		public override Stats BaseStats => new Stats() {
			HP = 40,
			Attack = 45,
			Defense = 35,
			SpecialAttack = 65,
			SpecialDefense = 55,
			Speed = 70
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Pound, MoveFactory.Leer, },
			[3] = new List<Move>() { MoveFactory.Leafage, },
			[6] = new List<Move>() { MoveFactory.QuickAttack, },
			[9] = new List<Move>() { MoveFactory.MegaDrain, },
			[12] = new List<Move>() { MoveFactory.Detect, },
			[15] = new List<Move>() { MoveFactory.QuickGuard, },
			[18] = new List<Move>() { MoveFactory.Assurance, },
			[21] = new List<Move>() { MoveFactory.GigaDrain, },
			[24] = new List<Move>() { MoveFactory.Slam, },
			[27] = new List<Move>() { MoveFactory.DoubleTeam, },
			[30] = new List<Move>() { MoveFactory.EnergyBall, },
			[33] = new List<Move>() { MoveFactory.Screech, },
			[36] = new List<Move>() { MoveFactory.Endeavor, },
			[39] = new List<Move>() { MoveFactory.LeafStorm, },
		};
	}
}

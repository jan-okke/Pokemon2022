using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Buizel : Pokemon
	{
		public override string Name => "Buizel";
		public override int Generation => 4;
		public override string PokedexEntry => "It has a flotation sac that is like an inflatable collar. It floats on water with its head out.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Water };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.SwiftSwim, };
		public override Ability AvailableHiddenAbility => AbilityFactory.WaterVeil;
		public override Stats BaseStats => new Stats() {
			HP = 55,
			Attack = 65,
			Defense = 35,
			SpecialAttack = 60,
			SpecialDefense = 30,
			Speed = 85
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Tackle, },
			[4] = new List<Move>() { MoveFactory.Growl, },
			[7] = new List<Move>() { MoveFactory.TailWhip, },
			[11] = new List<Move>() { MoveFactory.QuickAttack, },
			[15] = new List<Move>() { MoveFactory.WaterGun, },
			[18] = new List<Move>() { MoveFactory.Bite, },
			[21] = new List<Move>() { MoveFactory.Swift, },
			[24] = new List<Move>() { MoveFactory.AquaJet, },
			[27] = new List<Move>() { MoveFactory.DoubleHit, },
			[31] = new List<Move>() { MoveFactory.Whirlpool, },
			[35] = new List<Move>() { MoveFactory.Waterfall, },
			[38] = new List<Move>() { MoveFactory.AquaTail, },
			[41] = new List<Move>() { MoveFactory.Agility, },
			[45] = new List<Move>() { MoveFactory.HydroPump, },
		};
	}
}

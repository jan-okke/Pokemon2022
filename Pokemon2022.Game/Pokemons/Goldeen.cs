using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Goldeen : Pokemon
	{
		public override string Name => "Goldeen";
		public override int Generation => 1;
		public override string PokedexEntry => "In the springtime, schools of Goldeen can be seen swimming up falls and rivers. It metes out staggering damage with its single horn.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Water };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.SwiftSwim, AbilityFactory.WaterVeil, };
		public override Ability AvailableHiddenAbility => AbilityFactory.LightningRod;
		public override Stats BaseStats => new Stats() {
			HP = 45,
			Attack = 67,
			Defense = 60,
			SpecialAttack = 35,
			SpecialDefense = 50,
			Speed = 63
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Peck, MoveFactory.TailWhip, },
			[5] = new List<Move>() { MoveFactory.Supersonic, },
			[10] = new List<Move>() { MoveFactory.WaterPulse, },
			[15] = new List<Move>() { MoveFactory.HornAttack, },
			[20] = new List<Move>() { MoveFactory.Agility, },
			[25] = new List<Move>() { MoveFactory.AquaRing, },
			[30] = new List<Move>() { MoveFactory.Flail, },
			[35] = new List<Move>() { MoveFactory.Waterfall, },
			[40] = new List<Move>() { MoveFactory.Soak, },
			[45] = new List<Move>() { MoveFactory.Megahorn, },
			[50] = new List<Move>() { MoveFactory.HornDrill, },
		};
	}
}

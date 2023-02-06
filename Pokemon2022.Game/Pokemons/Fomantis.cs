using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Fomantis : Pokemon
	{
		public override string Name => "Fomantis";
		public override int Generation => 7;
		public override string PokedexEntry => "When the sun rises, Fomantis spreads its four leaves and bathes in the sunlight. The tip of its head has a pleasant aroma.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Grass };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.LeafGuard, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Contrary;
		public override Stats BaseStats => new Stats() {
			HP = 40,
			Attack = 55,
			Defense = 35,
			SpecialAttack = 50,
			SpecialDefense = 35,
			Speed = 35
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Leafage, MoveFactory.FuryCutter, },
			[5] = new List<Move>() { MoveFactory.Growth, },
			[10] = new List<Move>() { MoveFactory.Ingrain, },
			[15] = new List<Move>() { MoveFactory.RazorLeaf, },
			[20] = new List<Move>() { MoveFactory.SweetScent, },
			[25] = new List<Move>() { MoveFactory.Slash, },
			[30] = new List<Move>() { MoveFactory.XScissor, },
			[35] = new List<Move>() { MoveFactory.Synthesis, },
			[40] = new List<Move>() { MoveFactory.LeafBlade, },
			[45] = new List<Move>() { MoveFactory.SunnyDay, },
			[50] = new List<Move>() { MoveFactory.SolarBeam, },
		};
	}
}

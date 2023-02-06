using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Cascoon : Pokemon
	{
		public override string Name => "Cascoon";
		public override int Generation => 3;
		public override string PokedexEntry => "To avoid detection by its enemies, it hides motionlessly beneath large leaves and in the gaps of branches. It also attaches dead leaves to its body for camouflage.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Bug };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.ShedSkin, };
		public override Stats BaseStats => new Stats() {
			HP = 50,
			Attack = 35,
			Defense = 55,
			SpecialAttack = 25,
			SpecialDefense = 25,
			Speed = 15
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[0] = new List<Move>() { MoveFactory.Harden, },
			[1] = new List<Move>() { MoveFactory.Harden, },
		};
	}
}

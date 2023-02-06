using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Salandit : Pokemon
	{
		public override string Name => "Salandit";
		public override int Generation => 7;
		public override string PokedexEntry => "It burns its bodily fluids to create a poisonous gas. When its enemies become disoriented from inhaling the gas, it attacks them.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Poison, PokemonType.Fire };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Corrosion, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Oblivious;
		public override Stats BaseStats => new Stats() {
			HP = 48,
			Attack = 44,
			Defense = 40,
			SpecialAttack = 71,
			SpecialDefense = 40,
			Speed = 77
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Scratch, MoveFactory.PoisonGas, },
			[5] = new List<Move>() { MoveFactory.Smog, },
			[10] = new List<Move>() { MoveFactory.Ember, },
			[15] = new List<Move>() { MoveFactory.PoisonFang, },
			[20] = new List<Move>() { MoveFactory.SweetScent, },
			[25] = new List<Move>() { MoveFactory.NastyPlot, },
			[30] = new List<Move>() { MoveFactory.Incinerate, },
			[35] = new List<Move>() { MoveFactory.Venoshock, },
			[40] = new List<Move>() { MoveFactory.DragonPulse, },
			[45] = new List<Move>() { MoveFactory.VenomDrench, },
			[50] = new List<Move>() { MoveFactory.Flamethrower, },
			[55] = new List<Move>() { MoveFactory.Toxic, },
			[60] = new List<Move>() { MoveFactory.Endeavor, },
		};
	}
}

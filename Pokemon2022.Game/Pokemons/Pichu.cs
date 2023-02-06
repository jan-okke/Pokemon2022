using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Pichu : Pokemon
	{
		public override string Name => "Pichu";
		public override int Generation => 2;
		public override string PokedexEntry => "It is still inept at retaining electricity. When it is startled, it discharges power accidentally. It gets better at holding power as it grows older.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Electric };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Static, };
		public override Ability AvailableHiddenAbility => AbilityFactory.LightningRod;
		public override Stats BaseStats => new Stats() {
			HP = 20,
			Attack = 40,
			Defense = 15,
			SpecialAttack = 35,
			SpecialDefense = 35,
			Speed = 60
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.ThunderShock, MoveFactory.TailWhip, },
			[4] = new List<Move>() { MoveFactory.PlayNice, },
			[8] = new List<Move>() { MoveFactory.SweetKiss, },
			[12] = new List<Move>() { MoveFactory.Nuzzle, },
			[16] = new List<Move>() { MoveFactory.NastyPlot, },
			[20] = new List<Move>() { MoveFactory.Charm, },
		};
	}
}

using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Pikachu : Pokemon
	{
		public override string Name => "Pikachu";
		public override int Generation => 1;
		public override string PokedexEntry => "It stores electricity in the electric sacs on its cheeks. When it releases pent-up energy in a burst, the electric power is equal to a lightning bolt.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Electric };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Static, };
		public override Ability AvailableHiddenAbility => AbilityFactory.LightningRod;
		public override Stats BaseStats => new Stats() {
			HP = 35,
			Attack = 55,
			Defense = 40,
			SpecialAttack = 50,
			SpecialDefense = 50,
			Speed = 90
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.PlayNice, MoveFactory.SweetKiss, MoveFactory.Nuzzle, MoveFactory.NastyPlot, MoveFactory.Charm, MoveFactory.ThunderShock, MoveFactory.TailWhip, MoveFactory.Growl, MoveFactory.QuickAttack, },
			[4] = new List<Move>() { MoveFactory.ThunderWave, },
			[8] = new List<Move>() { MoveFactory.DoubleTeam, },
			[12] = new List<Move>() { MoveFactory.ElectroBall, },
			[16] = new List<Move>() { MoveFactory.Feint, },
			[20] = new List<Move>() { MoveFactory.Spark, },
			[24] = new List<Move>() { MoveFactory.Agility, },
			[28] = new List<Move>() { MoveFactory.Slam, },
			[32] = new List<Move>() { MoveFactory.Discharge, },
			[36] = new List<Move>() { MoveFactory.Thunderbolt, },
			[40] = new List<Move>() { MoveFactory.LightScreen, },
			[44] = new List<Move>() { MoveFactory.Thunder, },
		};
	}
}

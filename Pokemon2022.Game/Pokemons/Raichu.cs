using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Raichu : Pokemon
	{
		public override string Name => "Raichu";
		public override int Generation => 1;
		public override string PokedexEntry => "If it stores too much electricity, its behavior turns aggressive. To avoid this, it occasionally discharges excess energy and calms itself down.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Electric };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Static, };
		public override Ability AvailableHiddenAbility => AbilityFactory.LightningRod;
		public override Stats BaseStats => new Stats() {
			HP = 60,
			Attack = 90,
			Defense = 55,
			SpecialAttack = 90,
			SpecialDefense = 80,
			Speed = 110
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[0] = new List<Move>() { MoveFactory.ThunderPunch, },
			[1] = new List<Move>() { MoveFactory.ThunderPunch, MoveFactory.PlayNice, MoveFactory.SweetKiss, MoveFactory.Nuzzle, MoveFactory.NastyPlot, MoveFactory.Charm, MoveFactory.ThunderWave, MoveFactory.DoubleTeam, MoveFactory.ElectroBall, MoveFactory.Feint, MoveFactory.Spark, MoveFactory.Agility, MoveFactory.Slam, MoveFactory.Discharge, MoveFactory.Thunderbolt, MoveFactory.LightScreen, MoveFactory.Thunder, MoveFactory.ThunderShock, MoveFactory.TailWhip, MoveFactory.Growl, MoveFactory.QuickAttack, },
		};
	}
}

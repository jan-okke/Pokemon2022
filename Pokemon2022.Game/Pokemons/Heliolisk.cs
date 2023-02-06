using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Heliolisk : Pokemon
	{
		public override string Name => "Heliolisk";
		public override int Generation => 6;
		public override string PokedexEntry => "They flare their frills and generate energy. A single Heliolisk can generate sufficient electricity to power a skyscraper.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Electric, PokemonType.Normal };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.DrySkin, AbilityFactory.SandVeil, };
		public override Ability AvailableHiddenAbility => AbilityFactory.SolarPower;
		public override Stats BaseStats => new Stats() {
			HP = 62,
			Attack = 55,
			Defense = 52,
			SpecialAttack = 109,
			SpecialDefense = 94,
			Speed = 109
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.EerieImpulse, MoveFactory.Discharge, MoveFactory.QuickAttack, MoveFactory.Charge, MoveFactory.Bulldoze, MoveFactory.VoltSwitch, MoveFactory.ParabolicCharge, MoveFactory.ThunderWave, MoveFactory.Thunderbolt, MoveFactory.Electrify, MoveFactory.Thunder, MoveFactory.MudSlap, MoveFactory.TailWhip, MoveFactory.Pound, MoveFactory.ThunderShock, },
		};
	}
}

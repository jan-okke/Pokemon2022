using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Helioptile : Pokemon
	{
		public override string Name => "Helioptile";
		public override int Generation => 6;
		public override string PokedexEntry => "They make their home in deserts. They can generate their energy from basking in the sun, so eating food is not a requirement.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Electric, PokemonType.Normal };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.DrySkin, AbilityFactory.SandVeil, };
		public override Ability AvailableHiddenAbility => AbilityFactory.SolarPower;
		public override Stats BaseStats => new Stats() {
			HP = 44,
			Attack = 38,
			Defense = 33,
			SpecialAttack = 61,
			SpecialDefense = 43,
			Speed = 70
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.MudSlap, MoveFactory.TailWhip, },
			[4] = new List<Move>() { MoveFactory.Pound, },
			[8] = new List<Move>() { MoveFactory.ThunderShock, },
			[12] = new List<Move>() { MoveFactory.QuickAttack, },
			[16] = new List<Move>() { MoveFactory.Charge, },
			[20] = new List<Move>() { MoveFactory.Bulldoze, },
			[24] = new List<Move>() { MoveFactory.VoltSwitch, },
			[28] = new List<Move>() { MoveFactory.ParabolicCharge, },
			[32] = new List<Move>() { MoveFactory.ThunderWave, },
			[36] = new List<Move>() { MoveFactory.Thunderbolt, },
			[40] = new List<Move>() { MoveFactory.Electrify, },
			[44] = new List<Move>() { MoveFactory.Thunder, },
		};
	}
}

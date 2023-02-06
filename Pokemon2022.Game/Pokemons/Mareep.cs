using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Mareep : Pokemon
	{
		public override string Name => "Mareep";
		public override int Generation => 2;
		public override string PokedexEntry => "Its fluffy wool rubs together and builds a static charge. The more energy is charged, the more brightly the lightbulb at the tip of its tail glows.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Electric };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Static, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Plus;
		public override Stats BaseStats => new Stats() {
			HP = 55,
			Attack = 40,
			Defense = 40,
			SpecialAttack = 65,
			SpecialDefense = 45,
			Speed = 35
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Tackle, MoveFactory.Growl, },
			[4] = new List<Move>() { MoveFactory.ThunderWave, },
			[8] = new List<Move>() { MoveFactory.ThunderShock, },
			[11] = new List<Move>() { MoveFactory.CottonSpore, },
			[15] = new List<Move>() { MoveFactory.Charge, },
			[18] = new List<Move>() { MoveFactory.TakeDown, },
			[22] = new List<Move>() { MoveFactory.ElectroBall, },
			[25] = new List<Move>() { MoveFactory.ConfuseRay, },
			[29] = new List<Move>() { MoveFactory.PowerGem, },
			[32] = new List<Move>() { MoveFactory.Discharge, },
			[36] = new List<Move>() { MoveFactory.CottonGuard, },
			[39] = new List<Move>() { MoveFactory.ChargeBeam, },
			[43] = new List<Move>() { MoveFactory.LightScreen, },
			[46] = new List<Move>() { MoveFactory.Thunder, },
		};
	}
}

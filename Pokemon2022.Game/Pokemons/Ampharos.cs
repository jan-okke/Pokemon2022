using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Ampharos : Pokemon
	{
		public override string Name => "Ampharos";
		public override int Generation => 2;
		public override string PokedexEntry => "It gives off so much light that it can be seen even from space. People in the old days used its light to send signals back and forth with others far away.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Electric };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Static, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Plus;
		public override Stats BaseStats => new Stats() {
			HP = 90,
			Attack = 75,
			Defense = 85,
			SpecialAttack = 115,
			SpecialDefense = 90,
			Speed = 55
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[0] = new List<Move>() { MoveFactory.ThunderPunch, },
			[1] = new List<Move>() { MoveFactory.ThunderPunch, MoveFactory.ZapCannon, MoveFactory.MagneticFlux, MoveFactory.DragonPulse, MoveFactory.FirePunch, MoveFactory.Tackle, MoveFactory.Growl, MoveFactory.ThunderWave, MoveFactory.ThunderShock, },
			[4] = new List<Move>() { MoveFactory.ThunderWave, },
			[8] = new List<Move>() { MoveFactory.ThunderShock, },
			[11] = new List<Move>() { MoveFactory.CottonSpore, },
			[16] = new List<Move>() { MoveFactory.Charge, },
			[20] = new List<Move>() { MoveFactory.TakeDown, },
			[25] = new List<Move>() { MoveFactory.ElectroBall, },
			[29] = new List<Move>() { MoveFactory.ConfuseRay, },
			[35] = new List<Move>() { MoveFactory.PowerGem, },
			[40] = new List<Move>() { MoveFactory.Discharge, },
			[46] = new List<Move>() { MoveFactory.CottonGuard, },
			[51] = new List<Move>() { MoveFactory.ChargeBeam, },
			[57] = new List<Move>() { MoveFactory.LightScreen, },
			[62] = new List<Move>() { MoveFactory.Thunder, },
			[65] = new List<Move>() { MoveFactory.DragonPulse, },
		};
	}
}

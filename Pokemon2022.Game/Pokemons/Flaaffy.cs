using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Flaaffy : Pokemon
	{
		public override string Name => "Flaaffy";
		public override int Generation => 2;
		public override string PokedexEntry => "Its fleece quality changes to generate strong static electricity with a small amount of wool. The bare, slick parts of its hide are shielded against electricity.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Electric };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Static, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Plus;
		public override Stats BaseStats => new Stats() {
			HP = 70,
			Attack = 55,
			Defense = 55,
			SpecialAttack = 80,
			SpecialDefense = 60,
			Speed = 45
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Tackle, MoveFactory.Growl, MoveFactory.ThunderWave, MoveFactory.ThunderShock, },
			[4] = new List<Move>() { MoveFactory.ThunderWave, },
			[8] = new List<Move>() { MoveFactory.ThunderShock, },
			[11] = new List<Move>() { MoveFactory.CottonSpore, },
			[16] = new List<Move>() { MoveFactory.Charge, },
			[20] = new List<Move>() { MoveFactory.TakeDown, },
			[25] = new List<Move>() { MoveFactory.ElectroBall, },
			[29] = new List<Move>() { MoveFactory.ConfuseRay, },
			[34] = new List<Move>() { MoveFactory.PowerGem, },
			[38] = new List<Move>() { MoveFactory.Discharge, },
			[43] = new List<Move>() { MoveFactory.CottonGuard, },
			[47] = new List<Move>() { MoveFactory.ChargeBeam, },
			[52] = new List<Move>() { MoveFactory.LightScreen, },
			[56] = new List<Move>() { MoveFactory.Thunder, },
		};
	}
}

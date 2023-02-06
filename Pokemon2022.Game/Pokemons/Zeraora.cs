using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Zeraora : Pokemon
	{
		public override string Name => "Zeraora";
		public override int Generation => 7;
		public override string PokedexEntry => "It approaches its enemies at the speed of lightning, then tears them limb from limb with its sharp claws.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Electric };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.VoltAbsorb, };
		public override Stats BaseStats => new Stats() {
			HP = 88,
			Attack = 112,
			Defense = 75,
			SpecialAttack = 102,
			SpecialDefense = 80,
			Speed = 143
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.PowerUpPunch, MoveFactory.FakeOut, MoveFactory.Scratch, MoveFactory.QuickAttack, MoveFactory.Snarl, MoveFactory.Spark, },
			[8] = new List<Move>() { MoveFactory.FurySwipes, },
			[16] = new List<Move>() { MoveFactory.QuickGuard, },
			[24] = new List<Move>() { MoveFactory.Slash, },
			[32] = new List<Move>() { MoveFactory.VoltSwitch, },
			[40] = new List<Move>() { MoveFactory.Charge, },
			[48] = new List<Move>() { MoveFactory.ThunderPunch, },
			[56] = new List<Move>() { MoveFactory.HoneClaws, },
			[64] = new List<Move>() { MoveFactory.Discharge, },
			[72] = new List<Move>() { MoveFactory.WildCharge, },
			[80] = new List<Move>() { MoveFactory.Agility, },
			[88] = new List<Move>() { MoveFactory.PlasmaFists, },
			[96] = new List<Move>() { MoveFactory.CloseCombat, },
		};
	}
}

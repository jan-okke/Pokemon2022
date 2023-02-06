using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Hariyama : Pokemon
	{
		public override string Name => "Hariyama";
		public override int Generation => 3;
		public override string PokedexEntry => "It has the habit of challenging others without hesitation to tests of strength. It's been known to stand on train tracks and stop trains using forearm thrusts.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Fighting };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.ThickFat, AbilityFactory.Guts, };
		public override Ability AvailableHiddenAbility => AbilityFactory.SheerForce;
		public override Stats BaseStats => new Stats() {
			HP = 144,
			Attack = 120,
			Defense = 60,
			SpecialAttack = 40,
			SpecialDefense = 60,
			Speed = 50
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Brine, MoveFactory.Tackle, MoveFactory.FocusEnergy, MoveFactory.SandAttack, MoveFactory.ArmThrust, },
			[4] = new List<Move>() { MoveFactory.SandAttack, },
			[7] = new List<Move>() { MoveFactory.ArmThrust, },
			[10] = new List<Move>() { MoveFactory.FakeOut, },
			[13] = new List<Move>() { MoveFactory.ForcePalm, },
			[16] = new List<Move>() { MoveFactory.Whirlwind, },
			[19] = new List<Move>() { MoveFactory.KnockOff, },
			[22] = new List<Move>() { MoveFactory.VitalThrow, },
			[26] = new List<Move>() { MoveFactory.BellyDrum, },
			[30] = new List<Move>() { MoveFactory.Detect, },
			[34] = new List<Move>() { MoveFactory.SeismicToss, },
			[38] = new List<Move>() { MoveFactory.FocusPunch, },
			[42] = new List<Move>() { MoveFactory.Endure, },
			[46] = new List<Move>() { MoveFactory.CloseCombat, },
			[50] = new List<Move>() { MoveFactory.Reversal, },
			[54] = new List<Move>() { MoveFactory.HeavySlam, },
		};
	}
}

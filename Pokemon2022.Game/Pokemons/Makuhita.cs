using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Makuhita : Pokemon
	{
		public override string Name => "Makuhita";
		public override int Generation => 3;
		public override string PokedexEntry => "It loves to toughen up its body above all else. If you hear quaking rumbles in a cave, it is the sound of Makuhita undertaking strenuous training.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Fighting };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.ThickFat, AbilityFactory.Guts, };
		public override Ability AvailableHiddenAbility => AbilityFactory.SheerForce;
		public override Stats BaseStats => new Stats() {
			HP = 72,
			Attack = 60,
			Defense = 30,
			SpecialAttack = 20,
			SpecialDefense = 30,
			Speed = 25
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Tackle, MoveFactory.FocusEnergy, },
			[4] = new List<Move>() { MoveFactory.SandAttack, },
			[7] = new List<Move>() { MoveFactory.ArmThrust, },
			[10] = new List<Move>() { MoveFactory.FakeOut, },
			[13] = new List<Move>() { MoveFactory.ForcePalm, },
			[16] = new List<Move>() { MoveFactory.Whirlwind, },
			[19] = new List<Move>() { MoveFactory.KnockOff, },
			[22] = new List<Move>() { MoveFactory.VitalThrow, },
			[25] = new List<Move>() { MoveFactory.BellyDrum, },
			[28] = new List<Move>() { MoveFactory.Detect, },
			[31] = new List<Move>() { MoveFactory.SeismicToss, },
			[34] = new List<Move>() { MoveFactory.FocusPunch, },
			[37] = new List<Move>() { MoveFactory.Endure, },
			[40] = new List<Move>() { MoveFactory.CloseCombat, },
			[43] = new List<Move>() { MoveFactory.Reversal, },
			[46] = new List<Move>() { MoveFactory.HeavySlam, },
		};
	}
}

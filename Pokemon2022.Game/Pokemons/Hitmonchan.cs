using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Hitmonchan : Pokemon
	{
		public override string Name => "Hitmonchan";
		public override int Generation => 1;
		public override string PokedexEntry => "A Hitmonchan is said to possess the spirit of a boxer who aimed to become the world champion. Having an indomitable spirit means that it will never give up.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Fighting };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.KeenEye, AbilityFactory.IronFist, };
		public override Ability AvailableHiddenAbility => AbilityFactory.InnerFocus;
		public override Stats BaseStats => new Stats() {
			HP = 50,
			Attack = 105,
			Defense = 79,
			SpecialAttack = 35,
			SpecialDefense = 110,
			Speed = 76
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[0] = new List<Move>() { MoveFactory.DrainPunch, },
			[1] = new List<Move>() { MoveFactory.DrainPunch, MoveFactory.Feint, MoveFactory.VacuumWave, MoveFactory.BulletPunch, MoveFactory.Tackle, MoveFactory.HelpingHand, MoveFactory.FakeOut, MoveFactory.FocusEnergy, },
			[4] = new List<Move>() { MoveFactory.MachPunch, },
			[8] = new List<Move>() { MoveFactory.PowerUpPunch, },
			[12] = new List<Move>() { MoveFactory.Detect, },
			[16] = new List<Move>() { MoveFactory.Revenge, },
			[21] = new List<Move>() { MoveFactory.QuickGuard, },
			[24] = new List<Move>() { MoveFactory.ThunderPunch, MoveFactory.IcePunch, MoveFactory.FirePunch, },
			[28] = new List<Move>() { MoveFactory.Agility, },
			[32] = new List<Move>() { MoveFactory.MegaPunch, },
			[36] = new List<Move>() { MoveFactory.CloseCombat, },
			[40] = new List<Move>() { MoveFactory.Counter, },
			[44] = new List<Move>() { MoveFactory.FocusPunch, },
		};
	}
}

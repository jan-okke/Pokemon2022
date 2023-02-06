using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Pangoro : Pokemon
	{
		public override string Name => "Pangoro";
		public override int Generation => 6;
		public override string PokedexEntry => "It charges ahead and bashes its opponents like a berserker, uncaring about any hits it might take. Its arms are mighty enough to snap a telephone pole.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Fighting, PokemonType.Dark };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.IronFist, AbilityFactory.MoldBreaker, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Scrappy;
		public override Stats BaseStats => new Stats() {
			HP = 95,
			Attack = 124,
			Defense = 78,
			SpecialAttack = 69,
			SpecialDefense = 71,
			Speed = 58
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[0] = new List<Move>() { MoveFactory.NightSlash, },
			[1] = new List<Move>() { MoveFactory.NightSlash, MoveFactory.BulletPunch, MoveFactory.Tackle, MoveFactory.Leer, MoveFactory.ArmThrust, MoveFactory.Taunt, },
			[12] = new List<Move>() { MoveFactory.CircleThrow, },
			[16] = new List<Move>() { MoveFactory.LowSweep, },
			[20] = new List<Move>() { MoveFactory.WorkUp, },
			[24] = new List<Move>() { MoveFactory.Slash, },
			[28] = new List<Move>() { MoveFactory.VitalThrow, },
			[35] = new List<Move>() { MoveFactory.Crunch, },
			[40] = new List<Move>() { MoveFactory.BodySlam, },
			[46] = new List<Move>() { MoveFactory.PartingShot, },
			[52] = new List<Move>() { MoveFactory.Entrainment, },
			[58] = new List<Move>() { MoveFactory.HammerArm, },
		};
	}
}

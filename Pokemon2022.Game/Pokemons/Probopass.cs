using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Probopass : Pokemon
	{
		public override string Name => "Probopass";
		public override int Generation => 4;
		public override string PokedexEntry => "It exudes strong magnetism from all over. It controls three small units called Mini-Noses.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Rock, PokemonType.Steel };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Sturdy, AbilityFactory.MagnetPull, };
		public override Ability AvailableHiddenAbility => AbilityFactory.SandForce;
		public override Stats BaseStats => new Stats() {
			HP = 60,
			Attack = 55,
			Defense = 145,
			SpecialAttack = 75,
			SpecialDefense = 150,
			Speed = 40
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[0] = new List<Move>() { MoveFactory.TriAttack, },
			[1] = new List<Move>() { MoveFactory.TriAttack, MoveFactory.MagneticFlux, MoveFactory.MagnetRise, MoveFactory.Gravity, MoveFactory.WideGuard, MoveFactory.Tackle, MoveFactory.IronDefense, MoveFactory.Block, },
			[4] = new List<Move>() { MoveFactory.IronDefense, },
			[7] = new List<Move>() { MoveFactory.Block, },
			[10] = new List<Move>() { MoveFactory.SmackDown, },
			[13] = new List<Move>() { MoveFactory.ThunderWave, },
			[16] = new List<Move>() { MoveFactory.Rest, },
			[19] = new List<Move>() { MoveFactory.Spark, },
			[22] = new List<Move>() { MoveFactory.RockSlide, },
			[25] = new List<Move>() { MoveFactory.PowerGem, },
			[28] = new List<Move>() { MoveFactory.RockBlast, },
			[31] = new List<Move>() { MoveFactory.Discharge, },
			[34] = new List<Move>() { MoveFactory.Sandstorm, },
			[37] = new List<Move>() { MoveFactory.EarthPower, },
			[40] = new List<Move>() { MoveFactory.StoneEdge, },
			[43] = new List<Move>() { MoveFactory.LockOn, MoveFactory.ZapCannon, },
			[50] = new List<Move>() { MoveFactory.BodyPress, },
		};
	}
}

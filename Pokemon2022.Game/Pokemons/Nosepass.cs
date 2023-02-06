using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Nosepass : Pokemon
	{
		public override string Name => "Nosepass";
		public override int Generation => 3;
		public override string PokedexEntry => "Its body emits a powerful magnetism. It feeds on prey that is pulled in by the force. Its magnetism is stronger in cold seasons.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Rock };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Sturdy, AbilityFactory.MagnetPull, };
		public override Ability AvailableHiddenAbility => AbilityFactory.SandForce;
		public override Stats BaseStats => new Stats() {
			HP = 30,
			Attack = 45,
			Defense = 135,
			SpecialAttack = 45,
			SpecialDefense = 90,
			Speed = 30
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Tackle, },
			[4] = new List<Move>() { MoveFactory.Harden, },
			[7] = new List<Move>() { MoveFactory.Block, },
			[10] = new List<Move>() { MoveFactory.RockThrow, },
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
		};
	}
}

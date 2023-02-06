using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Cofagrigus : Pokemon
	{
		public override string Name => "Cofagrigus";
		public override int Generation => 5;
		public override string PokedexEntry => "They pretend to be elaborate coffins to teach lessons to grave robbers. Their bodies are covered in pure gold.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Ghost };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Mummy, };
		public override Stats BaseStats => new Stats() {
			HP = 58,
			Attack = 50,
			Defense = 145,
			SpecialAttack = 95,
			SpecialDefense = 105,
			Speed = 30
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[0] = new List<Move>() { MoveFactory.ShadowClaw, },
			[1] = new List<Move>() { MoveFactory.ShadowClaw, MoveFactory.ScaryFace, MoveFactory.Astonish, MoveFactory.Protect, MoveFactory.Haze, MoveFactory.NightShade, },
			[12] = new List<Move>() { MoveFactory.Disable, },
			[16] = new List<Move>() { MoveFactory.WillOWisp, },
			[20] = new List<Move>() { MoveFactory.CraftyShield, },
			[24] = new List<Move>() { MoveFactory.Hex, },
			[28] = new List<Move>() { MoveFactory.MeanLook, },
			[32] = new List<Move>() { MoveFactory.Grudge, },
			[38] = new List<Move>() { MoveFactory.Curse, },
			[44] = new List<Move>() { MoveFactory.ShadowBall, },
			[50] = new List<Move>() { MoveFactory.DarkPulse, },
			[56] = new List<Move>() { MoveFactory.PowerSplit, MoveFactory.GuardSplit, },
			[62] = new List<Move>() { MoveFactory.DestinyBond, },
		};
	}
}

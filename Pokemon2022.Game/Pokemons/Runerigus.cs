using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Runerigus : Pokemon
	{
		public override string Name => "Runerigus";
		public override int Generation => 8;
		public override string PokedexEntry => "A powerful curse was woven into an ancient painting. After absorbing the spirit of a Yamask, the painting began to move.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Ground, PokemonType.Ghost };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.WanderingSpirit, };
		public override Stats BaseStats => new Stats() {
			HP = 58,
			Attack = 95,
			Defense = 145,
			SpecialAttack = 50,
			SpecialDefense = 105,
			Speed = 30
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[0] = new List<Move>() { MoveFactory.ShadowClaw, },
			[1] = new List<Move>() { MoveFactory.ShadowClaw, MoveFactory.ScaryFace, MoveFactory.Astonish, MoveFactory.Protect, MoveFactory.Haze, MoveFactory.NightShade, },
			[12] = new List<Move>() { MoveFactory.Disable, },
			[16] = new List<Move>() { MoveFactory.BrutalSwing, },
			[20] = new List<Move>() { MoveFactory.CraftyShield, },
			[24] = new List<Move>() { MoveFactory.Hex, },
			[28] = new List<Move>() { MoveFactory.MeanLook, },
			[32] = new List<Move>() { MoveFactory.Slam, },
			[38] = new List<Move>() { MoveFactory.Curse, },
			[44] = new List<Move>() { MoveFactory.ShadowBall, },
			[50] = new List<Move>() { MoveFactory.Earthquake, },
			[56] = new List<Move>() { MoveFactory.PowerSplit, MoveFactory.GuardSplit, },
			[62] = new List<Move>() { MoveFactory.DestinyBond, },
		};
	}
}

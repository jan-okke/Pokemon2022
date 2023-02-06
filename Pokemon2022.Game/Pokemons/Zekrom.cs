using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Zekrom : Pokemon
	{
		public override string Name => "Zekrom";
		public override int Generation => 5;
		public override string PokedexEntry => "This Pokémon appears in legends. In its tail, it has a giant generator that creates electricity.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Dragon, PokemonType.Electric };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Teravolt, };
		public override Stats BaseStats => new Stats() {
			HP = 100,
			Attack = 150,
			Defense = 120,
			SpecialAttack = 120,
			SpecialDefense = 100,
			Speed = 90
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.DragonBreath, MoveFactory.NobleRoar, MoveFactory.AncientPower, MoveFactory.ThunderFang, },
			[8] = new List<Move>() { MoveFactory.Slash, },
			[16] = new List<Move>() { MoveFactory.Crunch, },
			[24] = new List<Move>() { MoveFactory.ZenHeadbutt, },
			[32] = new List<Move>() { MoveFactory.DragonClaw, },
			[40] = new List<Move>() { MoveFactory.Thunderbolt, },
			[48] = new List<Move>() { MoveFactory.FusionBolt, },
			[56] = new List<Move>() { MoveFactory.HyperVoice, },
			[64] = new List<Move>() { MoveFactory.Thunder, },
			[72] = new List<Move>() { MoveFactory.Imprison, },
			[80] = new List<Move>() { MoveFactory.Outrage, },
			[88] = new List<Move>() { MoveFactory.BoltStrike, },
		};
	}
}

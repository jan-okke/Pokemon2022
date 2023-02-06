using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Blissey : Pokemon
	{
		public override string Name => "Blissey";
		public override int Generation => 2;
		public override string PokedexEntry => "If it senses sadness with its fluffy fur, a Blissey will rush over to the sad person, however far away, to share an egg of happiness that brings a smile to any face.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Normal };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.NaturalCure, AbilityFactory.SereneGrace, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Healer;
		public override Stats BaseStats => new Stats() {
			HP = 255,
			Attack = 10,
			Defense = 10,
			SpecialAttack = 75,
			SpecialDefense = 135,
			Speed = 55
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.SweetKiss, MoveFactory.DisarmingVoice, MoveFactory.Covet, MoveFactory.Charm, MoveFactory.Minimize, MoveFactory.Pound, MoveFactory.Copycat, MoveFactory.DefenseCurl, },
			[4] = new List<Move>() { MoveFactory.TailWhip, },
			[8] = new List<Move>() { MoveFactory.EchoedVoice, },
			[12] = new List<Move>() { MoveFactory.LifeDew, },
			[16] = new List<Move>() { MoveFactory.Sing, },
			[20] = new List<Move>() { MoveFactory.Fling, },
			[24] = new List<Move>() { MoveFactory.TakeDown, },
			[28] = new List<Move>() { MoveFactory.HealPulse, },
			[32] = new List<Move>() { MoveFactory.HelpingHand, },
			[36] = new List<Move>() { MoveFactory.LightScreen, },
			[40] = new List<Move>() { MoveFactory.DoubleEdge, },
			[44] = new List<Move>() { MoveFactory.SoftBoiled, },
			[48] = new List<Move>() { MoveFactory.LastResort, },
			[52] = new List<Move>() { MoveFactory.HealingWish, },
		};
	}
}

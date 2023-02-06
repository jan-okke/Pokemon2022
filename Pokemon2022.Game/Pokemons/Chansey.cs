using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Chansey : Pokemon
	{
		public override string Name => "Chansey";
		public override int Generation => 1;
		public override string PokedexEntry => "Chansey lay nutritionally excellent eggs every day. The eggs are so delicious, they are eagerly devoured by even those who have lost their appetite.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Normal };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.NaturalCure, AbilityFactory.SereneGrace, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Healer;
		public override Stats BaseStats => new Stats() {
			HP = 250,
			Attack = 5,
			Defense = 5,
			SpecialAttack = 35,
			SpecialDefense = 105,
			Speed = 50
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

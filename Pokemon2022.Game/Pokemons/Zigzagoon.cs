using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Zigzagoon : Pokemon
	{
		public override string Name => "Zigzagoon";
		public override int Generation => 3;
		public override string PokedexEntry => "Rubbing its nose against the ground, it always wanders about back and forth in search of something. It is distinguished by the zigzag footprints it leaves.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Normal };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Pickup, AbilityFactory.Gluttony, };
		public override Ability AvailableHiddenAbility => AbilityFactory.QuickFeet;
		public override Stats BaseStats => new Stats() {
			HP = 38,
			Attack = 30,
			Defense = 41,
			SpecialAttack = 30,
			SpecialDefense = 41,
			Speed = 60
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Tackle, MoveFactory.Growl, },
			[3] = new List<Move>() { MoveFactory.SandAttack, },
			[6] = new List<Move>() { MoveFactory.TailWhip, },
			[9] = new List<Move>() { MoveFactory.Covet, },
			[12] = new List<Move>() { MoveFactory.Headbutt, },
			[15] = new List<Move>() { MoveFactory.BabyDollEyes, },
			[18] = new List<Move>() { MoveFactory.PinMissile, },
			[21] = new List<Move>() { MoveFactory.Rest, },
			[24] = new List<Move>() { MoveFactory.TakeDown, },
			[27] = new List<Move>() { MoveFactory.Fling, },
			[30] = new List<Move>() { MoveFactory.Flail, },
			[33] = new List<Move>() { MoveFactory.BellyDrum, },
			[36] = new List<Move>() { MoveFactory.DoubleEdge, },
		};
	}
}

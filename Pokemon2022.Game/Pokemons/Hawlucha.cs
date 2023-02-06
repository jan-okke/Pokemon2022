using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Hawlucha : Pokemon
	{
		public override string Name => "Hawlucha";
		public override int Generation => 6;
		public override string PokedexEntry => "With its wings, it controls its position in the air. It likes to attack from above, a maneuver that is difficult to defend against.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Fighting, PokemonType.Flying };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Limber, AbilityFactory.Unburden, };
		public override Ability AvailableHiddenAbility => AbilityFactory.MoldBreaker;
		public override Stats BaseStats => new Stats() {
			HP = 78,
			Attack = 92,
			Defense = 75,
			SpecialAttack = 74,
			SpecialDefense = 63,
			Speed = 118
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Tackle, MoveFactory.HoneClaws, },
			[4] = new List<Move>() { MoveFactory.WingAttack, },
			[8] = new List<Move>() { MoveFactory.Detect, },
			[12] = new List<Move>() { MoveFactory.AerialAce, },
			[16] = new List<Move>() { MoveFactory.Encore, },
			[20] = new List<Move>() { MoveFactory.FeatherDance, },
			[24] = new List<Move>() { MoveFactory.Submission, },
			[28] = new List<Move>() { MoveFactory.Bounce, },
			[32] = new List<Move>() { MoveFactory.Taunt, },
			[36] = new List<Move>() { MoveFactory.Roost, },
			[40] = new List<Move>() { MoveFactory.SwordsDance, },
			[44] = new List<Move>() { MoveFactory.FlyingPress, },
			[48] = new List<Move>() { MoveFactory.HighJumpKick, },
			[52] = new List<Move>() { MoveFactory.Endeavor, },
			[56] = new List<Move>() { MoveFactory.SkyAttack, },
		};
	}
}

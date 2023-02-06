using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Spinda : Pokemon
	{
		public override string Name => "Spinda";
		public override int Generation => 3;
		public override string PokedexEntry => "It is distinguished by a pattern of spots that is always different. Its unsteady, tottering walk has the effect of fouling its foe's aim.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Normal };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.OwnTempo, AbilityFactory.TangledFeet, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Contrary;
		public override Stats BaseStats => new Stats() {
			HP = 60,
			Attack = 60,
			Defense = 60,
			SpecialAttack = 60,
			SpecialDefense = 60,
			Speed = 60
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Tackle, },
			[5] = new List<Move>() { MoveFactory.Copycat, },
			[10] = new List<Move>() { MoveFactory.TeeterDance, },
			[14] = new List<Move>() { MoveFactory.Psybeam, },
			[19] = new List<Move>() { MoveFactory.Hypnosis, },
			[23] = new List<Move>() { MoveFactory.BodySlam, },
			[28] = new List<Move>() { MoveFactory.SuckerPunch, },
			[32] = new List<Move>() { MoveFactory.TeeterDance, },
			[37] = new List<Move>() { MoveFactory.Uproar, },
			[41] = new List<Move>() { MoveFactory.PsychUp, },
			[46] = new List<Move>() { MoveFactory.DoubleEdge, },
			[50] = new List<Move>() { MoveFactory.Flail, },
			[55] = new List<Move>() { MoveFactory.Thrash, },
		};
	}
}

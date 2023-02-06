using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Poliwag : Pokemon
	{
		public override string Name => "Poliwag";
		public override int Generation => 1;
		public override string PokedexEntry => "It is possible to see this Pokémon's spiral innards right through its thin skin. However, the skin is also very flexible. Even sharp fangs bounce right off it.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Water };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.WaterAbsorb, AbilityFactory.Damp, };
		public override Ability AvailableHiddenAbility => AbilityFactory.SwiftSwim;
		public override Stats BaseStats => new Stats() {
			HP = 40,
			Attack = 50,
			Defense = 40,
			SpecialAttack = 40,
			SpecialDefense = 40,
			Speed = 90
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.WaterGun, MoveFactory.Hypnosis, },
			[6] = new List<Move>() { MoveFactory.Pound, },
			[12] = new List<Move>() { MoveFactory.MudShot, },
			[18] = new List<Move>() { MoveFactory.BubbleBeam, },
			[24] = new List<Move>() { MoveFactory.RainDance, },
			[30] = new List<Move>() { MoveFactory.BodySlam, },
			[36] = new List<Move>() { MoveFactory.EarthPower, },
			[42] = new List<Move>() { MoveFactory.HydroPump, },
			[48] = new List<Move>() { MoveFactory.BellyDrum, },
			[54] = new List<Move>() { MoveFactory.DoubleEdge, },
		};
	}
}

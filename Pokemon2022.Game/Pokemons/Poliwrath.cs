using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Poliwrath : Pokemon
	{
		public override string Name => "Poliwrath";
		public override int Generation => 1;
		public override string PokedexEntry => "Its highly developed muscles never grow fatigued, however much it exercises. This Pokémon can swim back and forth across the Pacific Ocean without effort.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Water, PokemonType.Fighting };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.WaterAbsorb, AbilityFactory.Damp, };
		public override Ability AvailableHiddenAbility => AbilityFactory.SwiftSwim;
		public override Stats BaseStats => new Stats() {
			HP = 90,
			Attack = 95,
			Defense = 95,
			SpecialAttack = 70,
			SpecialDefense = 90,
			Speed = 70
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[0] = new List<Move>() { MoveFactory.Submission, },
			[1] = new List<Move>() { MoveFactory.Submission, MoveFactory.CircleThrow, MoveFactory.MindReader, MoveFactory.DynamicPunch, MoveFactory.BubbleBeam, MoveFactory.RainDance, MoveFactory.BodySlam, MoveFactory.EarthPower, MoveFactory.HydroPump, MoveFactory.BellyDrum, MoveFactory.DoubleEdge, MoveFactory.WaterGun, MoveFactory.Hypnosis, MoveFactory.Pound, MoveFactory.MudShot, },
		};
	}
}

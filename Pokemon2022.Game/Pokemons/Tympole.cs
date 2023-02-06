using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Tympole : Pokemon
	{
		public override string Name => "Tympole";
		public override int Generation => 5;
		public override string PokedexEntry => "By vibrating its cheeks, it emits sound waves imperceptible to humans. It uses the rhythm of these sounds to talk.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Water };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.SwiftSwim, AbilityFactory.Hydration, };
		public override Ability AvailableHiddenAbility => AbilityFactory.WaterAbsorb;
		public override Stats BaseStats => new Stats() {
			HP = 50,
			Attack = 50,
			Defense = 40,
			SpecialAttack = 50,
			SpecialDefense = 40,
			Speed = 64
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.EchoedVoice, MoveFactory.Growl, },
			[4] = new List<Move>() { MoveFactory.Acid, },
			[8] = new List<Move>() { MoveFactory.Supersonic, },
			[12] = new List<Move>() { MoveFactory.MudShot, },
			[16] = new List<Move>() { MoveFactory.Round, },
			[20] = new List<Move>() { MoveFactory.BubbleBeam, },
			[24] = new List<Move>() { MoveFactory.Flail, },
			[28] = new List<Move>() { MoveFactory.Uproar, },
			[32] = new List<Move>() { MoveFactory.AquaRing, },
			[36] = new List<Move>() { MoveFactory.HyperVoice, },
			[40] = new List<Move>() { MoveFactory.MuddyWater, },
			[44] = new List<Move>() { MoveFactory.RainDance, },
			[48] = new List<Move>() { MoveFactory.HydroPump, },
		};
	}
}

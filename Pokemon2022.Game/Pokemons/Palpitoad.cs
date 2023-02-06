using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Palpitoad : Pokemon
	{
		public override string Name => "Palpitoad";
		public override int Generation => 5;
		public override string PokedexEntry => "It lives in the water and on land. It uses its long, sticky tongue to capture prey.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Water, PokemonType.Ground };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.SwiftSwim, AbilityFactory.Hydration, };
		public override Ability AvailableHiddenAbility => AbilityFactory.WaterAbsorb;
		public override Stats BaseStats => new Stats() {
			HP = 75,
			Attack = 65,
			Defense = 55,
			SpecialAttack = 65,
			SpecialDefense = 55,
			Speed = 69
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.EchoedVoice, MoveFactory.Growl, MoveFactory.Acid, MoveFactory.Supersonic, },
			[12] = new List<Move>() { MoveFactory.MudShot, },
			[16] = new List<Move>() { MoveFactory.Round, },
			[20] = new List<Move>() { MoveFactory.BubbleBeam, },
			[24] = new List<Move>() { MoveFactory.Flail, },
			[30] = new List<Move>() { MoveFactory.Uproar, },
			[37] = new List<Move>() { MoveFactory.AquaRing, },
			[42] = new List<Move>() { MoveFactory.HyperVoice, },
			[48] = new List<Move>() { MoveFactory.MuddyWater, },
			[54] = new List<Move>() { MoveFactory.RainDance, },
			[60] = new List<Move>() { MoveFactory.HydroPump, },
		};
	}
}

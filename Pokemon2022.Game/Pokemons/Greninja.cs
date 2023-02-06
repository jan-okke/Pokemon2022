using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Greninja : Pokemon
	{
		public override string Name => "Greninja";
		public override int Generation => 6;
		public override string PokedexEntry => "It appears and vanishes with a ninja's grace. It toys with its enemies using swift movements, while slicing them with throwing stars of sharpest water.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Water, PokemonType.Dark };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Torrent, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Protean;
		public override Stats BaseStats => new Stats() {
			HP = 72,
			Attack = 95,
			Defense = 67,
			SpecialAttack = 103,
			SpecialDefense = 71,
			Speed = 122
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[0] = new List<Move>() { MoveFactory.WaterShuriken, },
			[1] = new List<Move>() { MoveFactory.WaterShuriken, MoveFactory.NightSlash, MoveFactory.Haze, MoveFactory.RolePlay, MoveFactory.MatBlock, MoveFactory.Pound, MoveFactory.Growl, MoveFactory.Bubble, MoveFactory.QuickAttack, },
			[5] = new List<Move>() { MoveFactory.Bubble, },
			[8] = new List<Move>() { MoveFactory.QuickAttack, },
			[10] = new List<Move>() { MoveFactory.Lick, },
			[14] = new List<Move>() { MoveFactory.WaterPulse, },
			[19] = new List<Move>() { MoveFactory.Smokescreen, },
			[23] = new List<Move>() { MoveFactory.ShadowSneak, },
			[28] = new List<Move>() { MoveFactory.Spikes, },
			[33] = new List<Move>() { MoveFactory.FeintAttack, },
			[42] = new List<Move>() { MoveFactory.Substitute, },
			[49] = new List<Move>() { MoveFactory.Extrasensory, },
			[56] = new List<Move>() { MoveFactory.DoubleTeam, },
			[68] = new List<Move>() { MoveFactory.HydroPump, },
			[70] = new List<Move>() { MoveFactory.Haze, },
			[77] = new List<Move>() { MoveFactory.NightSlash, },
		};
	}
}

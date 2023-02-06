using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Palossand : Pokemon
	{
		public override string Name => "Palossand";
		public override int Generation => 7;
		public override string PokedexEntry => "Buried beneath the castle are masses of dried-up bones from those whose vitality it has drained.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Ghost, PokemonType.Ground };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.WaterCompaction, };
		public override Ability AvailableHiddenAbility => AbilityFactory.SandVeil;
		public override Stats BaseStats => new Stats() {
			HP = 85,
			Attack = 75,
			Defense = 110,
			SpecialAttack = 100,
			SpecialDefense = 75,
			Speed = 35
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Absorb, MoveFactory.Harden, MoveFactory.Astonish, MoveFactory.SandTomb, },
			[15] = new List<Move>() { MoveFactory.MegaDrain, },
			[20] = new List<Move>() { MoveFactory.SandAttack, },
			[25] = new List<Move>() { MoveFactory.Bulldoze, },
			[30] = new List<Move>() { MoveFactory.Hypnosis, },
			[35] = new List<Move>() { MoveFactory.GigaDrain, },
			[40] = new List<Move>() { MoveFactory.IronDefense, },
			[47] = new List<Move>() { MoveFactory.ShadowBall, },
			[54] = new List<Move>() { MoveFactory.EarthPower, },
			[61] = new List<Move>() { MoveFactory.ShoreUp, },
			[68] = new List<Move>() { MoveFactory.Sandstorm, },
		};
	}
}

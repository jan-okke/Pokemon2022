using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Yamask : Pokemon
	{
		public override string Name => "Yamask";
		public override int Generation => 5;
		public override string PokedexEntry => "These Pokémon arose from the spirits of people interred in graves in past ages. Each retains memories of its former life.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Ghost };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Mummy, };
		public override Stats BaseStats => new Stats() {
			HP = 38,
			Attack = 30,
			Defense = 85,
			SpecialAttack = 55,
			SpecialDefense = 65,
			Speed = 30
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Astonish, MoveFactory.Protect, },
			[4] = new List<Move>() { MoveFactory.Haze, },
			[8] = new List<Move>() { MoveFactory.NightShade, },
			[12] = new List<Move>() { MoveFactory.Disable, },
			[16] = new List<Move>() { MoveFactory.WillOWisp, },
			[20] = new List<Move>() { MoveFactory.CraftyShield, },
			[24] = new List<Move>() { MoveFactory.Hex, },
			[28] = new List<Move>() { MoveFactory.MeanLook, },
			[32] = new List<Move>() { MoveFactory.Grudge, },
			[36] = new List<Move>() { MoveFactory.Curse, },
			[40] = new List<Move>() { MoveFactory.ShadowBall, },
			[44] = new List<Move>() { MoveFactory.DarkPulse, },
			[48] = new List<Move>() { MoveFactory.PowerSplit, MoveFactory.GuardSplit, },
			[52] = new List<Move>() { MoveFactory.DestinyBond, },
		};
	}
}

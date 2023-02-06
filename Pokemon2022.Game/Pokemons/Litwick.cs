using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Litwick : Pokemon
	{
		public override string Name => "Litwick";
		public override int Generation => 5;
		public override string PokedexEntry => "While shining a light and pretending to be a guide, it leeches off the life force of any who follow it.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Ghost, PokemonType.Fire };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.FlashFire, AbilityFactory.FlameBody, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Infiltrator;
		public override Stats BaseStats => new Stats() {
			HP = 50,
			Attack = 30,
			Defense = 55,
			SpecialAttack = 65,
			SpecialDefense = 55,
			Speed = 20
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Astonish, MoveFactory.Smog, },
			[4] = new List<Move>() { MoveFactory.Ember, },
			[8] = new List<Move>() { MoveFactory.Minimize, },
			[12] = new List<Move>() { MoveFactory.ConfuseRay, },
			[16] = new List<Move>() { MoveFactory.Hex, },
			[20] = new List<Move>() { MoveFactory.WillOWisp, },
			[24] = new List<Move>() { MoveFactory.FireSpin, },
			[28] = new List<Move>() { MoveFactory.NightShade, },
			[32] = new List<Move>() { MoveFactory.Curse, },
			[36] = new List<Move>() { MoveFactory.ShadowBall, },
			[40] = new List<Move>() { MoveFactory.Inferno, },
			[44] = new List<Move>() { MoveFactory.Imprison, },
			[48] = new List<Move>() { MoveFactory.PainSplit, },
			[52] = new List<Move>() { MoveFactory.Overheat, },
			[56] = new List<Move>() { MoveFactory.Memento, },
		};
	}
}

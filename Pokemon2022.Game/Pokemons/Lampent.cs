using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Lampent : Pokemon
	{
		public override string Name => "Lampent";
		public override int Generation => 5;
		public override string PokedexEntry => "It arrives near the moment of death and steals spirit from the body.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Ghost, PokemonType.Fire };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.FlashFire, AbilityFactory.FlameBody, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Infiltrator;
		public override Stats BaseStats => new Stats() {
			HP = 60,
			Attack = 40,
			Defense = 60,
			SpecialAttack = 95,
			SpecialDefense = 60,
			Speed = 55
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Astonish, MoveFactory.Smog, MoveFactory.Ember, MoveFactory.Minimize, },
			[12] = new List<Move>() { MoveFactory.ConfuseRay, },
			[16] = new List<Move>() { MoveFactory.Hex, },
			[20] = new List<Move>() { MoveFactory.WillOWisp, },
			[24] = new List<Move>() { MoveFactory.FireSpin, },
			[28] = new List<Move>() { MoveFactory.NightShade, },
			[32] = new List<Move>() { MoveFactory.Curse, },
			[36] = new List<Move>() { MoveFactory.ShadowBall, },
			[40] = new List<Move>() { MoveFactory.Inferno, },
			[46] = new List<Move>() { MoveFactory.Imprison, },
			[52] = new List<Move>() { MoveFactory.PainSplit, },
			[58] = new List<Move>() { MoveFactory.Overheat, },
			[64] = new List<Move>() { MoveFactory.Memento, },
		};
	}
}

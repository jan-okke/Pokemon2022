using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Blacephalon : Pokemon
	{
		public override string Name => "Blacephalon";
		public override int Generation => 7;
		public override string PokedexEntry => "It slithers toward people. Then, without warning, it triggers the explosion of its own head. It's apparently one kind of Ultra Beast.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Fire, PokemonType.Ghost };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.BeastBoost, };
		public override Stats BaseStats => new Stats() {
			HP = 53,
			Attack = 127,
			Defense = 53,
			SpecialAttack = 151,
			SpecialDefense = 79,
			Speed = 107
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Astonish, MoveFactory.FireSpin, },
			[5] = new List<Move>() { MoveFactory.LightScreen, },
			[10] = new List<Move>() { MoveFactory.Ember, },
			[15] = new List<Move>() { MoveFactory.NightShade, },
			[20] = new List<Move>() { MoveFactory.ConfuseRay, },
			[25] = new List<Move>() { MoveFactory.MagicCoat, },
			[30] = new List<Move>() { MoveFactory.Incinerate, },
			[35] = new List<Move>() { MoveFactory.Hypnosis, },
			[40] = new List<Move>() { MoveFactory.MysticalFire, },
			[45] = new List<Move>() { MoveFactory.ShadowBall, },
			[50] = new List<Move>() { MoveFactory.CalmMind, },
			[55] = new List<Move>() { MoveFactory.WillOWisp, },
			[60] = new List<Move>() { MoveFactory.Trick, },
			[65] = new List<Move>() { MoveFactory.FireBlast, },
			[70] = new List<Move>() { MoveFactory.MindBlown, },
		};
	}
}

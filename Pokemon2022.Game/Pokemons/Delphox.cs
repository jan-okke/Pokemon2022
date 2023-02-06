using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Delphox : Pokemon
	{
		public override string Name => "Delphox";
		public override int Generation => 6;
		public override string PokedexEntry => "It gazes into the flame at the tip of its branch to achieve a focused state, which allows it to see into the future.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Fire, PokemonType.Psychic };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Blaze, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Magician;
		public override Stats BaseStats => new Stats() {
			HP = 75,
			Attack = 69,
			Defense = 72,
			SpecialAttack = 114,
			SpecialDefense = 100,
			Speed = 104
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[0] = new List<Move>() { MoveFactory.MysticalFire, },
			[1] = new List<Move>() { MoveFactory.MysticalFire, MoveFactory.FutureSight, MoveFactory.RolePlay, MoveFactory.Switcheroo, MoveFactory.ShadowBall, MoveFactory.Scratch, MoveFactory.TailWhip, MoveFactory.Ember, MoveFactory.Howl, },
			[5] = new List<Move>() { MoveFactory.Ember, },
			[11] = new List<Move>() { MoveFactory.Howl, },
			[14] = new List<Move>() { MoveFactory.FlameCharge, },
			[18] = new List<Move>() { MoveFactory.Psybeam, },
			[22] = new List<Move>() { MoveFactory.FireSpin, },
			[28] = new List<Move>() { MoveFactory.LuckyChant, },
			[31] = new List<Move>() { MoveFactory.LightScreen, },
			[38] = new List<Move>() { MoveFactory.Psyshock, },
			[45] = new List<Move>() { MoveFactory.Flamethrower, },
			[51] = new List<Move>() { MoveFactory.WillOWisp, },
			[57] = new List<Move>() { MoveFactory.Psychic, },
			[62] = new List<Move>() { MoveFactory.SunnyDay, },
			[68] = new List<Move>() { MoveFactory.MagicRoom, },
			[74] = new List<Move>() { MoveFactory.FireBlast, },
			[80] = new List<Move>() { MoveFactory.FutureSight, },
		};
	}
}

using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Skitty : Pokemon
	{
		public override string Name => "Skitty";
		public override int Generation => 3;
		public override string PokedexEntry => "A Skitty's adorably cute behavior makes it highly popular. In battle, it makes its tail puff out. It threatens foes with a sharp growl.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Normal };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.CuteCharm, AbilityFactory.Normalize, };
		public override Ability AvailableHiddenAbility => AbilityFactory.WonderSkin;
		public override Stats BaseStats => new Stats() {
			HP = 50,
			Attack = 45,
			Defense = 45,
			SpecialAttack = 35,
			SpecialDefense = 35,
			Speed = 50
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.FakeOut, MoveFactory.Growl, MoveFactory.TailWhip, },
			[4] = new List<Move>() { MoveFactory.Tackle, },
			[7] = new List<Move>() { MoveFactory.Sing, },
			[10] = new List<Move>() { MoveFactory.Attract, },
			[13] = new List<Move>() { MoveFactory.DisarmingVoice, },
			[16] = new List<Move>() { MoveFactory.FurySwipes, },
			[19] = new List<Move>() { MoveFactory.Copycat, },
			[22] = new List<Move>() { MoveFactory.Payback, },
			[25] = new List<Move>() { MoveFactory.Charm, },
			[31] = new List<Move>() { MoveFactory.Facade, },
			[34] = new List<Move>() { MoveFactory.Covet, },
			[37] = new List<Move>() { MoveFactory.HealBell, },
			[40] = new List<Move>() { MoveFactory.DoubleEdge, },
			[43] = new List<Move>() { MoveFactory.BabyDollEyes, },
			[46] = new List<Move>() { MoveFactory.PlayRough, },
		};
	}
}

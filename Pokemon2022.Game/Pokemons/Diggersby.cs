using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Diggersby : Pokemon
	{
		public override string Name => "Diggersby";
		public override int Generation => 6;
		public override string PokedexEntry => "As powerful as an excavator, its ears can reduce dense bedrock to rubble. When it's finished digging, it lounges lazily.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Normal, PokemonType.Ground };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Pickup, AbilityFactory.CheekPouch, };
		public override Ability AvailableHiddenAbility => AbilityFactory.HugePower;
		public override Stats BaseStats => new Stats() {
			HP = 85,
			Attack = 56,
			Defense = 77,
			SpecialAttack = 50,
			SpecialDefense = 77,
			Speed = 78
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.MudSlap, MoveFactory.Leer, MoveFactory.Tackle, MoveFactory.LaserFocus, },
			[9] = new List<Move>() { MoveFactory.QuickAttack, },
			[12] = new List<Move>() { MoveFactory.MudShot, },
			[15] = new List<Move>() { MoveFactory.Flail, },
			[18] = new List<Move>() { MoveFactory.DoubleKick, },
			[23] = new List<Move>() { MoveFactory.Bulldoze, },
			[28] = new List<Move>() { MoveFactory.Dig, },
			[33] = new List<Move>() { MoveFactory.Bounce, },
			[38] = new List<Move>() { MoveFactory.TakeDown, },
			[43] = new List<Move>() { MoveFactory.SwordsDance, },
			[48] = new List<Move>() { MoveFactory.Earthquake, },
			[53] = new List<Move>() { MoveFactory.SuperFang, },
			[58] = new List<Move>() { MoveFactory.HammerArm, },
		};
	}
}

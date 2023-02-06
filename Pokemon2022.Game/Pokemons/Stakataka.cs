using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Stakataka : Pokemon
	{
		public override string Name => "Stakataka";
		public override int Generation => 7;
		public override string PokedexEntry => "When stone walls started moving and attacking, the brute's true identity was this mysterious life-form, which brings to mind an Ultra Beast.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Rock, PokemonType.Steel };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.BeastBoost, };
		public override Stats BaseStats => new Stats() {
			HP = 61,
			Attack = 131,
			Defense = 211,
			SpecialAttack = 53,
			SpecialDefense = 101,
			Speed = 13
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Tackle, MoveFactory.Harden, },
			[5] = new List<Move>() { MoveFactory.RockThrow, },
			[10] = new List<Move>() { MoveFactory.Protect, },
			[15] = new List<Move>() { MoveFactory.Stomp, },
			[20] = new List<Move>() { MoveFactory.Block, },
			[25] = new List<Move>() { MoveFactory.RockSlide, },
			[30] = new List<Move>() { MoveFactory.WideGuard, },
			[35] = new List<Move>() { MoveFactory.Autotomize, },
			[40] = new List<Move>() { MoveFactory.RockBlast, },
			[45] = new List<Move>() { MoveFactory.MagnetRise, },
			[50] = new List<Move>() { MoveFactory.IronDefense, },
			[55] = new List<Move>() { MoveFactory.IronHead, },
			[60] = new List<Move>() { MoveFactory.TakeDown, },
			[65] = new List<Move>() { MoveFactory.StealthRock, },
			[70] = new List<Move>() { MoveFactory.DoubleEdge, },
		};
	}
}

using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Mawile : Pokemon
	{
		public override string Name => "Mawile";
		public override int Generation => 3;
		public override string PokedexEntry => "Its giant jaws are actually steel horns that transformed. It fools foes into complacency with its adorable gestures, then chomps them with its huge jaws.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Steel, PokemonType.Fairy };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.HyperCutter, AbilityFactory.Intimidate, };
		public override Ability AvailableHiddenAbility => AbilityFactory.SheerForce;
		public override Stats BaseStats => new Stats() {
			HP = 50,
			Attack = 85,
			Defense = 85,
			SpecialAttack = 55,
			SpecialDefense = 55,
			Speed = 50
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Astonish, MoveFactory.Growl, },
			[4] = new List<Move>() { MoveFactory.FairyWind, },
			[8] = new List<Move>() { MoveFactory.BatonPass, },
			[12] = new List<Move>() { MoveFactory.Bite, },
			[16] = new List<Move>() { MoveFactory.Stockpile, MoveFactory.Swallow, MoveFactory.SpitUp, },
			[20] = new List<Move>() { MoveFactory.SuckerPunch, },
			[24] = new List<Move>() { MoveFactory.IronDefense, },
			[28] = new List<Move>() { MoveFactory.Crunch, },
			[32] = new List<Move>() { MoveFactory.SweetScent, },
			[36] = new List<Move>() { MoveFactory.IronHead, },
			[40] = new List<Move>() { MoveFactory.Taunt, },
			[44] = new List<Move>() { MoveFactory.FakeTears, },
			[48] = new List<Move>() { MoveFactory.PlayRough, },
		};
	}
}

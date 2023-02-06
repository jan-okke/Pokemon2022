using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Swirlix : Pokemon
	{
		public override string Name => "Swirlix";
		public override int Generation => 6;
		public override string PokedexEntry => "To entangle its opponents in battle, it extrudes white threads as sweet and sticky as cotton candy.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Fairy };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.SweetVeil, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Unburden;
		public override Stats BaseStats => new Stats() {
			HP = 62,
			Attack = 48,
			Defense = 66,
			SpecialAttack = 59,
			SpecialDefense = 57,
			Speed = 49
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Tackle, MoveFactory.SweetScent, },
			[3] = new List<Move>() { MoveFactory.PlayNice, },
			[6] = new List<Move>() { MoveFactory.FairyWind, },
			[9] = new List<Move>() { MoveFactory.Aromatherapy, },
			[12] = new List<Move>() { MoveFactory.DrainingKiss, },
			[15] = new List<Move>() { MoveFactory.FakeTears, },
			[18] = new List<Move>() { MoveFactory.Round, },
			[21] = new List<Move>() { MoveFactory.StringShot, },
			[24] = new List<Move>() { MoveFactory.CottonSpore, },
			[27] = new List<Move>() { MoveFactory.EnergyBall, },
			[30] = new List<Move>() { MoveFactory.Wish, },
			[33] = new List<Move>() { MoveFactory.PlayRough, },
			[36] = new List<Move>() { MoveFactory.CottonGuard, },
			[39] = new List<Move>() { MoveFactory.Endeavor, },
		};
	}
}

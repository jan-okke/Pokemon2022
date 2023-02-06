using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Slurpuff : Pokemon
	{
		public override string Name => "Slurpuff";
		public override int Generation => 6;
		public override string PokedexEntry => "It can distinguish the faintest of scents. It puts its sensitive sense of smell to use by helping pastry chefs in their work.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Fairy };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.SweetVeil, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Unburden;
		public override Stats BaseStats => new Stats() {
			HP = 82,
			Attack = 80,
			Defense = 86,
			SpecialAttack = 85,
			SpecialDefense = 75,
			Speed = 72
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Tackle, MoveFactory.SweetScent, MoveFactory.PlayNice, MoveFactory.FairyWind, },
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
			[42] = new List<Move>() { MoveFactory.StickyWeb, },
		};
	}
}

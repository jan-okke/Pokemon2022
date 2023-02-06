using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Ribombee : Pokemon
	{
		public override string Name => "Ribombee";
		public override int Generation => 7;
		public override string PokedexEntry => "Rain makes pollen damp, so Ribombee hates rain. When it sees ominous clouds, it finds a hollow in a tree, where it waits stock-still.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Bug, PokemonType.Fairy };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.HoneyGather, AbilityFactory.ShieldDust, };
		public override Ability AvailableHiddenAbility => AbilityFactory.SweetVeil;
		public override Stats BaseStats => new Stats() {
			HP = 60,
			Attack = 55,
			Defense = 60,
			SpecialAttack = 95,
			SpecialDefense = 70,
			Speed = 124
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[0] = new List<Move>() { MoveFactory.PollenPuff, },
			[1] = new List<Move>() { MoveFactory.PollenPuff, MoveFactory.Covet, MoveFactory.Absorb, MoveFactory.FairyWind, MoveFactory.StunSpore, MoveFactory.SweetScent, },
			[18] = new List<Move>() { MoveFactory.DrainingKiss, },
			[24] = new List<Move>() { MoveFactory.StruggleBug, },
			[32] = new List<Move>() { MoveFactory.Aromatherapy, },
			[40] = new List<Move>() { MoveFactory.Switcheroo, },
			[48] = new List<Move>() { MoveFactory.DazzlingGleam, },
			[56] = new List<Move>() { MoveFactory.BugBuzz, },
			[64] = new List<Move>() { MoveFactory.QuiverDance, },
		};
	}
}

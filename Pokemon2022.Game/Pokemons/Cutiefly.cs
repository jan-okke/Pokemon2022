using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Cutiefly : Pokemon
	{
		public override string Name => "Cutiefly";
		public override int Generation => 7;
		public override string PokedexEntry => "It feeds on the nectar and pollen of flowers. Because it's able to sense auras, it can identify which flowers are about to bloom.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Bug, PokemonType.Fairy };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.HoneyGather, AbilityFactory.ShieldDust, };
		public override Ability AvailableHiddenAbility => AbilityFactory.SweetVeil;
		public override Stats BaseStats => new Stats() {
			HP = 40,
			Attack = 45,
			Defense = 40,
			SpecialAttack = 55,
			SpecialDefense = 40,
			Speed = 84
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Absorb, MoveFactory.FairyWind, },
			[6] = new List<Move>() { MoveFactory.StunSpore, },
			[12] = new List<Move>() { MoveFactory.SweetScent, },
			[18] = new List<Move>() { MoveFactory.DrainingKiss, },
			[24] = new List<Move>() { MoveFactory.StruggleBug, },
			[30] = new List<Move>() { MoveFactory.Aromatherapy, },
			[36] = new List<Move>() { MoveFactory.Switcheroo, },
			[42] = new List<Move>() { MoveFactory.DazzlingGleam, },
			[48] = new List<Move>() { MoveFactory.BugBuzz, },
			[54] = new List<Move>() { MoveFactory.QuiverDance, },
		};
	}
}

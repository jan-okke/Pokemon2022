using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Vivillon : Pokemon
	{
		public override string Name => "Vivillon";
		public override int Generation => 6;
		public override string PokedexEntry => "Vivillon with many different patterns are found all over the world. These patterns are affected by the climate of their habitat.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Bug, PokemonType.Flying };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.ShieldDust, AbilityFactory.CompoundEyes, };
		public override Ability AvailableHiddenAbility => AbilityFactory.FriendGuard;
		public override Stats BaseStats => new Stats() {
			HP = 80,
			Attack = 52,
			Defense = 50,
			SpecialAttack = 90,
			SpecialDefense = 50,
			Speed = 89
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[0] = new List<Move>() { MoveFactory.Gust, },
			[1] = new List<Move>() { MoveFactory.Gust, MoveFactory.Powder, MoveFactory.SleepPowder, MoveFactory.PoisonPowder, MoveFactory.StunSpore, MoveFactory.StruggleBug, },
			[12] = new List<Move>() { MoveFactory.LightScreen, },
			[17] = new List<Move>() { MoveFactory.Psybeam, },
			[21] = new List<Move>() { MoveFactory.Supersonic, },
			[25] = new List<Move>() { MoveFactory.DrainingKiss, },
			[31] = new List<Move>() { MoveFactory.Aromatherapy, },
			[35] = new List<Move>() { MoveFactory.BugBuzz, },
			[41] = new List<Move>() { MoveFactory.Safeguard, },
			[45] = new List<Move>() { MoveFactory.QuiverDance, },
			[50] = new List<Move>() { MoveFactory.Hurricane, },
			[55] = new List<Move>() { MoveFactory.Powder, },
		};
	}
}

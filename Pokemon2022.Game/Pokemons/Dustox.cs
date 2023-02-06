using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Dustox : Pokemon
	{
		public override string Name => "Dustox";
		public override int Generation => 3;
		public override string PokedexEntry => "It is a nocturnal Pokémon that flies from fields and mountains to the attraction of streetlights at night. It looses highly toxic powder from its wings.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Bug, PokemonType.Poison };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.ShieldDust, };
		public override Ability AvailableHiddenAbility => AbilityFactory.CompoundEyes;
		public override Stats BaseStats => new Stats() {
			HP = 60,
			Attack = 50,
			Defense = 70,
			SpecialAttack = 50,
			SpecialDefense = 90,
			Speed = 65
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[0] = new List<Move>() { MoveFactory.Gust, },
			[1] = new List<Move>() { MoveFactory.Gust, },
			[12] = new List<Move>() { MoveFactory.Confusion, },
			[15] = new List<Move>() { MoveFactory.PoisonPowder, },
			[17] = new List<Move>() { MoveFactory.Moonlight, },
			[20] = new List<Move>() { MoveFactory.Venoshock, },
			[22] = new List<Move>() { MoveFactory.Psybeam, },
			[25] = new List<Move>() { MoveFactory.LeechLife, },
			[27] = new List<Move>() { MoveFactory.LightScreen, },
			[30] = new List<Move>() { MoveFactory.Whirlwind, },
			[32] = new List<Move>() { MoveFactory.Toxic, },
			[35] = new List<Move>() { MoveFactory.BugBuzz, },
			[37] = new List<Move>() { MoveFactory.Protect, },
			[40] = new List<Move>() { MoveFactory.QuiverDance, },
		};
	}
}

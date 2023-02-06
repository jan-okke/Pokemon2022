using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Nickit : Pokemon
	{
		public override string Name => "Nickit";
		public override int Generation => 8;
		public override string PokedexEntry => "Aided by the soft pads on its feet, it silently raids the food stores of other Pokémon. It survives off its ill-gotten gains.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Dark };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.RunAway, AbilityFactory.Unburden, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Stakeout;
		public override Stats BaseStats => new Stats() {
			HP = 40,
			Attack = 28,
			Defense = 28,
			SpecialAttack = 47,
			SpecialDefense = 52,
			Speed = 50
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.QuickAttack, MoveFactory.TailWhip, },
			[4] = new List<Move>() { MoveFactory.BeatUp, },
			[8] = new List<Move>() { MoveFactory.HoneClaws, },
			[12] = new List<Move>() { MoveFactory.Snarl, },
			[16] = new List<Move>() { MoveFactory.Assurance, },
			[20] = new List<Move>() { MoveFactory.NastyPlot, },
			[24] = new List<Move>() { MoveFactory.SuckerPunch, },
			[28] = new List<Move>() { MoveFactory.NightSlash, },
			[32] = new List<Move>() { MoveFactory.TailSlap, },
			[36] = new List<Move>() { MoveFactory.FoulPlay, },
		};
	}
}

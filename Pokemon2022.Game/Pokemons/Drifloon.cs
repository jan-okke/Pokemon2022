using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Drifloon : Pokemon
	{
		public override string Name => "Drifloon";
		public override int Generation => 4;
		public override string PokedexEntry => "A Pokémon formed by the spirits of people and Pokémon. It loves damp, humid seasons.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Ghost, PokemonType.Flying };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Aftermath, AbilityFactory.Unburden, };
		public override Ability AvailableHiddenAbility => AbilityFactory.FlareBoost;
		public override Stats BaseStats => new Stats() {
			HP = 90,
			Attack = 50,
			Defense = 34,
			SpecialAttack = 60,
			SpecialDefense = 44,
			Speed = 70
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Minimize, MoveFactory.Astonish, },
			[4] = new List<Move>() { MoveFactory.Gust, },
			[8] = new List<Move>() { MoveFactory.FocusEnergy, },
			[12] = new List<Move>() { MoveFactory.Payback, },
			[16] = new List<Move>() { MoveFactory.Hex, },
			[20] = new List<Move>() { MoveFactory.ShadowBall, },
			[24] = new List<Move>() { MoveFactory.Stockpile, MoveFactory.Swallow, MoveFactory.SpitUp, },
			[29] = new List<Move>() { MoveFactory.SelfDestruct, },
			[32] = new List<Move>() { MoveFactory.DestinyBond, },
			[36] = new List<Move>() { MoveFactory.BatonPass, },
			[40] = new List<Move>() { MoveFactory.Tailwind, },
			[44] = new List<Move>() { MoveFactory.Explosion, },
		};
	}
}

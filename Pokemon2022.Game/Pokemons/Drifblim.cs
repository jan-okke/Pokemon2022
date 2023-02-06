using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Drifblim : Pokemon
	{
		public override string Name => "Drifblim";
		public override int Generation => 4;
		public override string PokedexEntry => "It's drowzy in daytime, but flies off in the evening in big groups. No one knows where they go.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Ghost, PokemonType.Flying };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Aftermath, AbilityFactory.Unburden, };
		public override Ability AvailableHiddenAbility => AbilityFactory.FlareBoost;
		public override Stats BaseStats => new Stats() {
			HP = 150,
			Attack = 80,
			Defense = 44,
			SpecialAttack = 90,
			SpecialDefense = 54,
			Speed = 80
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[0] = new List<Move>() { MoveFactory.PhantomForce, },
			[1] = new List<Move>() { MoveFactory.PhantomForce, MoveFactory.StrengthSap, MoveFactory.Minimize, MoveFactory.Astonish, MoveFactory.Gust, MoveFactory.FocusEnergy, },
			[12] = new List<Move>() { MoveFactory.Payback, },
			[16] = new List<Move>() { MoveFactory.Hex, },
			[20] = new List<Move>() { MoveFactory.ShadowBall, },
			[24] = new List<Move>() { MoveFactory.Stockpile, MoveFactory.Swallow, MoveFactory.SpitUp, },
			[31] = new List<Move>() { MoveFactory.SelfDestruct, },
			[36] = new List<Move>() { MoveFactory.DestinyBond, },
			[42] = new List<Move>() { MoveFactory.BatonPass, },
			[48] = new List<Move>() { MoveFactory.Tailwind, },
			[54] = new List<Move>() { MoveFactory.Explosion, },
		};
	}
}

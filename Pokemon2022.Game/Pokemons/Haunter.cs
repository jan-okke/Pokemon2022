using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Haunter : Pokemon
	{
		public override string Name => "Haunter";
		public override int Generation => 1;
		public override string PokedexEntry => "If a Haunter beckons you while it is floating in darkness, don't approach it. This Pokémon will try to lick you with its tongue and steal your life away.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Ghost, PokemonType.Poison };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Levitate, };
		public override Stats BaseStats => new Stats() {
			HP = 45,
			Attack = 50,
			Defense = 45,
			SpecialAttack = 115,
			SpecialDefense = 55,
			Speed = 95
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[0] = new List<Move>() { MoveFactory.ShadowPunch, },
			[1] = new List<Move>() { MoveFactory.ShadowPunch, MoveFactory.Lick, MoveFactory.ConfuseRay, MoveFactory.Hypnosis, MoveFactory.MeanLook, },
			[12] = new List<Move>() { MoveFactory.Payback, },
			[16] = new List<Move>() { MoveFactory.Spite, },
			[20] = new List<Move>() { MoveFactory.Curse, },
			[24] = new List<Move>() { MoveFactory.Hex, },
			[30] = new List<Move>() { MoveFactory.NightShade, },
			[36] = new List<Move>() { MoveFactory.SuckerPunch, },
			[42] = new List<Move>() { MoveFactory.DarkPulse, },
			[48] = new List<Move>() { MoveFactory.ShadowBall, },
			[54] = new List<Move>() { MoveFactory.DestinyBond, },
			[60] = new List<Move>() { MoveFactory.DreamEater, },
		};
	}
}

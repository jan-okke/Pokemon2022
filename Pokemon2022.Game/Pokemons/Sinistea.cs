using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Sinistea : Pokemon
	{
		public override string Name => "Sinistea";
		public override int Generation => 8;
		public override string PokedexEntry => "The teacup in which this Pokémon makes its home is a famous piece of antique tableware. Many forgeries are in circulation.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Ghost };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.WeakArmor, };
		public override Ability AvailableHiddenAbility => AbilityFactory.CursedBody;
		public override Stats BaseStats => new Stats() {
			HP = 40,
			Attack = 45,
			Defense = 45,
			SpecialAttack = 74,
			SpecialDefense = 54,
			Speed = 50
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Astonish, MoveFactory.Withdraw, },
			[6] = new List<Move>() { MoveFactory.AromaticMist, },
			[12] = new List<Move>() { MoveFactory.MegaDrain, },
			[18] = new List<Move>() { MoveFactory.Protect, },
			[24] = new List<Move>() { MoveFactory.SuckerPunch, },
			[30] = new List<Move>() { MoveFactory.Aromatherapy, },
			[36] = new List<Move>() { MoveFactory.GigaDrain, },
			[42] = new List<Move>() { MoveFactory.NastyPlot, },
			[48] = new List<Move>() { MoveFactory.ShadowBall, },
			[54] = new List<Move>() { MoveFactory.Memento, },
			[60] = new List<Move>() { MoveFactory.ShellSmash, },
		};
	}
}

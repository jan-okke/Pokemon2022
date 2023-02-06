using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Polteageist : Pokemon
	{
		public override string Name => "Polteageist";
		public override int Generation => 8;
		public override string PokedexEntry => "This species lives in antique teapots. Most pots are forgeries, but on rare occasions, an authentic work is found.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Ghost };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.WeakArmor, };
		public override Ability AvailableHiddenAbility => AbilityFactory.CursedBody;
		public override Stats BaseStats => new Stats() {
			HP = 60,
			Attack = 65,
			Defense = 65,
			SpecialAttack = 134,
			SpecialDefense = 114,
			Speed = 70
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[0] = new List<Move>() { MoveFactory.Teatime, },
			[1] = new List<Move>() { MoveFactory.Teatime, MoveFactory.StrengthSap, MoveFactory.Astonish, MoveFactory.Withdraw, MoveFactory.AromaticMist, MoveFactory.MegaDrain, },
			[18] = new List<Move>() { MoveFactory.Protect, },
			[24] = new List<Move>() { MoveFactory.SuckerPunch, },
			[30] = new List<Move>() { MoveFactory.Aromatherapy, },
			[36] = new List<Move>() { MoveFactory.GigaDrain, },
			[42] = new List<Move>() { MoveFactory.NastyPlot, },
			[48] = new List<Move>() { MoveFactory.ShadowBall, },
			[54] = new List<Move>() { MoveFactory.Memento, },
			[60] = new List<Move>() { MoveFactory.ShellSmash, },
			[66] = new List<Move>() { MoveFactory.Curse, },
		};
	}
}

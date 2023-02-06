using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Liepard : Pokemon
	{
		public override string Name => "Liepard";
		public override int Generation => 5;
		public override string PokedexEntry => "Stealthily, it sneaks up on its target, striking from behind before its victim has a chance to react.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Dark };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Limber, AbilityFactory.Unburden, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Prankster;
		public override Stats BaseStats => new Stats() {
			HP = 64,
			Attack = 88,
			Defense = 50,
			SpecialAttack = 88,
			SpecialDefense = 50,
			Speed = 106
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Scratch, MoveFactory.Growl, MoveFactory.SandAttack, MoveFactory.FakeOut, },
			[12] = new List<Move>() { MoveFactory.FurySwipes, },
			[16] = new List<Move>() { MoveFactory.Torment, },
			[23] = new List<Move>() { MoveFactory.Assurance, },
			[28] = new List<Move>() { MoveFactory.HoneClaws, },
			[34] = new List<Move>() { MoveFactory.SuckerPunch, },
			[40] = new List<Move>() { MoveFactory.NastyPlot, },
			[46] = new List<Move>() { MoveFactory.NightSlash, },
			[52] = new List<Move>() { MoveFactory.PlayRough, },
		};
	}
}

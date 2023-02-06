using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Purrloin : Pokemon
	{
		public override string Name => "Purrloin";
		public override int Generation => 5;
		public override string PokedexEntry => "Its cute act is a ruse. When victims let down their guard, they find their items taken. It attacks with sharp claws.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Dark };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Limber, AbilityFactory.Unburden, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Prankster;
		public override Stats BaseStats => new Stats() {
			HP = 41,
			Attack = 50,
			Defense = 37,
			SpecialAttack = 50,
			SpecialDefense = 37,
			Speed = 66
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Scratch, MoveFactory.Growl, },
			[4] = new List<Move>() { MoveFactory.SandAttack, },
			[5] = new List<Move>() { MoveFactory.FakeOut, },
			[12] = new List<Move>() { MoveFactory.FurySwipes, },
			[16] = new List<Move>() { MoveFactory.Torment, },
			[21] = new List<Move>() { MoveFactory.Assurance, },
			[24] = new List<Move>() { MoveFactory.HoneClaws, },
			[28] = new List<Move>() { MoveFactory.SuckerPunch, },
			[32] = new List<Move>() { MoveFactory.NastyPlot, },
			[36] = new List<Move>() { MoveFactory.NightSlash, },
			[40] = new List<Move>() { MoveFactory.PlayRough, },
		};
	}
}

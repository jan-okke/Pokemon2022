using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Persian : Pokemon
	{
		public override string Name => "Persian";
		public override int Generation => 1;
		public override string PokedexEntry => "A Persian's six bold whiskers sense air movements to determine what is in its vicinity. It becomes docile if grabbed by the whiskers.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Normal };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Limber, AbilityFactory.Technician, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Unnerve;
		public override Stats BaseStats => new Stats() {
			HP = 65,
			Attack = 70,
			Defense = 60,
			SpecialAttack = 65,
			SpecialDefense = 65,
			Speed = 115
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[0] = new List<Move>() { MoveFactory.PowerGem, },
			[1] = new List<Move>() { MoveFactory.PowerGem, MoveFactory.Switcheroo, MoveFactory.FakeOut, MoveFactory.Growl, MoveFactory.Feint, MoveFactory.Scratch, },
			[12] = new List<Move>() { MoveFactory.PayDay, },
			[16] = new List<Move>() { MoveFactory.Bite, },
			[20] = new List<Move>() { MoveFactory.Taunt, },
			[24] = new List<Move>() { MoveFactory.Assurance, },
			[31] = new List<Move>() { MoveFactory.FurySwipes, },
			[36] = new List<Move>() { MoveFactory.Screech, },
			[42] = new List<Move>() { MoveFactory.Slash, },
			[48] = new List<Move>() { MoveFactory.NastyPlot, },
			[54] = new List<Move>() { MoveFactory.PlayRough, },
		};
	}
}

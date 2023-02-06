using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Chimecho : Pokemon
	{
		public override string Name => "Chimecho";
		public override int Generation => 3;
		public override string PokedexEntry => "They fly about very actively when the hot season arrives. They communicate among themselves using seven different and distinguishing cries.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Psychic };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Levitate, };
		public override Stats BaseStats => new Stats() {
			HP = 75,
			Attack = 50,
			Defense = 80,
			SpecialAttack = 95,
			SpecialDefense = 90,
			Speed = 65
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.HealingWish, MoveFactory.Wrap, MoveFactory.Growl, MoveFactory.Astonish, MoveFactory.Confusion, },
			[4] = new List<Move>() { MoveFactory.Growl, },
			[7] = new List<Move>() { MoveFactory.Astonish, },
			[10] = new List<Move>() { MoveFactory.Confusion, },
			[13] = new List<Move>() { MoveFactory.Yawn, },
			[16] = new List<Move>() { MoveFactory.LightScreen, },
			[19] = new List<Move>() { MoveFactory.TakeDown, },
			[22] = new List<Move>() { MoveFactory.Extrasensory, },
			[27] = new List<Move>() { MoveFactory.HealBell, },
			[32] = new List<Move>() { MoveFactory.Uproar, },
			[37] = new List<Move>() { MoveFactory.Safeguard, },
			[42] = new List<Move>() { MoveFactory.DoubleEdge, },
			[47] = new List<Move>() { MoveFactory.HealPulse, },
			[52] = new List<Move>() { MoveFactory.Psychic, },
			[57] = new List<Move>() { MoveFactory.HealingWish, },
		};
	}
}

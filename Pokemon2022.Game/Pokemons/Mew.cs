using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Mew : Pokemon
	{
		public override string Name => "Mew";
		public override int Generation => 1;
		public override string PokedexEntry => "A Mew is said to possess the genes of all Pokémon. It is capable of making itself invisible at will, so it entirely avoids notice even if it approaches people.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Psychic };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Synchronize, };
		public override Stats BaseStats => new Stats() {
			HP = 100,
			Attack = 100,
			Defense = 100,
			SpecialAttack = 100,
			SpecialDefense = 100,
			Speed = 100
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Pound, MoveFactory.ReflectType, },
			[10] = new List<Move>() { MoveFactory.Amnesia, },
			[20] = new List<Move>() { MoveFactory.BatonPass, },
			[30] = new List<Move>() { MoveFactory.AncientPower, },
			[40] = new List<Move>() { MoveFactory.LifeDew, },
			[50] = new List<Move>() { MoveFactory.NastyPlot, },
			[60] = new List<Move>() { MoveFactory.Metronome, },
			[70] = new List<Move>() { MoveFactory.Imprison, },
			[80] = new List<Move>() { MoveFactory.Transform, },
			[90] = new List<Move>() { MoveFactory.AuraSphere, },
			[100] = new List<Move>() { MoveFactory.Psychic, },
		};
	}
}

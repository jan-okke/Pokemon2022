using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Victini : Pokemon
	{
		public override string Name => "Victini";
		public override int Generation => 5;
		public override string PokedexEntry => "This Pokémon brings victory. It is said that Trainers with Victini always win, regardless of the type of encounter.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Psychic, PokemonType.Fire };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.VictoryStar, };
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
			[1] = new List<Move>() { MoveFactory.Vcreate, MoveFactory.QuickAttack, MoveFactory.FlameCharge, MoveFactory.Confusion, MoveFactory.FocusEnergy, },
			[7] = new List<Move>() { MoveFactory.WorkUp, },
			[14] = new List<Move>() { MoveFactory.Incinerate, },
			[21] = new List<Move>() { MoveFactory.StoredPower, },
			[28] = new List<Move>() { MoveFactory.Headbutt, },
			[35] = new List<Move>() { MoveFactory.Endure, },
			[42] = new List<Move>() { MoveFactory.ZenHeadbutt, },
			[49] = new List<Move>() { MoveFactory.Inferno, },
			[56] = new List<Move>() { MoveFactory.Reversal, },
			[63] = new List<Move>() { MoveFactory.SearingShot, },
			[70] = new List<Move>() { MoveFactory.DoubleEdge, },
			[77] = new List<Move>() { MoveFactory.FlareBlitz, },
			[84] = new List<Move>() { MoveFactory.Overheat, },
			[91] = new List<Move>() { MoveFactory.FinalGambit, },
		};
	}
}

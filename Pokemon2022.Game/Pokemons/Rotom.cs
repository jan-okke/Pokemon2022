using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Rotom : Pokemon
	{
		public override string Name => "Rotom";
		public override int Generation => 4;
		public override string PokedexEntry => "Its body is composed of plasma. It is known to infiltrate electronic devices and wreak havoc.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Electric, PokemonType.Ghost };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Levitate, };
		public override Stats BaseStats => new Stats() {
			HP = 50,
			Attack = 50,
			Defense = 77,
			SpecialAttack = 95,
			SpecialDefense = 77,
			Speed = 91
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Astonish, MoveFactory.DoubleTeam, },
			[5] = new List<Move>() { MoveFactory.ThunderShock, },
			[10] = new List<Move>() { MoveFactory.ConfuseRay, },
			[15] = new List<Move>() { MoveFactory.Charge, },
			[20] = new List<Move>() { MoveFactory.ElectroBall, },
			[25] = new List<Move>() { MoveFactory.ThunderWave, },
			[30] = new List<Move>() { MoveFactory.ShockWave, },
			[35] = new List<Move>() { MoveFactory.Hex, },
			[40] = new List<Move>() { MoveFactory.Substitute, },
			[45] = new List<Move>() { MoveFactory.Trick, },
			[50] = new List<Move>() { MoveFactory.Discharge, },
			[55] = new List<Move>() { MoveFactory.Uproar, },
		};
	}
}

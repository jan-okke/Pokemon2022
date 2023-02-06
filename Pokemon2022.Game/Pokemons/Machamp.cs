using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Machamp : Pokemon
	{
		public override string Name => "Machamp";
		public override int Generation => 1;
		public override string PokedexEntry => "It is impossible to defend against punches and chops doled out by its four arms. Its fighting spirit flares up when it faces a tough opponent.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Fighting };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Guts, AbilityFactory.NoGuard, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Steadfast;
		public override Stats BaseStats => new Stats() {
			HP = 90,
			Attack = 130,
			Defense = 80,
			SpecialAttack = 65,
			SpecialDefense = 85,
			Speed = 55
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.WideGuard, MoveFactory.LowKick, MoveFactory.Leer, MoveFactory.FocusEnergy, MoveFactory.Revenge, },
			[12] = new List<Move>() { MoveFactory.LowSweep, },
			[16] = new List<Move>() { MoveFactory.KnockOff, },
			[20] = new List<Move>() { MoveFactory.ScaryFace, },
			[24] = new List<Move>() { MoveFactory.VitalThrow, },
			[31] = new List<Move>() { MoveFactory.Strength, },
			[36] = new List<Move>() { MoveFactory.DualChop, },
			[42] = new List<Move>() { MoveFactory.BulkUp, },
			[48] = new List<Move>() { MoveFactory.SeismicToss, },
			[54] = new List<Move>() { MoveFactory.DynamicPunch, },
			[60] = new List<Move>() { MoveFactory.CrossChop, },
			[66] = new List<Move>() { MoveFactory.DoubleEdge, },
		};
	}
}

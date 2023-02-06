using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Machoke : Pokemon
	{
		public override string Name => "Machoke";
		public override int Generation => 1;
		public override string PokedexEntry => "A belt is worn by a Machoke to keep its overwhelming power under control. Because it is so dangerous, no one has ever removed the belt.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Fighting };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Guts, AbilityFactory.NoGuard, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Steadfast;
		public override Stats BaseStats => new Stats() {
			HP = 80,
			Attack = 100,
			Defense = 70,
			SpecialAttack = 50,
			SpecialDefense = 60,
			Speed = 45
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.LowKick, MoveFactory.Leer, MoveFactory.FocusEnergy, MoveFactory.Revenge, },
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

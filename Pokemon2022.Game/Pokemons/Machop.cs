using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Machop : Pokemon
	{
		public override string Name => "Machop";
		public override int Generation => 1;
		public override string PokedexEntry => "It continually undertakes strenuous training to master all forms of martial arts. Its strength lets it easily hoist a sumo wrestler onto its shoulders.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Fighting };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Guts, AbilityFactory.NoGuard, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Steadfast;
		public override Stats BaseStats => new Stats() {
			HP = 70,
			Attack = 80,
			Defense = 50,
			SpecialAttack = 35,
			SpecialDefense = 35,
			Speed = 35
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.LowKick, MoveFactory.Leer, },
			[4] = new List<Move>() { MoveFactory.FocusEnergy, },
			[8] = new List<Move>() { MoveFactory.Revenge, },
			[12] = new List<Move>() { MoveFactory.LowSweep, },
			[16] = new List<Move>() { MoveFactory.KnockOff, },
			[20] = new List<Move>() { MoveFactory.ScaryFace, },
			[24] = new List<Move>() { MoveFactory.VitalThrow, },
			[29] = new List<Move>() { MoveFactory.Strength, },
			[32] = new List<Move>() { MoveFactory.DualChop, },
			[36] = new List<Move>() { MoveFactory.BulkUp, },
			[40] = new List<Move>() { MoveFactory.SeismicToss, },
			[44] = new List<Move>() { MoveFactory.DynamicPunch, },
			[48] = new List<Move>() { MoveFactory.CrossChop, },
			[52] = new List<Move>() { MoveFactory.DoubleEdge, },
		};
	}
}

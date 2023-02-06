using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Hitmontop : Pokemon
	{
		public override string Name => "Hitmontop";
		public override int Generation => 2;
		public override string PokedexEntry => "Its technique of kicking while spinning is a remarkable mix of both offense and defense. Hitmontop travel faster spinning than they do walking.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Fighting };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Intimidate, AbilityFactory.Technician, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Steadfast;
		public override Stats BaseStats => new Stats() {
			HP = 50,
			Attack = 95,
			Defense = 95,
			SpecialAttack = 35,
			SpecialDefense = 110,
			Speed = 70
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[0] = new List<Move>() { MoveFactory.TripleKick, },
			[1] = new List<Move>() { MoveFactory.TripleKick, MoveFactory.Feint, MoveFactory.RapidSpin, MoveFactory.Tackle, MoveFactory.HelpingHand, MoveFactory.FakeOut, MoveFactory.FocusEnergy, },
			[4] = new List<Move>() { MoveFactory.QuickAttack, },
			[8] = new List<Move>() { MoveFactory.GyroBall, },
			[12] = new List<Move>() { MoveFactory.Detect, },
			[16] = new List<Move>() { MoveFactory.Revenge, },
			[21] = new List<Move>() { MoveFactory.WideGuard, MoveFactory.QuickGuard, },
			[24] = new List<Move>() { MoveFactory.SuckerPunch, },
			[28] = new List<Move>() { MoveFactory.Agility, },
			[32] = new List<Move>() { MoveFactory.Dig, },
			[36] = new List<Move>() { MoveFactory.CloseCombat, },
			[40] = new List<Move>() { MoveFactory.Counter, },
			[44] = new List<Move>() { MoveFactory.Endeavor, },
		};
	}
}

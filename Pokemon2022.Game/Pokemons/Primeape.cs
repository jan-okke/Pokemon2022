using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Primeape : Pokemon
	{
		public override string Name => "Primeape";
		public override int Generation => 1;
		public override string PokedexEntry => "When it becomes furious, its blood circulation becomes more robust, and its muscles are made stronger. But it also becomes much less intelligent.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Fighting };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.VitalSpirit, AbilityFactory.AngerPoint, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Defiant;
		public override Stats BaseStats => new Stats() {
			HP = 65,
			Attack = 105,
			Defense = 60,
			SpecialAttack = 60,
			SpecialDefense = 70,
			Speed = 95
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.FinalGambit, MoveFactory.Fling, MoveFactory.Scratch, MoveFactory.LowKick, MoveFactory.Leer, MoveFactory.FocusEnergy, },
			[5] = new List<Move>() { MoveFactory.FurySwipes, },
			[8] = new List<Move>() { MoveFactory.MudSlap, },
			[12] = new List<Move>() { MoveFactory.SeismicToss, },
			[15] = new List<Move>() { MoveFactory.Retaliate, },
			[19] = new List<Move>() { MoveFactory.Swagger, },
			[22] = new List<Move>() { MoveFactory.CrossChop, },
			[26] = new List<Move>() { MoveFactory.Assurance, },
			[30] = new List<Move>() { MoveFactory.SkullBash, },
			[35] = new List<Move>() { MoveFactory.Thrash, },
			[39] = new List<Move>() { MoveFactory.CloseCombat, },
			[44] = new List<Move>() { MoveFactory.Screech, },
			[48] = new List<Move>() { MoveFactory.StompingTantrum, },
			[53] = new List<Move>() { MoveFactory.Outrage, },
			[57] = new List<Move>() { MoveFactory.FinalGambit, },
		};
	}
}

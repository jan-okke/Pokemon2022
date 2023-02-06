using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Mankey : Pokemon
	{
		public override string Name => "Mankey";
		public override int Generation => 1;
		public override string PokedexEntry => "When it starts shaking and its nasal breathing turns rough, it's a sure sign of anger. However, since this happens instantly, there is no time to flee.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Fighting };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.VitalSpirit, AbilityFactory.AngerPoint, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Defiant;
		public override Stats BaseStats => new Stats() {
			HP = 40,
			Attack = 80,
			Defense = 35,
			SpecialAttack = 35,
			SpecialDefense = 45,
			Speed = 70
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Covet, MoveFactory.Scratch, MoveFactory.LowKick, MoveFactory.Leer, MoveFactory.FocusEnergy, },
			[5] = new List<Move>() { MoveFactory.FurySwipes, },
			[8] = new List<Move>() { MoveFactory.MudSlap, },
			[12] = new List<Move>() { MoveFactory.SeismicToss, },
			[15] = new List<Move>() { MoveFactory.Retaliate, },
			[19] = new List<Move>() { MoveFactory.Swagger, },
			[22] = new List<Move>() { MoveFactory.CrossChop, },
			[26] = new List<Move>() { MoveFactory.Assurance, },
			[29] = new List<Move>() { MoveFactory.SkullBash, },
			[33] = new List<Move>() { MoveFactory.Thrash, },
			[36] = new List<Move>() { MoveFactory.CloseCombat, },
			[40] = new List<Move>() { MoveFactory.Screech, },
			[43] = new List<Move>() { MoveFactory.StompingTantrum, },
			[47] = new List<Move>() { MoveFactory.Outrage, },
			[50] = new List<Move>() { MoveFactory.FinalGambit, },
		};
	}
}

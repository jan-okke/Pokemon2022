using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Riolu : Pokemon
	{
		public override string Name => "Riolu";
		public override int Generation => 4;
		public override string PokedexEntry => "The aura that emanates from its body intensifies to alert others if it is afraid or sad.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Fighting };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Steadfast, AbilityFactory.InnerFocus, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Prankster;
		public override Stats BaseStats => new Stats() {
			HP = 40,
			Attack = 70,
			Defense = 40,
			SpecialAttack = 35,
			SpecialDefense = 40,
			Speed = 60
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.QuickAttack, MoveFactory.Endure, },
			[4] = new List<Move>() { MoveFactory.Feint, },
			[8] = new List<Move>() { MoveFactory.MetalClaw, },
			[12] = new List<Move>() { MoveFactory.Counter, },
			[16] = new List<Move>() { MoveFactory.WorkUp, },
			[20] = new List<Move>() { MoveFactory.RockSmash, },
			[24] = new List<Move>() { MoveFactory.NastyPlot, },
			[28] = new List<Move>() { MoveFactory.Screech, },
			[32] = new List<Move>() { MoveFactory.QuickGuard, },
			[36] = new List<Move>() { MoveFactory.ForcePalm, },
			[40] = new List<Move>() { MoveFactory.SwordsDance, },
			[44] = new List<Move>() { MoveFactory.HelpingHand, },
			[48] = new List<Move>() { MoveFactory.Copycat, },
			[52] = new List<Move>() { MoveFactory.FinalGambit, },
			[56] = new List<Move>() { MoveFactory.Reversal, },
		};
	}
}

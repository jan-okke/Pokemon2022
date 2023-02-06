using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Lucario : Pokemon
	{
		public override string Name => "Lucario";
		public override int Generation => 4;
		public override string PokedexEntry => "It has the ability to sense the auras of all things. It understands human speech.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Fighting, PokemonType.Steel };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Steadfast, AbilityFactory.InnerFocus, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Justified;
		public override Stats BaseStats => new Stats() {
			HP = 70,
			Attack = 110,
			Defense = 70,
			SpecialAttack = 115,
			SpecialDefense = 70,
			Speed = 90
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[0] = new List<Move>() { MoveFactory.AuraSphere, },
			[1] = new List<Move>() { MoveFactory.AuraSphere, MoveFactory.LifeDew, MoveFactory.WorkUp, MoveFactory.RockSmash, MoveFactory.NastyPlot, MoveFactory.Screech, MoveFactory.ForcePalm, MoveFactory.HelpingHand, MoveFactory.Copycat, MoveFactory.FinalGambit, MoveFactory.Reversal, MoveFactory.QuickAttack, MoveFactory.Detect, MoveFactory.Feint, MoveFactory.MetalClaw, },
			[12] = new List<Move>() { MoveFactory.Counter, },
			[16] = new List<Move>() { MoveFactory.LaserFocus, },
			[20] = new List<Move>() { MoveFactory.PowerUpPunch, },
			[24] = new List<Move>() { MoveFactory.CalmMind, },
			[28] = new List<Move>() { MoveFactory.MetalSound, },
			[32] = new List<Move>() { MoveFactory.QuickGuard, },
			[36] = new List<Move>() { MoveFactory.BoneRush, },
			[40] = new List<Move>() { MoveFactory.SwordsDance, },
			[44] = new List<Move>() { MoveFactory.HealPulse, },
			[48] = new List<Move>() { MoveFactory.MeteorMash, },
			[52] = new List<Move>() { MoveFactory.DragonPulse, },
			[56] = new List<Move>() { MoveFactory.ExtremeSpeed, },
			[60] = new List<Move>() { MoveFactory.CloseCombat, },
		};
	}
}

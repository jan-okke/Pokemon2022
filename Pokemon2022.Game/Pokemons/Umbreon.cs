using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Umbreon : Pokemon
	{
		public override string Name => "Umbreon";
		public override int Generation => 2;
		public override string PokedexEntry => "Umbreon evolved from exposure to the moon's energy pulses. It lurks in darkness and waits for its foes to move. The rings on its body glow when it leaps to attack.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Dark };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Synchronize, };
		public override Ability AvailableHiddenAbility => AbilityFactory.InnerFocus;
		public override Stats BaseStats => new Stats() {
			HP = 95,
			Attack = 65,
			Defense = 110,
			SpecialAttack = 60,
			SpecialDefense = 130,
			Speed = 65
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[0] = new List<Move>() { MoveFactory.Snarl, },
			[1] = new List<Move>() { MoveFactory.FoulPlay, MoveFactory.Snarl, MoveFactory.Covet, MoveFactory.Swift, MoveFactory.Bite, MoveFactory.Copycat, MoveFactory.BatonPass, MoveFactory.TakeDown, MoveFactory.Charm, MoveFactory.DoubleEdge, MoveFactory.HelpingHand, MoveFactory.Tackle, MoveFactory.Growl, MoveFactory.TailWhip, },
			[5] = new List<Move>() { MoveFactory.SandAttack, },
			[10] = new List<Move>() { MoveFactory.QuickAttack, },
			[15] = new List<Move>() { MoveFactory.BabyDollEyes, },
			[20] = new List<Move>() { MoveFactory.ConfuseRay, },
			[25] = new List<Move>() { MoveFactory.Assurance, },
			[30] = new List<Move>() { MoveFactory.Moonlight, },
			[35] = new List<Move>() { MoveFactory.GuardSwap, },
			[40] = new List<Move>() { MoveFactory.DarkPulse, },
			[45] = new List<Move>() { MoveFactory.Screech, },
			[50] = new List<Move>() { MoveFactory.MeanLook, },
			[55] = new List<Move>() { MoveFactory.LastResort, },
		};
	}
}

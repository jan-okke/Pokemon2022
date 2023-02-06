using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Sylveon : Pokemon
	{
		public override string Name => "Sylveon";
		public override int Generation => 6;
		public override string PokedexEntry => "Its ribbonlike feelers give off an aura that weakens hostility in its prey, causing them to let down their guard. Then it attacks.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Fairy };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.CuteCharm, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Pixilate;
		public override Stats BaseStats => new Stats() {
			HP = 95,
			Attack = 65,
			Defense = 65,
			SpecialAttack = 110,
			SpecialDefense = 130,
			Speed = 60
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[0] = new List<Move>() { MoveFactory.DisarmingVoice, },
			[1] = new List<Move>() { MoveFactory.DisarmingVoice, MoveFactory.Covet, MoveFactory.Bite, MoveFactory.Copycat, MoveFactory.BatonPass, MoveFactory.TakeDown, MoveFactory.Charm, MoveFactory.DoubleEdge, MoveFactory.HelpingHand, MoveFactory.Tackle, MoveFactory.Growl, MoveFactory.TailWhip, },
			[5] = new List<Move>() { MoveFactory.SandAttack, },
			[10] = new List<Move>() { MoveFactory.QuickAttack, },
			[15] = new List<Move>() { MoveFactory.BabyDollEyes, },
			[20] = new List<Move>() { MoveFactory.Swift, },
			[25] = new List<Move>() { MoveFactory.LightScreen, },
			[30] = new List<Move>() { MoveFactory.DrainingKiss, },
			[35] = new List<Move>() { MoveFactory.MistyTerrain, },
			[40] = new List<Move>() { MoveFactory.SkillSwap, },
			[45] = new List<Move>() { MoveFactory.PsychUp, },
			[50] = new List<Move>() { MoveFactory.Moonblast, },
			[55] = new List<Move>() { MoveFactory.LastResort, },
		};
	}
}

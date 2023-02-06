using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Jolteon : Pokemon
	{
		public override string Name => "Jolteon";
		public override int Generation => 1;
		public override string PokedexEntry => "Its cells generate weak power that is amplified by its fur's static electricity to drop thunderbolts. The bristling fur is made of electrically charged needles.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Electric };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.VoltAbsorb, };
		public override Ability AvailableHiddenAbility => AbilityFactory.QuickFeet;
		public override Stats BaseStats => new Stats() {
			HP = 65,
			Attack = 65,
			Defense = 60,
			SpecialAttack = 110,
			SpecialDefense = 95,
			Speed = 130
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[0] = new List<Move>() { MoveFactory.ThunderShock, },
			[1] = new List<Move>() { MoveFactory.ThunderShock, MoveFactory.Covet, MoveFactory.Swift, MoveFactory.Bite, MoveFactory.Copycat, MoveFactory.BatonPass, MoveFactory.TakeDown, MoveFactory.Charm, MoveFactory.DoubleEdge, MoveFactory.HelpingHand, MoveFactory.Tackle, MoveFactory.Growl, MoveFactory.TailWhip, },
			[5] = new List<Move>() { MoveFactory.SandAttack, },
			[10] = new List<Move>() { MoveFactory.QuickAttack, },
			[15] = new List<Move>() { MoveFactory.BabyDollEyes, },
			[20] = new List<Move>() { MoveFactory.ThunderWave, },
			[25] = new List<Move>() { MoveFactory.DoubleKick, },
			[30] = new List<Move>() { MoveFactory.ThunderFang, },
			[35] = new List<Move>() { MoveFactory.PinMissile, },
			[40] = new List<Move>() { MoveFactory.Discharge, },
			[45] = new List<Move>() { MoveFactory.Agility, },
			[50] = new List<Move>() { MoveFactory.Thunder, },
			[55] = new List<Move>() { MoveFactory.LastResort, },
		};
	}
}

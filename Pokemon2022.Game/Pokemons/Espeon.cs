using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Espeon : Pokemon
	{
		public override string Name => "Espeon";
		public override int Generation => 2;
		public override string PokedexEntry => "An Espeon is extremely loyal to any trainer it considers to be worthy. It is said to have developed precognitive powers to protect its trainer from harm.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Psychic };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Synchronize, };
		public override Ability AvailableHiddenAbility => AbilityFactory.MagicBounce;
		public override Stats BaseStats => new Stats() {
			HP = 65,
			Attack = 65,
			Defense = 60,
			SpecialAttack = 130,
			SpecialDefense = 95,
			Speed = 110
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[0] = new List<Move>() { MoveFactory.Confusion, },
			[1] = new List<Move>() { MoveFactory.Confusion, MoveFactory.Covet, MoveFactory.Bite, MoveFactory.Copycat, MoveFactory.BatonPass, MoveFactory.TakeDown, MoveFactory.Charm, MoveFactory.DoubleEdge, MoveFactory.HelpingHand, MoveFactory.Tackle, MoveFactory.Growl, MoveFactory.TailWhip, },
			[5] = new List<Move>() { MoveFactory.SandAttack, },
			[10] = new List<Move>() { MoveFactory.QuickAttack, },
			[15] = new List<Move>() { MoveFactory.BabyDollEyes, },
			[20] = new List<Move>() { MoveFactory.Swift, },
			[25] = new List<Move>() { MoveFactory.Psybeam, },
			[30] = new List<Move>() { MoveFactory.MorningSun, },
			[35] = new List<Move>() { MoveFactory.PowerSwap, },
			[40] = new List<Move>() { MoveFactory.Psychic, },
			[45] = new List<Move>() { MoveFactory.PsychUp, },
			[50] = new List<Move>() { MoveFactory.FutureSight, },
			[55] = new List<Move>() { MoveFactory.LastResort, },
		};
	}
}

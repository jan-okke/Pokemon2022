using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Leavanny : Pokemon
	{
		public override string Name => "Leavanny";
		public override int Generation => 5;
		public override string PokedexEntry => "It keeps its eggs warm with heat from fermenting leaves. It also uses leaves to make warm wrappings for Sewaddle.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Bug, PokemonType.Grass };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Swarm, AbilityFactory.Chlorophyll, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Overcoat;
		public override Stats BaseStats => new Stats() {
			HP = 75,
			Attack = 103,
			Defense = 80,
			SpecialAttack = 70,
			SpecialDefense = 80,
			Speed = 92
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[0] = new List<Move>() { MoveFactory.Slash, },
			[1] = new List<Move>() { MoveFactory.Slash, MoveFactory.FalseSwipe, MoveFactory.Tackle, MoveFactory.StringShot, MoveFactory.BugBite, MoveFactory.RazorLeaf, },
			[8] = new List<Move>() { MoveFactory.BugBite, },
			[15] = new List<Move>() { MoveFactory.RazorLeaf, },
			[22] = new List<Move>() { MoveFactory.StruggleBug, },
			[29] = new List<Move>() { MoveFactory.FellStinger, },
			[32] = new List<Move>() { MoveFactory.HelpingHand, },
			[36] = new List<Move>() { MoveFactory.LeafBlade, },
			[39] = new List<Move>() { MoveFactory.XScissor, },
			[43] = new List<Move>() { MoveFactory.Entrainment, },
			[46] = new List<Move>() { MoveFactory.SwordsDance, },
			[50] = new List<Move>() { MoveFactory.LeafStorm, },
		};
	}
}

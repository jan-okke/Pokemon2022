using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Leafeon : Pokemon
	{
		public override string Name => "Leafeon";
		public override int Generation => 4;
		public override string PokedexEntry => "Just like a plant, it uses photosynthesis. As a result, it is always enveloped in clear air.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Grass };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.LeafGuard, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Chlorophyll;
		public override Stats BaseStats => new Stats() {
			HP = 65,
			Attack = 110,
			Defense = 130,
			SpecialAttack = 60,
			SpecialDefense = 65,
			Speed = 95
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[0] = new List<Move>() { MoveFactory.RazorLeaf, },
			[1] = new List<Move>() { MoveFactory.RazorLeaf, MoveFactory.Covet, MoveFactory.Swift, MoveFactory.Bite, MoveFactory.Copycat, MoveFactory.BatonPass, MoveFactory.TakeDown, MoveFactory.Charm, MoveFactory.DoubleEdge, MoveFactory.HelpingHand, MoveFactory.Tackle, MoveFactory.Growl, MoveFactory.TailWhip, },
			[5] = new List<Move>() { MoveFactory.SandAttack, },
			[10] = new List<Move>() { MoveFactory.QuickAttack, },
			[15] = new List<Move>() { MoveFactory.BabyDollEyes, },
			[20] = new List<Move>() { MoveFactory.LeechSeed, },
			[25] = new List<Move>() { MoveFactory.MagicalLeaf, },
			[30] = new List<Move>() { MoveFactory.Synthesis, },
			[35] = new List<Move>() { MoveFactory.SunnyDay, },
			[40] = new List<Move>() { MoveFactory.GigaDrain, },
			[45] = new List<Move>() { MoveFactory.SwordsDance, },
			[50] = new List<Move>() { MoveFactory.LeafBlade, },
			[55] = new List<Move>() { MoveFactory.LastResort, },
		};
	}
}

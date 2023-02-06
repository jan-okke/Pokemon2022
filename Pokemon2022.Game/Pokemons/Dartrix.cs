using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Dartrix : Pokemon
	{
		public override string Name => "Dartrix";
		public override int Generation => 7;
		public override string PokedexEntry => "A bit of a dandy, it spends its free time preening its wings. Its preoccupation with any dirt on its plumage can leave it unable to battle.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Grass, PokemonType.Flying };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Overgrow, };
		public override Ability AvailableHiddenAbility => AbilityFactory.LongReach;
		public override Stats BaseStats => new Stats() {
			HP = 78,
			Attack = 75,
			Defense = 75,
			SpecialAttack = 70,
			SpecialDefense = 70,
			Speed = 52
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Tackle, MoveFactory.Growl, MoveFactory.Leafage, MoveFactory.Astonish, },
			[9] = new List<Move>() { MoveFactory.Peck, },
			[12] = new List<Move>() { MoveFactory.ShadowSneak, },
			[15] = new List<Move>() { MoveFactory.RazorLeaf, },
			[20] = new List<Move>() { MoveFactory.Synthesis, },
			[25] = new List<Move>() { MoveFactory.Pluck, },
			[30] = new List<Move>() { MoveFactory.NastyPlot, },
			[35] = new List<Move>() { MoveFactory.SuckerPunch, },
			[40] = new List<Move>() { MoveFactory.LeafBlade, },
			[45] = new List<Move>() { MoveFactory.FeatherDance, },
			[50] = new List<Move>() { MoveFactory.BraveBird, },
		};
	}
}

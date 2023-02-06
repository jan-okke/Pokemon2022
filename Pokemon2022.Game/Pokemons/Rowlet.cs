using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Rowlet : Pokemon
	{
		public override string Name => "Rowlet";
		public override int Generation => 7;
		public override string PokedexEntry => "It sends its feathers, which are as sharp as blades, flying in attack. Its legs are strong, so its kicks are also formidable.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Grass, PokemonType.Flying };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Overgrow, };
		public override Ability AvailableHiddenAbility => AbilityFactory.LongReach;
		public override Stats BaseStats => new Stats() {
			HP = 68,
			Attack = 55,
			Defense = 55,
			SpecialAttack = 50,
			SpecialDefense = 50,
			Speed = 42
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Tackle, MoveFactory.Growl, },
			[3] = new List<Move>() { MoveFactory.Leafage, },
			[6] = new List<Move>() { MoveFactory.Astonish, },
			[9] = new List<Move>() { MoveFactory.Peck, },
			[12] = new List<Move>() { MoveFactory.ShadowSneak, },
			[15] = new List<Move>() { MoveFactory.RazorLeaf, },
			[18] = new List<Move>() { MoveFactory.Synthesis, },
			[21] = new List<Move>() { MoveFactory.Pluck, },
			[24] = new List<Move>() { MoveFactory.NastyPlot, },
			[27] = new List<Move>() { MoveFactory.SuckerPunch, },
			[30] = new List<Move>() { MoveFactory.LeafBlade, },
			[33] = new List<Move>() { MoveFactory.FeatherDance, },
			[36] = new List<Move>() { MoveFactory.BraveBird, },
		};
	}
}

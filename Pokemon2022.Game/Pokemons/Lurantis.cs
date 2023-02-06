using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Lurantis : Pokemon
	{
		public override string Name => "Lurantis";
		public override int Generation => 7;
		public override string PokedexEntry => "It requires a lot of effort to maintain Lurantis's vivid coloring, but some collectors enjoy this work and treat it as their hobby.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Grass };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.LeafGuard, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Contrary;
		public override Stats BaseStats => new Stats() {
			HP = 70,
			Attack = 105,
			Defense = 90,
			SpecialAttack = 80,
			SpecialDefense = 90,
			Speed = 45
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[0] = new List<Move>() { MoveFactory.PetalBlizzard, },
			[1] = new List<Move>() { MoveFactory.PetalBlizzard, MoveFactory.NightSlash, MoveFactory.SolarBeam, MoveFactory.DualChop, MoveFactory.Leafage, MoveFactory.FuryCutter, MoveFactory.Growth, MoveFactory.Ingrain, },
			[15] = new List<Move>() { MoveFactory.RazorLeaf, },
			[20] = new List<Move>() { MoveFactory.SweetScent, },
			[25] = new List<Move>() { MoveFactory.Slash, },
			[30] = new List<Move>() { MoveFactory.XScissor, },
			[37] = new List<Move>() { MoveFactory.Synthesis, },
			[44] = new List<Move>() { MoveFactory.LeafBlade, },
			[51] = new List<Move>() { MoveFactory.SunnyDay, },
			[63] = new List<Move>() { MoveFactory.SolarBlade, },
		};
	}
}

using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Serperior : Pokemon
	{
		public override string Name => "Serperior";
		public override int Generation => 5;
		public override string PokedexEntry => "They raise their heads to intimidate opponents, but only give it their all when fighting a powerful opponent.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Grass };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Overgrow, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Contrary;
		public override Stats BaseStats => new Stats() {
			HP = 75,
			Attack = 75,
			Defense = 95,
			SpecialAttack = 75,
			SpecialDefense = 95,
			Speed = 113
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Tackle, MoveFactory.Leer, MoveFactory.VineWhip, MoveFactory.Wrap, },
			[4] = new List<Move>() { MoveFactory.Leer, },
			[7] = new List<Move>() { MoveFactory.VineWhip, },
			[10] = new List<Move>() { MoveFactory.Wrap, },
			[13] = new List<Move>() { MoveFactory.Growth, },
			[16] = new List<Move>() { MoveFactory.LeafTornado, },
			[20] = new List<Move>() { MoveFactory.LeechSeed, },
			[24] = new List<Move>() { MoveFactory.MegaDrain, },
			[28] = new List<Move>() { MoveFactory.Slam, },
			[32] = new List<Move>() { MoveFactory.LeafBlade, },
			[38] = new List<Move>() { MoveFactory.Coil, },
			[44] = new List<Move>() { MoveFactory.GigaDrain, },
			[50] = new List<Move>() { MoveFactory.WringOut, },
			[56] = new List<Move>() { MoveFactory.GastroAcid, },
			[62] = new List<Move>() { MoveFactory.LeafStorm, },
		};
	}
}

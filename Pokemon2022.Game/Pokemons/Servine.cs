using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Servine : Pokemon
	{
		public override string Name => "Servine";
		public override int Generation => 5;
		public override string PokedexEntry => "They avoid attacks by sinking into the shadows of thick foliage. They retaliate with masterful whipping techniques.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Grass };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Overgrow, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Contrary;
		public override Stats BaseStats => new Stats() {
			HP = 60,
			Attack = 60,
			Defense = 75,
			SpecialAttack = 60,
			SpecialDefense = 75,
			Speed = 83
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
			[36] = new List<Move>() { MoveFactory.Coil, },
			[40] = new List<Move>() { MoveFactory.GigaDrain, },
			[44] = new List<Move>() { MoveFactory.WringOut, },
			[48] = new List<Move>() { MoveFactory.GastroAcid, },
			[52] = new List<Move>() { MoveFactory.LeafStorm, },
		};
	}
}

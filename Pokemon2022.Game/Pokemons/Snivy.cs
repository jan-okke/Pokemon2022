using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Snivy : Pokemon
	{
		public override string Name => "Snivy";
		public override int Generation => 5;
		public override string PokedexEntry => "They photosynthesize by bathing their tails in sunlight. When they are not feeling well, their tails droop.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Grass };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Overgrow, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Contrary;
		public override Stats BaseStats => new Stats() {
			HP = 45,
			Attack = 45,
			Defense = 55,
			SpecialAttack = 45,
			SpecialDefense = 55,
			Speed = 63
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Tackle, },
			[4] = new List<Move>() { MoveFactory.Leer, },
			[7] = new List<Move>() { MoveFactory.VineWhip, },
			[10] = new List<Move>() { MoveFactory.Wrap, },
			[13] = new List<Move>() { MoveFactory.Growth, },
			[16] = new List<Move>() { MoveFactory.LeafTornado, },
			[19] = new List<Move>() { MoveFactory.LeechSeed, },
			[22] = new List<Move>() { MoveFactory.MegaDrain, },
			[25] = new List<Move>() { MoveFactory.Slam, },
			[28] = new List<Move>() { MoveFactory.LeafBlade, },
			[31] = new List<Move>() { MoveFactory.Coil, },
			[34] = new List<Move>() { MoveFactory.GigaDrain, },
			[37] = new List<Move>() { MoveFactory.WringOut, },
			[40] = new List<Move>() { MoveFactory.GastroAcid, },
			[43] = new List<Move>() { MoveFactory.LeafStorm, },
		};
	}
}

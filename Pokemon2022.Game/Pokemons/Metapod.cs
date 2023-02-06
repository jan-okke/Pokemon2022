using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Metapod : Pokemon
	{
		public override string Name => "Metapod";
		public override int Generation => 1;
		public override string PokedexEntry => "Its shell is as hard as an iron slab. A Metapod does not move very much because it is preparing its soft innards for evolution inside the shell.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Bug };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.ShedSkin, };
		public override Stats BaseStats => new Stats() {
			HP = 50,
			Attack = 20,
			Defense = 55,
			SpecialAttack = 25,
			SpecialDefense = 25,
			Speed = 30
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[0] = new List<Move>() { MoveFactory.Harden, },
			[1] = new List<Move>() { MoveFactory.Harden, },
		};
	}
}

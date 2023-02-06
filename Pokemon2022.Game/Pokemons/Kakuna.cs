using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Kakuna : Pokemon
	{
		public override string Name => "Kakuna";
		public override int Generation => 1;
		public override string PokedexEntry => "It remains virtually immobile while it clings to a tree. However, on the inside, it busily prepares for evolution. This is evident from how hot its shell becomes.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Bug, PokemonType.Poison };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.ShedSkin, };
		public override Stats BaseStats => new Stats() {
			HP = 45,
			Attack = 25,
			Defense = 50,
			SpecialAttack = 25,
			SpecialDefense = 25,
			Speed = 35
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[0] = new List<Move>() { MoveFactory.Harden, },
			[1] = new List<Move>() { MoveFactory.Harden, },
		};
	}
}

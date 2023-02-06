using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Cosmoem : Pokemon
	{
		public override string Name => "Cosmoem";
		public override int Generation => 7;
		public override string PokedexEntry => "Motionless as if dead, its body is faintly warm to the touch. In the distant past, it was called the cocoon of the stars.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Psychic };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Sturdy, };
		public override Stats BaseStats => new Stats() {
			HP = 43,
			Attack = 29,
			Defense = 131,
			SpecialAttack = 29,
			SpecialDefense = 131,
			Speed = 37
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[0] = new List<Move>() { MoveFactory.CosmicPower, },
			[1] = new List<Move>() { MoveFactory.CosmicPower, MoveFactory.Teleport, },
		};
	}
}

using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Tynamo : Pokemon
	{
		public override string Name => "Tynamo";
		public override int Generation => 5;
		public override string PokedexEntry => "These Pokémon move in schools. They have an electricity-generating organ, so they discharge electricity if in danger.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Electric };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Levitate, };
		public override Stats BaseStats => new Stats() {
			HP = 35,
			Attack = 55,
			Defense = 40,
			SpecialAttack = 45,
			SpecialDefense = 40,
			Speed = 60
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Tackle, MoveFactory.ThunderWave, MoveFactory.Spark, MoveFactory.ChargeBeam, },
		};
	}
}

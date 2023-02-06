using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Ditto : Pokemon
	{
		public override string Name => "Ditto";
		public override int Generation => 1;
		public override string PokedexEntry => "A Ditto rearranges its cell structure to transform itself. However, if it tries to change based on its memory, it will get details wrong.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Normal };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Limber, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Imposter;
		public override Stats BaseStats => new Stats() {
			HP = 48,
			Attack = 48,
			Defense = 48,
			SpecialAttack = 48,
			SpecialDefense = 48,
			Speed = 48
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Transform, },
		};
	}
}

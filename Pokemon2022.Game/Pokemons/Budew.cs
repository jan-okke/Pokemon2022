using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Budew : Pokemon
	{
		public override string Name => "Budew";
		public override int Generation => 4;
		public override string PokedexEntry => "Over the winter, it closes its bud and endures the cold. In spring, the bud opens and releases pollen.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Grass, PokemonType.Poison };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.NaturalCure, AbilityFactory.PoisonPoint, };
		public override Ability AvailableHiddenAbility => AbilityFactory.LeafGuard;
		public override Stats BaseStats => new Stats() {
			HP = 40,
			Attack = 30,
			Defense = 35,
			SpecialAttack = 50,
			SpecialDefense = 70,
			Speed = 55
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Absorb, MoveFactory.Growth, MoveFactory.StunSpore, MoveFactory.WorrySeed, },
		};
	}
}

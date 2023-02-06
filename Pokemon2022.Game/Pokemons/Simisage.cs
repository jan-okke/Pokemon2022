using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Simisage : Pokemon
	{
		public override string Name => "Simisage";
		public override int Generation => 5;
		public override string PokedexEntry => "Ill tempered, it fights by swinging its barbed tail around wildly. The leaf growing on its head is very bitter.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Grass };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Gluttony, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Overgrow;
		public override Stats BaseStats => new Stats() {
			HP = 75,
			Attack = 98,
			Defense = 63,
			SpecialAttack = 98,
			SpecialDefense = 63,
			Speed = 101
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Leer, MoveFactory.Lick, MoveFactory.FurySwipes, MoveFactory.SeedBomb, },
		};
	}
}

using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Chingling : Pokemon
	{
		public override string Name => "Chingling";
		public override int Generation => 4;
		public override string PokedexEntry => "It emits cries by agitating an orb at the back of its throat. It moves with flouncing hops.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Psychic };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Levitate, };
		public override Stats BaseStats => new Stats() {
			HP = 45,
			Attack = 30,
			Defense = 50,
			SpecialAttack = 65,
			SpecialDefense = 50,
			Speed = 45
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Wrap, },
			[4] = new List<Move>() { MoveFactory.Growl, },
			[7] = new List<Move>() { MoveFactory.Astonish, },
			[10] = new List<Move>() { MoveFactory.Confusion, },
			[13] = new List<Move>() { MoveFactory.Yawn, },
			[16] = new List<Move>() { MoveFactory.LastResort, },
			[19] = new List<Move>() { MoveFactory.Entrainment, },
			[32] = new List<Move>() { MoveFactory.Uproar, },
		};
	}
}

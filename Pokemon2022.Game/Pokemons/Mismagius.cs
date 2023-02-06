using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Mismagius : Pokemon
	{
		public override string Name => "Mismagius";
		public override int Generation => 4;
		public override string PokedexEntry => "Its cries sound like incantations. Those hearing it are tormented by headaches and hallucinations.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Ghost };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Levitate, };
		public override Stats BaseStats => new Stats() {
			HP = 60,
			Attack = 60,
			Defense = 60,
			SpecialAttack = 105,
			SpecialDefense = 105,
			Speed = 105
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.MysticalFire, MoveFactory.PowerGem, MoveFactory.PhantomForce, MoveFactory.MagicalLeaf, MoveFactory.Growl, MoveFactory.Spite, MoveFactory.Astonish, },
		};
	}
}

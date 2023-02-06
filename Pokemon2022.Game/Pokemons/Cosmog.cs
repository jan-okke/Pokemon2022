using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Cosmog : Pokemon
	{
		public override string Name => "Cosmog";
		public override int Generation => 7;
		public override string PokedexEntry => "Whether or not it's a Pokémon from this world is a mystery. When it's in a jam, it warps away to a safe place to hide.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Psychic };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Unaware, };
		public override Stats BaseStats => new Stats() {
			HP = 43,
			Attack = 29,
			Defense = 31,
			SpecialAttack = 29,
			SpecialDefense = 31,
			Speed = 37
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Splash, MoveFactory.Teleport, },
		};
	}
}

using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Sandile : Pokemon
	{
		public override string Name => "Sandile";
		public override int Generation => 5;
		public override string PokedexEntry => "It moves along below the sand's surface, except for its nose and eyes. A dark membrane shields its eyes from the sun.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Ground, PokemonType.Dark };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Intimidate, AbilityFactory.Moxie, };
		public override Ability AvailableHiddenAbility => AbilityFactory.AngerPoint;
		public override Stats BaseStats => new Stats() {
			HP = 50,
			Attack = 72,
			Defense = 35,
			SpecialAttack = 35,
			SpecialDefense = 35,
			Speed = 65
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.PowerTrip, MoveFactory.Leer, },
			[3] = new List<Move>() { MoveFactory.SandAttack, },
			[6] = new List<Move>() { MoveFactory.HoneClaws, },
			[9] = new List<Move>() { MoveFactory.SandTomb, },
			[12] = new List<Move>() { MoveFactory.ScaryFace, },
			[15] = new List<Move>() { MoveFactory.Bite, },
			[18] = new List<Move>() { MoveFactory.Torment, },
			[21] = new List<Move>() { MoveFactory.Dig, },
			[24] = new List<Move>() { MoveFactory.Swagger, },
			[27] = new List<Move>() { MoveFactory.Crunch, },
			[30] = new List<Move>() { MoveFactory.Sandstorm, },
			[33] = new List<Move>() { MoveFactory.FoulPlay, },
			[36] = new List<Move>() { MoveFactory.Earthquake, },
			[39] = new List<Move>() { MoveFactory.Thrash, },
		};
	}
}

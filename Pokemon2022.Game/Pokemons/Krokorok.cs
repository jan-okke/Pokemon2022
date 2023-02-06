using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Krokorok : Pokemon
	{
		public override string Name => "Krokorok";
		public override int Generation => 5;
		public override string PokedexEntry => "The special membrane covering its eyes can sense the heat of objects, so it can see its surroundings, even in darkness.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Ground, PokemonType.Dark };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Intimidate, AbilityFactory.Moxie, };
		public override Ability AvailableHiddenAbility => AbilityFactory.AngerPoint;
		public override Stats BaseStats => new Stats() {
			HP = 60,
			Attack = 82,
			Defense = 45,
			SpecialAttack = 45,
			SpecialDefense = 45,
			Speed = 74
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.PowerTrip, MoveFactory.Leer, MoveFactory.SandAttack, MoveFactory.HoneClaws, },
			[9] = new List<Move>() { MoveFactory.SandTomb, },
			[12] = new List<Move>() { MoveFactory.ScaryFace, },
			[15] = new List<Move>() { MoveFactory.Bite, },
			[18] = new List<Move>() { MoveFactory.Torment, },
			[21] = new List<Move>() { MoveFactory.Dig, },
			[24] = new List<Move>() { MoveFactory.Swagger, },
			[27] = new List<Move>() { MoveFactory.Crunch, },
			[32] = new List<Move>() { MoveFactory.Sandstorm, },
			[35] = new List<Move>() { MoveFactory.FoulPlay, },
			[42] = new List<Move>() { MoveFactory.Earthquake, },
			[47] = new List<Move>() { MoveFactory.Thrash, },
		};
	}
}

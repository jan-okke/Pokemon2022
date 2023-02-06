using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Krookodile : Pokemon
	{
		public override string Name => "Krookodile";
		public override int Generation => 5;
		public override string PokedexEntry => "It can expand the focus of its eyes, enabling it to see objects in the far distance as if it were using binoculars.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Ground, PokemonType.Dark };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Intimidate, AbilityFactory.Moxie, };
		public override Ability AvailableHiddenAbility => AbilityFactory.AngerPoint;
		public override Stats BaseStats => new Stats() {
			HP = 95,
			Attack = 117,
			Defense = 80,
			SpecialAttack = 65,
			SpecialDefense = 70,
			Speed = 92
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
			[44] = new List<Move>() { MoveFactory.Earthquake, },
			[51] = new List<Move>() { MoveFactory.Thrash, },
			[58] = new List<Move>() { MoveFactory.Outrage, },
		};
	}
}

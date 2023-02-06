using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Beartic : Pokemon
	{
		public override string Name => "Beartic";
		public override int Generation => 5;
		public override string PokedexEntry => "It freezes its breath to create fangs and claws of ice to fight with. Cold northern areas are its habitat.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Ice };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.SnowCloak, AbilityFactory.SlushRush, };
		public override Ability AvailableHiddenAbility => AbilityFactory.SwiftSwim;
		public override Stats BaseStats => new Stats() {
			HP = 95,
			Attack = 130,
			Defense = 80,
			SpecialAttack = 70,
			SpecialDefense = 80,
			Speed = 50
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[0] = new List<Move>() { MoveFactory.IcicleCrash, },
			[1] = new List<Move>() { MoveFactory.IcicleCrash, MoveFactory.AquaJet, MoveFactory.Charm, MoveFactory.PowderSnow, MoveFactory.Growl, MoveFactory.Endure, MoveFactory.FurySwipes, },
			[9] = new List<Move>() { MoveFactory.IcyWind, },
			[12] = new List<Move>() { MoveFactory.PlayNice, },
			[15] = new List<Move>() { MoveFactory.Brine, },
			[18] = new List<Move>() { MoveFactory.FrostBreath, },
			[21] = new List<Move>() { MoveFactory.Slash, },
			[24] = new List<Move>() { MoveFactory.Flail, },
			[27] = new List<Move>() { MoveFactory.Swagger, },
			[30] = new List<Move>() { MoveFactory.Hail, },
			[33] = new List<Move>() { MoveFactory.Thrash, },
			[36] = new List<Move>() { MoveFactory.Rest, },
			[41] = new List<Move>() { MoveFactory.Blizzard, },
			[46] = new List<Move>() { MoveFactory.SheerCold, },
			[51] = new List<Move>() { MoveFactory.Superpower, },
		};
	}
}

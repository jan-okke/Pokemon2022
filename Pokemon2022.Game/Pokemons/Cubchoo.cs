using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Cubchoo : Pokemon
	{
		public override string Name => "Cubchoo";
		public override int Generation => 5;
		public override string PokedexEntry => "Its nose is always running. It sniffs the snot back up because the mucus provides the raw material for its moves.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Ice };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.SnowCloak, AbilityFactory.SlushRush, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Rattled;
		public override Stats BaseStats => new Stats() {
			HP = 55,
			Attack = 70,
			Defense = 40,
			SpecialAttack = 60,
			SpecialDefense = 40,
			Speed = 40
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.PowderSnow, MoveFactory.Growl, },
			[3] = new List<Move>() { MoveFactory.Endure, },
			[6] = new List<Move>() { MoveFactory.FurySwipes, },
			[9] = new List<Move>() { MoveFactory.IcyWind, },
			[12] = new List<Move>() { MoveFactory.PlayNice, },
			[15] = new List<Move>() { MoveFactory.Brine, },
			[18] = new List<Move>() { MoveFactory.FrostBreath, },
			[21] = new List<Move>() { MoveFactory.Slash, },
			[24] = new List<Move>() { MoveFactory.Flail, },
			[27] = new List<Move>() { MoveFactory.Charm, },
			[30] = new List<Move>() { MoveFactory.Hail, },
			[33] = new List<Move>() { MoveFactory.Thrash, },
			[36] = new List<Move>() { MoveFactory.Rest, },
			[39] = new List<Move>() { MoveFactory.Blizzard, },
			[42] = new List<Move>() { MoveFactory.SheerCold, },
		};
	}
}

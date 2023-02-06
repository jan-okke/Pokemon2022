using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Komala : Pokemon
	{
		public override string Name => "Komala";
		public override int Generation => 7;
		public override string PokedexEntry => "It remains asleep from birth to death as a result of the sedative properties of the leaves that form its diet.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Normal };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Comatose, };
		public override Stats BaseStats => new Stats() {
			HP = 65,
			Attack = 115,
			Defense = 65,
			SpecialAttack = 75,
			SpecialDefense = 95,
			Speed = 65
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.DefenseCurl, MoveFactory.Rollout, },
			[6] = new List<Move>() { MoveFactory.Stockpile, MoveFactory.SpitUp, MoveFactory.Swallow, },
			[11] = new List<Move>() { MoveFactory.RapidSpin, },
			[16] = new List<Move>() { MoveFactory.Yawn, },
			[21] = new List<Move>() { MoveFactory.Slam, },
			[26] = new List<Move>() { MoveFactory.Flail, },
			[31] = new List<Move>() { MoveFactory.SuckerPunch, },
			[36] = new List<Move>() { MoveFactory.PsychUp, },
			[41] = new List<Move>() { MoveFactory.WoodHammer, },
			[46] = new List<Move>() { MoveFactory.Thrash, },
		};
	}
}

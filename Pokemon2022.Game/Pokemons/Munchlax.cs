using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Munchlax : Pokemon
	{
		public override string Name => "Munchlax";
		public override int Generation => 4;
		public override string PokedexEntry => "It wolfs down its weight in food once a day, swallowing food whole with almost no chewing.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Normal };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Pickup, AbilityFactory.ThickFat, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Gluttony;
		public override Stats BaseStats => new Stats() {
			HP = 135,
			Attack = 85,
			Defense = 40,
			SpecialAttack = 40,
			SpecialDefense = 85,
			Speed = 5
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Lick, MoveFactory.Tackle, },
			[4] = new List<Move>() { MoveFactory.DefenseCurl, },
			[8] = new List<Move>() { MoveFactory.Recycle, },
			[12] = new List<Move>() { MoveFactory.Covet, },
			[16] = new List<Move>() { MoveFactory.Bite, },
			[20] = new List<Move>() { MoveFactory.Stockpile, MoveFactory.Swallow, },
			[24] = new List<Move>() { MoveFactory.Screech, },
			[28] = new List<Move>() { MoveFactory.BodySlam, },
			[32] = new List<Move>() { MoveFactory.Fling, },
			[36] = new List<Move>() { MoveFactory.Amnesia, },
			[40] = new List<Move>() { MoveFactory.Metronome, },
			[44] = new List<Move>() { MoveFactory.Flail, },
			[48] = new List<Move>() { MoveFactory.BellyDrum, },
			[52] = new List<Move>() { MoveFactory.LastResort, },
		};
	}
}

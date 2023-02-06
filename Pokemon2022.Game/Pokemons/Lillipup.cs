using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Lillipup : Pokemon
	{
		public override string Name => "Lillipup";
		public override int Generation => 5;
		public override string PokedexEntry => "The long hair around its face provides an amazing radar that lets it sense subtle changes in its surroundings.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Normal };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.VitalSpirit, AbilityFactory.Pickup, };
		public override Ability AvailableHiddenAbility => AbilityFactory.RunAway;
		public override Stats BaseStats => new Stats() {
			HP = 45,
			Attack = 60,
			Defense = 45,
			SpecialAttack = 25,
			SpecialDefense = 45,
			Speed = 55
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Tackle, MoveFactory.Leer, },
			[4] = new List<Move>() { MoveFactory.WorkUp, },
			[8] = new List<Move>() { MoveFactory.Bite, },
			[12] = new List<Move>() { MoveFactory.Retaliate, },
			[17] = new List<Move>() { MoveFactory.BabyDollEyes, },
			[20] = new List<Move>() { MoveFactory.PlayRough, },
			[24] = new List<Move>() { MoveFactory.Crunch, },
			[28] = new List<Move>() { MoveFactory.TakeDown, },
			[32] = new List<Move>() { MoveFactory.HelpingHand, },
			[36] = new List<Move>() { MoveFactory.Reversal, },
			[40] = new List<Move>() { MoveFactory.Roar, },
			[44] = new List<Move>() { MoveFactory.LastResort, },
			[48] = new List<Move>() { MoveFactory.GigaImpact, },
		};
	}
}

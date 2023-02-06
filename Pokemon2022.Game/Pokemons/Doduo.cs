using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Doduo : Pokemon
	{
		public override string Name => "Doduo";
		public override int Generation => 1;
		public override string PokedexEntry => "Even while eating or sleeping, one of the heads remains always vigilant for any sign of danger. When threatened, it flees at over 60 miles per hour.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Normal, PokemonType.Flying };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.RunAway, AbilityFactory.EarlyBird, };
		public override Ability AvailableHiddenAbility => AbilityFactory.TangledFeet;
		public override Stats BaseStats => new Stats() {
			HP = 35,
			Attack = 85,
			Defense = 45,
			SpecialAttack = 35,
			SpecialDefense = 35,
			Speed = 75
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Peck, MoveFactory.Growl, },
			[5] = new List<Move>() { MoveFactory.QuickAttack, },
			[8] = new List<Move>() { MoveFactory.Leer, },
			[12] = new List<Move>() { MoveFactory.FuryAttack, },
			[15] = new List<Move>() { MoveFactory.WingAttack, },
			[19] = new List<Move>() { MoveFactory.Pluck, },
			[22] = new List<Move>() { MoveFactory.DoubleHit, },
			[26] = new List<Move>() { MoveFactory.Agility, },
			[29] = new List<Move>() { MoveFactory.Uproar, },
			[33] = new List<Move>() { MoveFactory.Acupressure, },
			[36] = new List<Move>() { MoveFactory.SwordsDance, },
			[40] = new List<Move>() { MoveFactory.Lunge, },
			[43] = new List<Move>() { MoveFactory.DrillPeck, },
			[47] = new List<Move>() { MoveFactory.Endeavor, },
			[50] = new List<Move>() { MoveFactory.Thrash, },
		};
	}
}

using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Accelgor : Pokemon
	{
		public override string Name => "Accelgor";
		public override int Generation => 5;
		public override string PokedexEntry => "Having removed its heavy shell, it becomes very light and can fight with ninja-like movements.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Bug };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Hydration, AbilityFactory.StickyHold, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Unburden;
		public override Stats BaseStats => new Stats() {
			HP = 80,
			Attack = 70,
			Defense = 40,
			SpecialAttack = 100,
			SpecialDefense = 60,
			Speed = 145
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.WaterShuriken, MoveFactory.Acid, MoveFactory.Curse, MoveFactory.Yawn, MoveFactory.AcidArmor, MoveFactory.GuardSwap, MoveFactory.BodySlam, MoveFactory.Absorb, MoveFactory.DoubleTeam, MoveFactory.AcidSpray, MoveFactory.QuickAttack, },
			[12] = new List<Move>() { MoveFactory.MegaDrain, },
			[16] = new List<Move>() { MoveFactory.StruggleBug, },
			[20] = new List<Move>() { MoveFactory.Swift, },
			[24] = new List<Move>() { MoveFactory.Agility, },
			[28] = new List<Move>() { MoveFactory.GigaDrain, },
			[32] = new List<Move>() { MoveFactory.PowerSwap, },
			[36] = new List<Move>() { MoveFactory.Uturn, },
			[40] = new List<Move>() { MoveFactory.Recover, },
			[44] = new List<Move>() { MoveFactory.BugBuzz, },
			[48] = new List<Move>() { MoveFactory.FinalGambit, },
			[52] = new List<Move>() { MoveFactory.Toxic, },
		};
	}
}

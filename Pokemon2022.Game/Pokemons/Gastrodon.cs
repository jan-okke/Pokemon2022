using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Gastrodon : Pokemon
	{
		public override string Name => "Gastrodon";
		public override int Generation => 4;
		public override string PokedexEntry => "Its search for food sometimes leads it onto land, where it leaves behind a sticky trail of slime as it passes through.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Water, PokemonType.Ground };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.StickyHold, AbilityFactory.StormDrain, };
		public override Ability AvailableHiddenAbility => AbilityFactory.SandForce;
		public override Stats BaseStats => new Stats() {
			HP = 111,
			Attack = 83,
			Defense = 68,
			SpecialAttack = 92,
			SpecialDefense = 82,
			Speed = 39
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.WaterGun, MoveFactory.MudSlap, MoveFactory.Harden, MoveFactory.Recover, },
			[15] = new List<Move>() { MoveFactory.WaterPulse, },
			[20] = new List<Move>() { MoveFactory.AncientPower, },
			[25] = new List<Move>() { MoveFactory.BodySlam, },
			[33] = new List<Move>() { MoveFactory.MuddyWater, },
			[39] = new List<Move>() { MoveFactory.EarthPower, },
			[46] = new List<Move>() { MoveFactory.RainDance, },
			[53] = new List<Move>() { MoveFactory.Memento, },
		};
	}
}

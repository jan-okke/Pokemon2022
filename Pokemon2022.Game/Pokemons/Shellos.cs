using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Shellos : Pokemon
	{
		public override string Name => "Shellos";
		public override int Generation => 4;
		public override string PokedexEntry => "This Pokémon's habitat shapes its physique. According to some theories, life in warm ocean waters causes this variation to develop.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Water };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.StickyHold, AbilityFactory.StormDrain, };
		public override Ability AvailableHiddenAbility => AbilityFactory.SandForce;
		public override Stats BaseStats => new Stats() {
			HP = 76,
			Attack = 48,
			Defense = 48,
			SpecialAttack = 57,
			SpecialDefense = 62,
			Speed = 34
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.WaterGun, MoveFactory.MudSlap, },
			[5] = new List<Move>() { MoveFactory.Harden, },
			[10] = new List<Move>() { MoveFactory.Recover, },
			[15] = new List<Move>() { MoveFactory.WaterPulse, },
			[20] = new List<Move>() { MoveFactory.AncientPower, },
			[25] = new List<Move>() { MoveFactory.BodySlam, },
			[31] = new List<Move>() { MoveFactory.MuddyWater, },
			[35] = new List<Move>() { MoveFactory.EarthPower, },
			[40] = new List<Move>() { MoveFactory.RainDance, },
			[45] = new List<Move>() { MoveFactory.Memento, },
		};
	}
}

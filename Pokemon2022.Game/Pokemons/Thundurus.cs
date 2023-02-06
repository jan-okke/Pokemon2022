using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Thundurus : Pokemon
	{
		public override string Name => "Thundurus";
		public override int Generation => 5;
		public override string PokedexEntry => "The spikes on its tail discharge immense bolts of lightning. It flies around the Unova region firing off lightning bolts.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Electric, PokemonType.Flying };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Prankster, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Defiant;
		public override Stats BaseStats => new Stats() {
			HP = 79,
			Attack = 115,
			Defense = 70,
			SpecialAttack = 125,
			SpecialDefense = 80,
			Speed = 111
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Astonish, MoveFactory.ThunderShock, },
			[5] = new List<Move>() { MoveFactory.Leer, },
			[10] = new List<Move>() { MoveFactory.Swagger, },
			[15] = new List<Move>() { MoveFactory.Bite, },
			[20] = new List<Move>() { MoveFactory.ShockWave, },
			[25] = new List<Move>() { MoveFactory.Agility, },
			[30] = new List<Move>() { MoveFactory.Charge, },
			[35] = new List<Move>() { MoveFactory.VoltSwitch, },
			[40] = new List<Move>() { MoveFactory.Crunch, },
			[45] = new List<Move>() { MoveFactory.Discharge, },
			[50] = new List<Move>() { MoveFactory.Uproar, },
			[55] = new List<Move>() { MoveFactory.HammerArm, },
			[60] = new List<Move>() { MoveFactory.RainDance, },
			[65] = new List<Move>() { MoveFactory.Thunder, },
			[70] = new List<Move>() { MoveFactory.Thrash, },
		};
	}
}

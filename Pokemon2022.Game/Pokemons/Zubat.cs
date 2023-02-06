using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Zubat : Pokemon
	{
		public override string Name => "Zubat";
		public override int Generation => 1;
		public override string PokedexEntry => "While living in pitch-black caverns, their eyes gradually grew shut and deprived them of vision. They use ultrasonic waves to detect obstacles.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Poison, PokemonType.Flying };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.InnerFocus, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Infiltrator;
		public override Stats BaseStats => new Stats() {
			HP = 40,
			Attack = 45,
			Defense = 35,
			SpecialAttack = 30,
			SpecialDefense = 40,
			Speed = 55
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Absorb, MoveFactory.Supersonic, },
			[5] = new List<Move>() { MoveFactory.Astonish, },
			[10] = new List<Move>() { MoveFactory.MeanLook, },
			[15] = new List<Move>() { MoveFactory.PoisonFang, },
			[20] = new List<Move>() { MoveFactory.QuickGuard, },
			[25] = new List<Move>() { MoveFactory.AirCutter, },
			[30] = new List<Move>() { MoveFactory.Bite, },
			[35] = new List<Move>() { MoveFactory.Haze, },
			[40] = new List<Move>() { MoveFactory.Venoshock, },
			[45] = new List<Move>() { MoveFactory.ConfuseRay, },
			[50] = new List<Move>() { MoveFactory.AirSlash, },
			[55] = new List<Move>() { MoveFactory.LeechLife, },
		};
	}
}

using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Horsea : Pokemon
	{
		public override string Name => "Horsea";
		public override int Generation => 1;
		public override string PokedexEntry => "By cleverly flicking the fins on its back side to side, it moves in any direction while facing forward. It spits ink to escape if it senses danger.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Water };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.SwiftSwim, AbilityFactory.Sniper, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Damp;
		public override Stats BaseStats => new Stats() {
			HP = 30,
			Attack = 40,
			Defense = 70,
			SpecialAttack = 70,
			SpecialDefense = 25,
			Speed = 60
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.WaterGun, MoveFactory.Leer, },
			[5] = new List<Move>() { MoveFactory.Smokescreen, },
			[10] = new List<Move>() { MoveFactory.Twister, },
			[15] = new List<Move>() { MoveFactory.FocusEnergy, },
			[20] = new List<Move>() { MoveFactory.DragonBreath, },
			[25] = new List<Move>() { MoveFactory.BubbleBeam, },
			[30] = new List<Move>() { MoveFactory.Agility, },
			[35] = new List<Move>() { MoveFactory.LaserFocus, },
			[40] = new List<Move>() { MoveFactory.DragonPulse, },
			[45] = new List<Move>() { MoveFactory.HydroPump, },
			[50] = new List<Move>() { MoveFactory.DragonDance, },
			[55] = new List<Move>() { MoveFactory.RainDance, },
		};
	}
}

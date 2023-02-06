using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Kingdra : Pokemon
	{
		public override string Name => "Kingdra";
		public override int Generation => 2;
		public override string PokedexEntry => "It sleeps quietly, deep on the seafloor. When it comes up to the surface, it creates a huge whirlpool that can swallow even ships.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Water, PokemonType.Dragon };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.SwiftSwim, AbilityFactory.Sniper, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Damp;
		public override Stats BaseStats => new Stats() {
			HP = 75,
			Attack = 95,
			Defense = 95,
			SpecialAttack = 95,
			SpecialDefense = 95,
			Speed = 85
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Whirlpool, MoveFactory.Yawn, MoveFactory.WaterGun, MoveFactory.Leer, MoveFactory.Smokescreen, MoveFactory.Twister, },
			[15] = new List<Move>() { MoveFactory.FocusEnergy, },
			[20] = new List<Move>() { MoveFactory.DragonBreath, },
			[25] = new List<Move>() { MoveFactory.BubbleBeam, },
			[30] = new List<Move>() { MoveFactory.Agility, },
			[37] = new List<Move>() { MoveFactory.LaserFocus, },
			[44] = new List<Move>() { MoveFactory.DragonPulse, },
			[51] = new List<Move>() { MoveFactory.HydroPump, },
			[58] = new List<Move>() { MoveFactory.DragonDance, },
			[65] = new List<Move>() { MoveFactory.RainDance, },
		};
	}
}

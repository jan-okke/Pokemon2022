using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Seadra : Pokemon
	{
		public override string Name => "Seadra";
		public override int Generation => 1;
		public override string PokedexEntry => "The poisonous barbs all over its body are highly valued as ingredients for making traditional herbal medicine. It shows no mercy to anything approaching its nest.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Water };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.PoisonPoint, AbilityFactory.Sniper, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Damp;
		public override Stats BaseStats => new Stats() {
			HP = 55,
			Attack = 65,
			Defense = 95,
			SpecialAttack = 95,
			SpecialDefense = 45,
			Speed = 85
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.WaterGun, MoveFactory.Leer, MoveFactory.Smokescreen, MoveFactory.Twister, },
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

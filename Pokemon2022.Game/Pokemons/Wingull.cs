using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Wingull : Pokemon
	{
		public override string Name => "Wingull";
		public override int Generation => 3;
		public override string PokedexEntry => "It makes its nest on a sheer cliff at the edge of the sea. It has trouble keeping its wings flapping in flight. Instead, it soars on updrafts.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Water, PokemonType.Flying };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.KeenEye, AbilityFactory.Hydration, };
		public override Ability AvailableHiddenAbility => AbilityFactory.RainDish;
		public override Stats BaseStats => new Stats() {
			HP = 40,
			Attack = 30,
			Defense = 30,
			SpecialAttack = 55,
			SpecialDefense = 30,
			Speed = 85
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Growl, MoveFactory.WaterGun, },
			[5] = new List<Move>() { MoveFactory.QuickAttack, },
			[10] = new List<Move>() { MoveFactory.Supersonic, },
			[15] = new List<Move>() { MoveFactory.WingAttack, },
			[20] = new List<Move>() { MoveFactory.WaterPulse, },
			[26] = new List<Move>() { MoveFactory.Agility, },
			[30] = new List<Move>() { MoveFactory.AirSlash, },
			[35] = new List<Move>() { MoveFactory.Mist, },
			[40] = new List<Move>() { MoveFactory.Roost, },
			[45] = new List<Move>() { MoveFactory.Hurricane, },
		};
	}
}

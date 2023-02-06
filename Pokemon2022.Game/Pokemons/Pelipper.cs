using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Pelipper : Pokemon
	{
		public override string Name => "Pelipper";
		public override int Generation => 3;
		public override string PokedexEntry => "It skims the tops of waves as it flies. When it spots prey, it uses its large beak to scoop up the victim with water. It protects its eggs in its beak.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Water, PokemonType.Flying };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.KeenEye, AbilityFactory.Drizzle, };
		public override Ability AvailableHiddenAbility => AbilityFactory.RainDish;
		public override Stats BaseStats => new Stats() {
			HP = 60,
			Attack = 50,
			Defense = 100,
			SpecialAttack = 95,
			SpecialDefense = 70,
			Speed = 65
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Protect, MoveFactory.Soak, MoveFactory.QuickAttack, MoveFactory.Agility, MoveFactory.AirSlash, MoveFactory.Growl, MoveFactory.WaterGun, MoveFactory.Tailwind, MoveFactory.Supersonic, },
			[15] = new List<Move>() { MoveFactory.WingAttack, },
			[20] = new List<Move>() { MoveFactory.WaterPulse, },
			[28] = new List<Move>() { MoveFactory.Stockpile, MoveFactory.Swallow, MoveFactory.SpitUp, },
			[34] = new List<Move>() { MoveFactory.Fling, },
			[41] = new List<Move>() { MoveFactory.Mist, },
			[48] = new List<Move>() { MoveFactory.Roost, },
			[55] = new List<Move>() { MoveFactory.Hurricane, },
			[62] = new List<Move>() { MoveFactory.HydroPump, },
		};
	}
}

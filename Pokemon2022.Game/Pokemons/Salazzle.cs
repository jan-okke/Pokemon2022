using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Salazzle : Pokemon
	{
		public override string Name => "Salazzle";
		public override int Generation => 7;
		public override string PokedexEntry => "Filled with pheromones, its poisonous gas can be diluted to use in the production of luscious perfumes.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Poison, PokemonType.Fire };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Corrosion, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Oblivious;
		public override Stats BaseStats => new Stats() {
			HP = 68,
			Attack = 64,
			Defense = 60,
			SpecialAttack = 111,
			SpecialDefense = 60,
			Speed = 117
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[0] = new List<Move>() { MoveFactory.FireLash, },
			[1] = new List<Move>() { MoveFactory.FireLash, MoveFactory.KnockOff, MoveFactory.Encore, MoveFactory.Torment, MoveFactory.Swagger, MoveFactory.Disable, MoveFactory.Scratch, MoveFactory.Endeavor, MoveFactory.Pound, MoveFactory.PoisonGas, MoveFactory.Smog, MoveFactory.Ember, },
			[15] = new List<Move>() { MoveFactory.PoisonFang, },
			[20] = new List<Move>() { MoveFactory.SweetScent, },
			[25] = new List<Move>() { MoveFactory.NastyPlot, },
			[30] = new List<Move>() { MoveFactory.Incinerate, },
			[37] = new List<Move>() { MoveFactory.Venoshock, },
			[44] = new List<Move>() { MoveFactory.DragonPulse, },
			[51] = new List<Move>() { MoveFactory.VenomDrench, },
			[58] = new List<Move>() { MoveFactory.Flamethrower, },
			[65] = new List<Move>() { MoveFactory.Toxic, },
		};
	}
}

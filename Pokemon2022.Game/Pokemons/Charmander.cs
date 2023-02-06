using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Charmander : Pokemon
	{
		public override string Name => "Charmander";
		public override int Generation => 1;
		public override string PokedexEntry => "The flame that burns at the tip of its tail is an indication of its emotions. The flame wavers when Charmander is happy, and blazes when it is enraged.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Fire };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Blaze, };
		public override Ability AvailableHiddenAbility => AbilityFactory.SolarPower;
		public override Stats BaseStats => new Stats() {
			HP = 39,
			Attack = 52,
			Defense = 43,
			SpecialAttack = 60,
			SpecialDefense = 50,
			Speed = 65
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Scratch, MoveFactory.Growl, },
			[4] = new List<Move>() { MoveFactory.Ember, },
			[8] = new List<Move>() { MoveFactory.Smokescreen, },
			[12] = new List<Move>() { MoveFactory.DragonBreath, },
			[17] = new List<Move>() { MoveFactory.FireFang, },
			[20] = new List<Move>() { MoveFactory.Slash, },
			[24] = new List<Move>() { MoveFactory.Flamethrower, },
			[28] = new List<Move>() { MoveFactory.ScaryFace, },
			[32] = new List<Move>() { MoveFactory.FireSpin, },
			[36] = new List<Move>() { MoveFactory.Inferno, },
			[40] = new List<Move>() { MoveFactory.FlareBlitz, },
		};
	}
}

using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Chimchar : Pokemon
	{
		public override string Name => "Chimchar";
		public override int Generation => 4;
		public override string PokedexEntry => "It agilely scales sheer cliffs to live atop craggy mountains. Its fire is put out when it sleeps.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Fire };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Blaze, };
		public override Ability AvailableHiddenAbility => AbilityFactory.IronFist;
		public override Stats BaseStats => new Stats() {
			HP = 44,
			Attack = 58,
			Defense = 44,
			SpecialAttack = 58,
			SpecialDefense = 44,
			Speed = 61
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Scratch, MoveFactory.Leer, },
			[6] = new List<Move>() { MoveFactory.Ember, },
			[9] = new List<Move>() { MoveFactory.Taunt, },
			[12] = new List<Move>() { MoveFactory.PowerUpPunch, },
			[15] = new List<Move>() { MoveFactory.FurySwipes, },
			[17] = new List<Move>() { MoveFactory.FlameWheel, },
			[23] = new List<Move>() { MoveFactory.NastyPlot, },
			[25] = new List<Move>() { MoveFactory.Torment, },
			[31] = new List<Move>() { MoveFactory.Facade, },
			[33] = new List<Move>() { MoveFactory.FireSpin, },
			[39] = new List<Move>() { MoveFactory.Acrobatics, },
			[41] = new List<Move>() { MoveFactory.SlackOff, },
			[47] = new List<Move>() { MoveFactory.Flamethrower, },
		};
	}
}

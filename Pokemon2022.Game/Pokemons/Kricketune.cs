using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Kricketune : Pokemon
	{
		public override string Name => "Kricketune";
		public override int Generation => 4;
		public override string PokedexEntry => "It crosses its knifelike arms in front of its chest when it cries. It can compose melodies ad lib.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Bug };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Swarm, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Technician;
		public override Stats BaseStats => new Stats() {
			HP = 77,
			Attack = 85,
			Defense = 51,
			SpecialAttack = 55,
			SpecialDefense = 51,
			Speed = 65
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[0] = new List<Move>() { MoveFactory.FuryCutter, },
			[1] = new List<Move>() { MoveFactory.FuryCutter, MoveFactory.Growl, MoveFactory.Pound, },
			[14] = new List<Move>() { MoveFactory.Absorb, },
			[18] = new List<Move>() { MoveFactory.Sing, },
			[22] = new List<Move>() { MoveFactory.FocusEnergy, },
			[26] = new List<Move>() { MoveFactory.Slash, },
			[30] = new List<Move>() { MoveFactory.XScissor, },
			[34] = new List<Move>() { MoveFactory.Screech, },
			[36] = new List<Move>() { MoveFactory.FellStinger, },
			[38] = new List<Move>() { MoveFactory.Taunt, },
			[42] = new List<Move>() { MoveFactory.NightSlash, },
			[44] = new List<Move>() { MoveFactory.StickyWeb, },
			[46] = new List<Move>() { MoveFactory.BugBuzz, },
			[50] = new List<Move>() { MoveFactory.PerishSong, },
		};
	}
}

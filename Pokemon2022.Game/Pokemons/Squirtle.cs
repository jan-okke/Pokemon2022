using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Squirtle : Pokemon
	{
		public override string Name => "Squirtle";
		public override int Generation => 1;
		public override string PokedexEntry => "Its shell is not just for protection. Its rounded shape and the grooves on its surface minimize resistance in water, enabling Squirtle to swim at high speeds.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Water };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Torrent, };
		public override Ability AvailableHiddenAbility => AbilityFactory.RainDish;
		public override Stats BaseStats => new Stats() {
			HP = 44,
			Attack = 48,
			Defense = 65,
			SpecialAttack = 50,
			SpecialDefense = 64,
			Speed = 43
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Tackle, MoveFactory.TailWhip, },
			[3] = new List<Move>() { MoveFactory.WaterGun, },
			[6] = new List<Move>() { MoveFactory.Withdraw, },
			[9] = new List<Move>() { MoveFactory.RapidSpin, },
			[12] = new List<Move>() { MoveFactory.Bite, },
			[15] = new List<Move>() { MoveFactory.WaterPulse, },
			[18] = new List<Move>() { MoveFactory.Protect, },
			[21] = new List<Move>() { MoveFactory.RainDance, },
			[24] = new List<Move>() { MoveFactory.AquaTail, },
			[27] = new List<Move>() { MoveFactory.ShellSmash, },
			[30] = new List<Move>() { MoveFactory.IronDefense, },
			[33] = new List<Move>() { MoveFactory.HydroPump, },
			[36] = new List<Move>() { MoveFactory.SkullBash, },
		};
	}
}

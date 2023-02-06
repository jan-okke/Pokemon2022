using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Blastoise : Pokemon
	{
		public override string Name => "Blastoise";
		public override int Generation => 1;
		public override string PokedexEntry => "The waterspouts that protrude from its shell are highly accurate. Their bullets of water can precisely nail tin cans from a distance of over 160 feet.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Water };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Torrent, };
		public override Ability AvailableHiddenAbility => AbilityFactory.RainDish;
		public override Stats BaseStats => new Stats() {
			HP = 79,
			Attack = 83,
			Defense = 100,
			SpecialAttack = 85,
			SpecialDefense = 105,
			Speed = 78
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[0] = new List<Move>() { MoveFactory.FlashCannon, },
			[1] = new List<Move>() { MoveFactory.FlashCannon, MoveFactory.Tackle, MoveFactory.TailWhip, MoveFactory.WaterGun, MoveFactory.Withdraw, },
			[9] = new List<Move>() { MoveFactory.RapidSpin, },
			[12] = new List<Move>() { MoveFactory.Bite, },
			[15] = new List<Move>() { MoveFactory.WaterPulse, },
			[20] = new List<Move>() { MoveFactory.Protect, },
			[25] = new List<Move>() { MoveFactory.RainDance, },
			[30] = new List<Move>() { MoveFactory.AquaTail, },
			[35] = new List<Move>() { MoveFactory.ShellSmash, },
			[42] = new List<Move>() { MoveFactory.IronDefense, },
			[49] = new List<Move>() { MoveFactory.HydroPump, },
			[56] = new List<Move>() { MoveFactory.SkullBash, },
		};
	}
}

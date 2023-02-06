using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Huntail : Pokemon
	{
		public override string Name => "Huntail";
		public override int Generation => 3;
		public override string PokedexEntry => "To withstand the crushing water pressure deep under the sea, its spine is very thick and sturdy. Its tail, which is shaped like a small fish, has eyes that light up.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Water };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.SwiftSwim, };
		public override Ability AvailableHiddenAbility => AbilityFactory.WaterVeil;
		public override Stats BaseStats => new Stats() {
			HP = 55,
			Attack = 104,
			Defense = 105,
			SpecialAttack = 94,
			SpecialDefense = 75,
			Speed = 52
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Whirlpool, MoveFactory.Bite, },
			[5] = new List<Move>() { MoveFactory.Screech, },
			[9] = new List<Move>() { MoveFactory.ScaryFace, },
			[11] = new List<Move>() { MoveFactory.RainDance, },
			[14] = new List<Move>() { MoveFactory.WaterPulse, },
			[16] = new List<Move>() { MoveFactory.IceFang, },
			[19] = new List<Move>() { MoveFactory.Brine, },
			[23] = new List<Move>() { MoveFactory.SuckerPunch, },
			[26] = new List<Move>() { MoveFactory.Dive, },
			[29] = new List<Move>() { MoveFactory.BatonPass, },
			[34] = new List<Move>() { MoveFactory.Crunch, },
			[39] = new List<Move>() { MoveFactory.AquaTail, },
			[45] = new List<Move>() { MoveFactory.Coil, },
			[50] = new List<Move>() { MoveFactory.HydroPump, },
		};
	}
}

using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Gorebyss : Pokemon
	{
		public override string Name => "Gorebyss";
		public override int Generation => 3;
		public override string PokedexEntry => "A Gorebyss siphons the body fluids of prey through its thin, tubular mouth. Its light pink body color turns vivid when it finishes feeding.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Water };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.SwiftSwim, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Hydration;
		public override Stats BaseStats => new Stats() {
			HP = 55,
			Attack = 84,
			Defense = 105,
			SpecialAttack = 114,
			SpecialDefense = 75,
			Speed = 52
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Whirlpool, MoveFactory.Confusion, },
			[5] = new List<Move>() { MoveFactory.RainDance, },
			[9] = new List<Move>() { MoveFactory.Agility, },
			[11] = new List<Move>() { MoveFactory.DrainingKiss, },
			[14] = new List<Move>() { MoveFactory.WaterPulse, },
			[16] = new List<Move>() { MoveFactory.Amnesia, },
			[19] = new List<Move>() { MoveFactory.AquaRing, },
			[23] = new List<Move>() { MoveFactory.Safeguard, },
			[26] = new List<Move>() { MoveFactory.Dive, },
			[29] = new List<Move>() { MoveFactory.BatonPass, },
			[34] = new List<Move>() { MoveFactory.Psychic, },
			[39] = new List<Move>() { MoveFactory.AquaTail, },
			[45] = new List<Move>() { MoveFactory.Coil, },
			[50] = new List<Move>() { MoveFactory.HydroPump, },
		};
	}
}

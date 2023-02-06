using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Tropius : Pokemon
	{
		public override string Name => "Tropius";
		public override int Generation => 3;
		public override string PokedexEntry => "It flies by flapping its broad leaves. The bunch of fruit that grows around its neck is deliciously sweet. In the spring, it scatters pollen from its neck.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Grass, PokemonType.Flying };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Chlorophyll, AbilityFactory.SolarPower, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Harvest;
		public override Stats BaseStats => new Stats() {
			HP = 99,
			Attack = 68,
			Defense = 83,
			SpecialAttack = 72,
			SpecialDefense = 87,
			Speed = 51
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.LeafStorm, MoveFactory.Leer, MoveFactory.Gust, MoveFactory.Growth, MoveFactory.RazorLeaf, },
			[6] = new List<Move>() { MoveFactory.SweetScent, },
			[10] = new List<Move>() { MoveFactory.Stomp, },
			[16] = new List<Move>() { MoveFactory.MagicalLeaf, },
			[21] = new List<Move>() { MoveFactory.Whirlwind, },
			[26] = new List<Move>() { MoveFactory.LeafTornado, },
			[30] = new List<Move>() { MoveFactory.DragonDance, },
			[36] = new List<Move>() { MoveFactory.AirSlash, },
			[41] = new List<Move>() { MoveFactory.BodySlam, },
			[46] = new List<Move>() { MoveFactory.DragonHammer, },
			[50] = new List<Move>() { MoveFactory.Synthesis, },
			[56] = new List<Move>() { MoveFactory.SolarBeam, },
			[61] = new List<Move>() { MoveFactory.LeafStorm, },
		};
	}
}

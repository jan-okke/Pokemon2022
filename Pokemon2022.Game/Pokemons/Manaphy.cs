using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Manaphy : Pokemon
	{
		public override string Name => "Manaphy";
		public override int Generation => 4;
		public override string PokedexEntry => "Born on a cold seafloor, it will swim great distances to return to its birthplace.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Water };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Hydration, };
		public override Stats BaseStats => new Stats() {
			HP = 100,
			Attack = 100,
			Defense = 100,
			SpecialAttack = 100,
			SpecialDefense = 100,
			Speed = 100
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.TailGlow, MoveFactory.WaterGun, },
			[9] = new List<Move>() { MoveFactory.Charm, },
			[16] = new List<Move>() { MoveFactory.Supersonic, },
			[24] = new List<Move>() { MoveFactory.BubbleBeam, },
			[31] = new List<Move>() { MoveFactory.AcidArmor, },
			[39] = new List<Move>() { MoveFactory.Whirlpool, },
			[46] = new List<Move>() { MoveFactory.WaterPulse, },
			[54] = new List<Move>() { MoveFactory.AquaRing, },
			[61] = new List<Move>() { MoveFactory.Dive, },
			[69] = new List<Move>() { MoveFactory.RainDance, },
			[76] = new List<Move>() { MoveFactory.HeartSwap, },
		};
	}
}

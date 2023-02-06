using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Dhelmise : Pokemon
	{
		public override string Name => "Dhelmise";
		public override int Generation => 7;
		public override string PokedexEntry => "The soul of seaweed adrift in the waves became reborn as this Pokémon. It maintains itself with new infusions of seabed detritus and seaweed.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Ghost, PokemonType.Grass };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Steelworker, };
		public override Stats BaseStats => new Stats() {
			HP = 70,
			Attack = 131,
			Defense = 100,
			SpecialAttack = 86,
			SpecialDefense = 90,
			Speed = 40
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Absorb, MoveFactory.RapidSpin, },
			[4] = new List<Move>() { MoveFactory.Astonish, },
			[8] = new List<Move>() { MoveFactory.Wrap, },
			[12] = new List<Move>() { MoveFactory.MegaDrain, },
			[16] = new List<Move>() { MoveFactory.Growth, },
			[20] = new List<Move>() { MoveFactory.GyroBall, },
			[24] = new List<Move>() { MoveFactory.Switcheroo, },
			[28] = new List<Move>() { MoveFactory.GigaDrain, },
			[32] = new List<Move>() { MoveFactory.Whirlpool, },
			[36] = new List<Move>() { MoveFactory.HeavySlam, },
			[40] = new List<Move>() { MoveFactory.Slam, },
			[44] = new List<Move>() { MoveFactory.ShadowBall, },
			[48] = new List<Move>() { MoveFactory.MetalSound, },
			[52] = new List<Move>() { MoveFactory.AnchorShot, },
			[56] = new List<Move>() { MoveFactory.EnergyBall, },
			[60] = new List<Move>() { MoveFactory.PhantomForce, },
			[64] = new List<Move>() { MoveFactory.PowerWhip, },
		};
	}
}

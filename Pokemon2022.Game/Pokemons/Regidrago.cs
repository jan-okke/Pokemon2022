using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Regidrago : Pokemon
	{
		public override string Name => "Regidrago";
		public override int Generation => 8;
		public override string PokedexEntry => "Its body is composed of crystallized dragon energy. Regidrago is said to have the powers of every dragon Pokémon.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Dragon };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.DragonsMaw, };
		public override Stats BaseStats => new Stats() {
			HP = 200,
			Attack = 100,
			Defense = 50,
			SpecialAttack = 100,
			SpecialDefense = 50,
			Speed = 80
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Twister, MoveFactory.ViseGrip, },
			[6] = new List<Move>() { MoveFactory.Bite, },
			[12] = new List<Move>() { MoveFactory.AncientPower, },
			[18] = new List<Move>() { MoveFactory.DragonBreath, },
			[24] = new List<Move>() { MoveFactory.FocusEnergy, },
			[30] = new List<Move>() { MoveFactory.Crunch, },
			[36] = new List<Move>() { MoveFactory.DragonClaw, },
			[42] = new List<Move>() { MoveFactory.HammerArm, },
			[48] = new List<Move>() { MoveFactory.DragonDance, },
			[54] = new List<Move>() { MoveFactory.Thrash, },
			[60] = new List<Move>() { MoveFactory.LaserFocus, },
			[66] = new List<Move>() { MoveFactory.DragonEnergy, },
			[72] = new List<Move>() { MoveFactory.HyperBeam, },
			[78] = new List<Move>() { MoveFactory.Explosion, },
		};
	}
}

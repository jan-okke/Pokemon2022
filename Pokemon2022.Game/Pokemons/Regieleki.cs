using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Regieleki : Pokemon
	{
		public override string Name => "Regieleki";
		public override int Generation => 8;
		public override string PokedexEntry => "This Pokémon is a cluster of electrical energy. It's said that removing the rings on Regieleki's body will unleash the Pokémon's latent power.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Electric };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Transistor, };
		public override Stats BaseStats => new Stats() {
			HP = 80,
			Attack = 100,
			Defense = 50,
			SpecialAttack = 100,
			SpecialDefense = 50,
			Speed = 200
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.ThunderShock, MoveFactory.RapidSpin, },
			[6] = new List<Move>() { MoveFactory.Electroweb, },
			[12] = new List<Move>() { MoveFactory.AncientPower, },
			[18] = new List<Move>() { MoveFactory.ShockWave, },
			[24] = new List<Move>() { MoveFactory.ThunderWave, },
			[30] = new List<Move>() { MoveFactory.ExtremeSpeed, },
			[36] = new List<Move>() { MoveFactory.ThunderCage, },
			[42] = new List<Move>() { MoveFactory.Thunderbolt, },
			[48] = new List<Move>() { MoveFactory.MagnetRise, },
			[54] = new List<Move>() { MoveFactory.Thrash, },
			[60] = new List<Move>() { MoveFactory.LockOn, },
			[66] = new List<Move>() { MoveFactory.ZapCannon, },
			[72] = new List<Move>() { MoveFactory.HyperBeam, },
			[78] = new List<Move>() { MoveFactory.Explosion, },
		};
	}
}

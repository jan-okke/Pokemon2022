using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Cacturne : Pokemon
	{
		public override string Name => "Cacturne";
		public override int Generation => 3;
		public override string PokedexEntry => "After spending thousands of years in harsh deserts, its blood transformed into the same substances as sand. It is nocturnal, so it hunts at night.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Grass, PokemonType.Dark };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.SandVeil, };
		public override Ability AvailableHiddenAbility => AbilityFactory.WaterAbsorb;
		public override Stats BaseStats => new Stats() {
			HP = 70,
			Attack = 115,
			Defense = 60,
			SpecialAttack = 115,
			SpecialDefense = 60,
			Speed = 55
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[0] = new List<Move>() { MoveFactory.SpikyShield, },
			[1] = new List<Move>() { MoveFactory.SpikyShield, MoveFactory.DestinyBond, MoveFactory.Revenge, MoveFactory.PoisonSting, MoveFactory.Leer, MoveFactory.Absorb, MoveFactory.Growth, },
			[4] = new List<Move>() { MoveFactory.Absorb, },
			[7] = new List<Move>() { MoveFactory.Growth, },
			[10] = new List<Move>() { MoveFactory.LeechSeed, },
			[13] = new List<Move>() { MoveFactory.SandAttack, },
			[16] = new List<Move>() { MoveFactory.PoisonJab, },
			[19] = new List<Move>() { MoveFactory.Assurance, },
			[22] = new List<Move>() { MoveFactory.Ingrain, },
			[26] = new List<Move>() { MoveFactory.Payback, },
			[30] = new List<Move>() { MoveFactory.Spikes, },
			[35] = new List<Move>() { MoveFactory.SuckerPunch, },
			[38] = new List<Move>() { MoveFactory.PinMissile, },
			[44] = new List<Move>() { MoveFactory.EnergyBall, },
			[49] = new List<Move>() { MoveFactory.CottonSpore, },
			[54] = new List<Move>() { MoveFactory.Sandstorm, },
			[59] = new List<Move>() { MoveFactory.DestinyBond, },
		};
	}
}

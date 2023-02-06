using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Cacnea : Pokemon
	{
		public override string Name => "Cacnea";
		public override int Generation => 3;
		public override string PokedexEntry => "Cacnea live in deserts with virtually no rainfall. It battles by swinging its thick, spiked arms. Once a year, a yellow flower blooms.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Grass };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.SandVeil, };
		public override Ability AvailableHiddenAbility => AbilityFactory.WaterAbsorb;
		public override Stats BaseStats => new Stats() {
			HP = 50,
			Attack = 85,
			Defense = 40,
			SpecialAttack = 85,
			SpecialDefense = 40,
			Speed = 35
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.PoisonSting, MoveFactory.Leer, },
			[4] = new List<Move>() { MoveFactory.Absorb, },
			[7] = new List<Move>() { MoveFactory.Growth, },
			[10] = new List<Move>() { MoveFactory.LeechSeed, },
			[13] = new List<Move>() { MoveFactory.SandAttack, },
			[16] = new List<Move>() { MoveFactory.PoisonJab, },
			[19] = new List<Move>() { MoveFactory.Assurance, },
			[22] = new List<Move>() { MoveFactory.Ingrain, },
			[26] = new List<Move>() { MoveFactory.Payback, },
			[30] = new List<Move>() { MoveFactory.Spikes, },
			[34] = new List<Move>() { MoveFactory.SuckerPunch, },
			[38] = new List<Move>() { MoveFactory.PinMissile, },
			[42] = new List<Move>() { MoveFactory.EnergyBall, },
			[46] = new List<Move>() { MoveFactory.CottonSpore, },
			[50] = new List<Move>() { MoveFactory.Sandstorm, },
			[54] = new List<Move>() { MoveFactory.DestinyBond, },
		};
	}
}

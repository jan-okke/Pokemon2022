using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Reshiram : Pokemon
	{
		public override string Name => "Reshiram";
		public override int Generation => 5;
		public override string PokedexEntry => "When Reshiram's tail flares, the heat energy moves the atmosphere and changes the world's weather.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Dragon, PokemonType.Fire };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Turboblaze, };
		public override Stats BaseStats => new Stats() {
			HP = 100,
			Attack = 120,
			Defense = 100,
			SpecialAttack = 150,
			SpecialDefense = 120,
			Speed = 90
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.DragonBreath, MoveFactory.NobleRoar, MoveFactory.AncientPower, MoveFactory.FireFang, },
			[8] = new List<Move>() { MoveFactory.Slash, },
			[16] = new List<Move>() { MoveFactory.Crunch, },
			[24] = new List<Move>() { MoveFactory.Extrasensory, },
			[32] = new List<Move>() { MoveFactory.DragonPulse, },
			[40] = new List<Move>() { MoveFactory.Flamethrower, },
			[48] = new List<Move>() { MoveFactory.FusionFlare, },
			[56] = new List<Move>() { MoveFactory.HyperVoice, },
			[64] = new List<Move>() { MoveFactory.FireBlast, },
			[72] = new List<Move>() { MoveFactory.Imprison, },
			[80] = new List<Move>() { MoveFactory.Outrage, },
			[88] = new List<Move>() { MoveFactory.BlueFlare, },
		};
	}
}

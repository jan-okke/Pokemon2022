using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Eternatus : Pokemon
	{
		public override string Name => "Eternatus";
		public override int Generation => 8;
		public override string PokedexEntry => "The core on its chest absorbs energy emanating from the lands of the Galar region. This energy is what allows Eternatus to stay active.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Poison, PokemonType.Dragon };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Pressure, };
		public override Stats BaseStats => new Stats() {
			HP = 140,
			Attack = 85,
			Defense = 95,
			SpecialAttack = 145,
			SpecialDefense = 95,
			Speed = 130
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.PoisonTail, MoveFactory.ConfuseRay, MoveFactory.DragonTail, MoveFactory.Agility, },
			[8] = new List<Move>() { MoveFactory.Toxic, },
			[16] = new List<Move>() { MoveFactory.Venoshock, },
			[24] = new List<Move>() { MoveFactory.DragonDance, },
			[32] = new List<Move>() { MoveFactory.CrossPoison, },
			[40] = new List<Move>() { MoveFactory.DragonPulse, },
			[48] = new List<Move>() { MoveFactory.Flamethrower, },
			[56] = new List<Move>() { MoveFactory.DynamaxCannon, },
			[64] = new List<Move>() { MoveFactory.CosmicPower, },
			[72] = new List<Move>() { MoveFactory.Recover, },
			[80] = new List<Move>() { MoveFactory.HyperBeam, },
			[88] = new List<Move>() { MoveFactory.Eternabeam, },
		};
	}
}

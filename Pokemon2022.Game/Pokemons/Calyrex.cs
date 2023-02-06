using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Calyrex : Pokemon
	{
		public override string Name => "Calyrex";
		public override int Generation => 8;
		public override string PokedexEntry => "Calyrex is a merciful Pokémon, capable of providing healing and blessings. It reigned over the Galar region in times of yore.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Psychic, PokemonType.Grass };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Unnerve, };
		public override Stats BaseStats => new Stats() {
			HP = 100,
			Attack = 80,
			Defense = 80,
			SpecialAttack = 80,
			SpecialDefense = 80,
			Speed = 80
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Pound, MoveFactory.MegaDrain, MoveFactory.Confusion, MoveFactory.Growth, },
			[8] = new List<Move>() { MoveFactory.LifeDew, },
			[16] = new List<Move>() { MoveFactory.GigaDrain, },
			[24] = new List<Move>() { MoveFactory.Psyshock, },
			[32] = new List<Move>() { MoveFactory.HelpingHand, },
			[40] = new List<Move>() { MoveFactory.Aromatherapy, },
			[48] = new List<Move>() { MoveFactory.EnergyBall, },
			[56] = new List<Move>() { MoveFactory.Psychic, },
			[64] = new List<Move>() { MoveFactory.LeechSeed, },
			[72] = new List<Move>() { MoveFactory.HealPulse, },
			[80] = new List<Move>() { MoveFactory.SolarBeam, },
			[88] = new List<Move>() { MoveFactory.FutureSight, },
		};
	}
}

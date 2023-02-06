using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Arceus : Pokemon
	{
		public override string Name => "Arceus";
		public override int Generation => 4;
		public override string PokedexEntry => "It is described in mythology as the Pokémon that shaped the universe with its 1,000 arms.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Normal };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Multitype, };
		public override Stats BaseStats => new Stats() {
			HP = 120,
			Attack = 120,
			Defense = 120,
			SpecialAttack = 120,
			SpecialDefense = 120,
			Speed = 120
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.SeismicToss, MoveFactory.CosmicPower, },
			[10] = new List<Move>() { MoveFactory.Gravity, },
			[20] = new List<Move>() { MoveFactory.EarthPower, },
			[30] = new List<Move>() { MoveFactory.HyperVoice, },
			[40] = new List<Move>() { MoveFactory.ExtremeSpeed, },
			[50] = new List<Move>() { MoveFactory.HealingWish, },
			[60] = new List<Move>() { MoveFactory.FutureSight, },
			[70] = new List<Move>() { MoveFactory.Recover, },
			[80] = new List<Move>() { MoveFactory.HyperBeam, },
			[90] = new List<Move>() { MoveFactory.PerishSong, },
			[100] = new List<Move>() { MoveFactory.Judgment, },
		};
	}
}

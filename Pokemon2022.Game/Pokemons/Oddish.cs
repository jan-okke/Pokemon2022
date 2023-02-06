using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Oddish : Pokemon
	{
		public override string Name => "Oddish";
		public override int Generation => 1;
		public override string PokedexEntry => "It grows by absorbing moonlight. During the daytime, it buries itself in the ground, leaving only its leaves exposed to avoid detection by its enemies.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Grass, PokemonType.Poison };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Chlorophyll, };
		public override Ability AvailableHiddenAbility => AbilityFactory.RunAway;
		public override Stats BaseStats => new Stats() {
			HP = 45,
			Attack = 50,
			Defense = 55,
			SpecialAttack = 75,
			SpecialDefense = 65,
			Speed = 30
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Absorb, MoveFactory.Growth, },
			[4] = new List<Move>() { MoveFactory.Acid, },
			[8] = new List<Move>() { MoveFactory.SweetScent, },
			[12] = new List<Move>() { MoveFactory.MegaDrain, },
			[14] = new List<Move>() { MoveFactory.PoisonPowder, },
			[16] = new List<Move>() { MoveFactory.StunSpore, },
			[18] = new List<Move>() { MoveFactory.SleepPowder, },
			[20] = new List<Move>() { MoveFactory.GigaDrain, },
			[24] = new List<Move>() { MoveFactory.Toxic, },
			[28] = new List<Move>() { MoveFactory.Moonblast, },
			[32] = new List<Move>() { MoveFactory.GrassyTerrain, },
			[36] = new List<Move>() { MoveFactory.Moonlight, },
			[40] = new List<Move>() { MoveFactory.PetalDance, },
		};
	}
}

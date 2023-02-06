using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Shaymin : Pokemon
	{
		public override string Name => "Shaymin";
		public override int Generation => 4;
		public override string PokedexEntry => "It lives in flower patches and avoids detection by curling up to look like a flowering plant.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Grass };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.NaturalCure, };
		public override Stats BaseStats => new Stats() {
			HP = 100,
			Attack = 100,
			Defense = 100,
			SpecialAttack = 100,
			SpecialDefense = 100,
			Speed = 100
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Growth, },
			[10] = new List<Move>() { MoveFactory.MagicalLeaf, },
			[19] = new List<Move>() { MoveFactory.LeechSeed, },
			[28] = new List<Move>() { MoveFactory.Synthesis, },
			[37] = new List<Move>() { MoveFactory.SweetScent, },
			[46] = new List<Move>() { MoveFactory.HealingWish, },
			[55] = new List<Move>() { MoveFactory.WorrySeed, },
			[64] = new List<Move>() { MoveFactory.Aromatherapy, },
			[73] = new List<Move>() { MoveFactory.EnergyBall, },
			[82] = new List<Move>() { MoveFactory.SweetKiss, },
			[91] = new List<Move>() { MoveFactory.HealingWish, },
			[100] = new List<Move>() { MoveFactory.SeedFlare, },
		};
	}
}

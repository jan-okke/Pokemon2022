using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Celebi : Pokemon
	{
		public override string Name => "Celebi";
		public override int Generation => 2;
		public override string PokedexEntry => "This Pokémon came from the future by crossing over time. It is thought that so long as Celebi appears, a bright and shining future awaits us.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Psychic, PokemonType.Grass };
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
			[1] = new List<Move>() { MoveFactory.Confusion, MoveFactory.HealBell, },
			[10] = new List<Move>() { MoveFactory.MagicalLeaf, },
			[20] = new List<Move>() { MoveFactory.BatonPass, },
			[30] = new List<Move>() { MoveFactory.AncientPower, },
			[40] = new List<Move>() { MoveFactory.LifeDew, },
			[50] = new List<Move>() { MoveFactory.LeechSeed, },
			[60] = new List<Move>() { MoveFactory.Recover, },
			[70] = new List<Move>() { MoveFactory.FutureSight, },
			[80] = new List<Move>() { MoveFactory.HealingWish, },
			[90] = new List<Move>() { MoveFactory.LeafStorm, },
			[100] = new List<Move>() { MoveFactory.PerishSong, },
		};
	}
}

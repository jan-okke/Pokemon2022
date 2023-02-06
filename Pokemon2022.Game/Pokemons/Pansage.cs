using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Pansage : Pokemon
	{
		public override string Name => "Pansage";
		public override int Generation => 5;
		public override string PokedexEntry => "It shares the leaf on its head with weary-looking Pokémon. These leaves are known to relieve stress.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Grass };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Gluttony, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Overgrow;
		public override Stats BaseStats => new Stats() {
			HP = 50,
			Attack = 53,
			Defense = 48,
			SpecialAttack = 53,
			SpecialDefense = 48,
			Speed = 64
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Scratch, MoveFactory.PlayNice, },
			[4] = new List<Move>() { MoveFactory.Leer, },
			[7] = new List<Move>() { MoveFactory.Lick, },
			[10] = new List<Move>() { MoveFactory.VineWhip, },
			[13] = new List<Move>() { MoveFactory.FurySwipes, },
			[16] = new List<Move>() { MoveFactory.LeechSeed, },
			[19] = new List<Move>() { MoveFactory.Bite, },
			[22] = new List<Move>() { MoveFactory.SeedBomb, },
			[25] = new List<Move>() { MoveFactory.Torment, },
			[28] = new List<Move>() { MoveFactory.Fling, },
			[31] = new List<Move>() { MoveFactory.Acrobatics, },
			[34] = new List<Move>() { MoveFactory.GrassKnot, },
			[37] = new List<Move>() { MoveFactory.Recycle, },
			[40] = new List<Move>() { MoveFactory.NaturalGift, },
			[43] = new List<Move>() { MoveFactory.Crunch, },
		};
	}
}

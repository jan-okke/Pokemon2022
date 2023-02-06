using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Floette : Pokemon
	{
		public override string Name => "Floette";
		public override int Generation => 6;
		public override string PokedexEntry => "It flutters around fields of flowers and cares for flowers that are starting to wilt. It draws out the power of flowers to battle.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Fairy };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.FlowerVeil, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Symbiosis;
		public override Stats BaseStats => new Stats() {
			HP = 54,
			Attack = 45,
			Defense = 47,
			SpecialAttack = 75,
			SpecialDefense = 98,
			Speed = 52
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Tackle, MoveFactory.VineWhip, MoveFactory.FairyWind, },
			[6] = new List<Move>() { MoveFactory.FairyWind, },
			[10] = new List<Move>() { MoveFactory.LuckyChant, },
			[15] = new List<Move>() { MoveFactory.RazorLeaf, },
			[20] = new List<Move>() { MoveFactory.Wish, },
			[25] = new List<Move>() { MoveFactory.MagicalLeaf, },
			[27] = new List<Move>() { MoveFactory.GrassyTerrain, },
			[33] = new List<Move>() { MoveFactory.PetalBlizzard, },
			[38] = new List<Move>() { MoveFactory.Aromatherapy, },
			[43] = new List<Move>() { MoveFactory.MistyTerrain, },
			[46] = new List<Move>() { MoveFactory.Moonblast, },
			[51] = new List<Move>() { MoveFactory.PetalDance, },
			[58] = new List<Move>() { MoveFactory.SolarBeam, },
		};
	}
}

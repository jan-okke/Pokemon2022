using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Flabébé : Pokemon
	{
		public override string Name => "Flabébé";
		public override int Generation => 6;
		public override string PokedexEntry => "When it finds a flower it likes, it dwells on that flower its whole life long. It floats in the wind's embrace with an untroubled heart.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Fairy };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.FlowerVeil, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Symbiosis;
		public override Stats BaseStats => new Stats() {
			HP = 44,
			Attack = 38,
			Defense = 39,
			SpecialAttack = 61,
			SpecialDefense = 79,
			Speed = 42
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Tackle, MoveFactory.VineWhip, },
			[6] = new List<Move>() { MoveFactory.FairyWind, },
			[10] = new List<Move>() { MoveFactory.LuckyChant, },
			[15] = new List<Move>() { MoveFactory.RazorLeaf, },
			[20] = new List<Move>() { MoveFactory.Wish, },
			[22] = new List<Move>() { MoveFactory.MagicalLeaf, },
			[24] = new List<Move>() { MoveFactory.GrassyTerrain, },
			[28] = new List<Move>() { MoveFactory.PetalBlizzard, },
			[33] = new List<Move>() { MoveFactory.Aromatherapy, },
			[37] = new List<Move>() { MoveFactory.MistyTerrain, },
			[41] = new List<Move>() { MoveFactory.Moonblast, },
			[45] = new List<Move>() { MoveFactory.PetalDance, },
			[48] = new List<Move>() { MoveFactory.SolarBeam, },
		};
	}
}

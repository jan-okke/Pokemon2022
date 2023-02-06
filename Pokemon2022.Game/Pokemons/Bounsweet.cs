using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Bounsweet : Pokemon
	{
		public override string Name => "Bounsweet";
		public override int Generation => 7;
		public override string PokedexEntry => "Because of its sweet, delicious aroma, bird Pokémon are always after it, but it's not intelligent enough to care.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Grass };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.LeafGuard, AbilityFactory.Oblivious, };
		public override Ability AvailableHiddenAbility => AbilityFactory.SweetVeil;
		public override Stats BaseStats => new Stats() {
			HP = 42,
			Attack = 30,
			Defense = 38,
			SpecialAttack = 30,
			SpecialDefense = 38,
			Speed = 32
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Splash, },
			[4] = new List<Move>() { MoveFactory.PlayNice, },
			[8] = new List<Move>() { MoveFactory.RapidSpin, },
			[12] = new List<Move>() { MoveFactory.RazorLeaf, },
			[16] = new List<Move>() { MoveFactory.SweetScent, },
			[20] = new List<Move>() { MoveFactory.MagicalLeaf, },
			[24] = new List<Move>() { MoveFactory.Flail, },
			[28] = new List<Move>() { MoveFactory.TeeterDance, },
			[32] = new List<Move>() { MoveFactory.AromaticMist, },
			[36] = new List<Move>() { MoveFactory.Aromatherapy, },
		};
	}
}

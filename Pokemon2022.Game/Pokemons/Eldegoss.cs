using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Eldegoss : Pokemon
	{
		public override string Name => "Eldegoss";
		public override int Generation => 8;
		public override string PokedexEntry => "The seeds attached to its cotton fluff are full of nutrients. It spreads them on the wind so that plants and other Pokémon can benefit from them.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Grass };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.CottonDown, AbilityFactory.Regenerator, };
		public override Ability AvailableHiddenAbility => AbilityFactory.EffectSpore;
		public override Stats BaseStats => new Stats() {
			HP = 60,
			Attack = 50,
			Defense = 90,
			SpecialAttack = 80,
			SpecialDefense = 120,
			Speed = 60
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[0] = new List<Move>() { MoveFactory.CottonSpore, },
			[1] = new List<Move>() { MoveFactory.CottonSpore, MoveFactory.Leafage, MoveFactory.Sing, MoveFactory.RapidSpin, MoveFactory.SweetScent, },
			[12] = new List<Move>() { MoveFactory.RazorLeaf, },
			[16] = new List<Move>() { MoveFactory.Round, },
			[23] = new List<Move>() { MoveFactory.LeafTornado, },
			[28] = new List<Move>() { MoveFactory.Synthesis, },
			[34] = new List<Move>() { MoveFactory.HyperVoice, },
			[40] = new List<Move>() { MoveFactory.Aromatherapy, },
			[46] = new List<Move>() { MoveFactory.LeafStorm, },
			[52] = new List<Move>() { MoveFactory.CottonGuard, },
		};
	}
}

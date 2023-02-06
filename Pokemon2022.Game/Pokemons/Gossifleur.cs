using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Gossifleur : Pokemon
	{
		public override string Name => "Gossifleur";
		public override int Generation => 8;
		public override string PokedexEntry => "It anchors itself in the ground with its single leg, then basks in the sun. After absorbing enough sunlight, its petals spread as it blooms brilliantly.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Grass };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.CottonDown, AbilityFactory.Regenerator, };
		public override Ability AvailableHiddenAbility => AbilityFactory.EffectSpore;
		public override Stats BaseStats => new Stats() {
			HP = 40,
			Attack = 40,
			Defense = 60,
			SpecialAttack = 40,
			SpecialDefense = 60,
			Speed = 10
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Leafage, MoveFactory.Sing, },
			[4] = new List<Move>() { MoveFactory.RapidSpin, },
			[8] = new List<Move>() { MoveFactory.SweetScent, },
			[12] = new List<Move>() { MoveFactory.RazorLeaf, },
			[16] = new List<Move>() { MoveFactory.Round, },
			[21] = new List<Move>() { MoveFactory.LeafTornado, },
			[24] = new List<Move>() { MoveFactory.Synthesis, },
			[28] = new List<Move>() { MoveFactory.HyperVoice, },
			[32] = new List<Move>() { MoveFactory.Aromatherapy, },
			[36] = new List<Move>() { MoveFactory.LeafStorm, },
		};
	}
}

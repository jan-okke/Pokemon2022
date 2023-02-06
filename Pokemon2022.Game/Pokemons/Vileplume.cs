using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Vileplume : Pokemon
	{
		public override string Name => "Vileplume";
		public override int Generation => 1;
		public override string PokedexEntry => "In seasons when it produces more pollen, the air around a Vileplume turns yellow with the powder as it walks. The pollen is highly toxic and causes paralysis.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Grass, PokemonType.Poison };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Chlorophyll, };
		public override Ability AvailableHiddenAbility => AbilityFactory.EffectSpore;
		public override Stats BaseStats => new Stats() {
			HP = 75,
			Attack = 80,
			Defense = 85,
			SpecialAttack = 110,
			SpecialDefense = 90,
			Speed = 50
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[0] = new List<Move>() { MoveFactory.PetalBlizzard, },
			[1] = new List<Move>() { MoveFactory.PetalBlizzard, MoveFactory.Aromatherapy, MoveFactory.MegaDrain, MoveFactory.PoisonPowder, MoveFactory.StunSpore, MoveFactory.SleepPowder, MoveFactory.GigaDrain, MoveFactory.Toxic, MoveFactory.Moonblast, MoveFactory.GrassyTerrain, MoveFactory.Moonlight, MoveFactory.PetalDance, MoveFactory.Absorb, MoveFactory.Growth, MoveFactory.Acid, MoveFactory.SweetScent, },
		};
	}
}

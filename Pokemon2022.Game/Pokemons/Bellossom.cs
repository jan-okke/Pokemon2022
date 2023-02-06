using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Bellossom : Pokemon
	{
		public override string Name => "Bellossom";
		public override int Generation => 2;
		public override string PokedexEntry => "Its flower petals deepen in color through exposure to sunlight. When cloudy weather persists, it does a dance that is thought to be a sun-summoning ritual.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Grass };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Chlorophyll, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Healer;
		public override Stats BaseStats => new Stats() {
			HP = 75,
			Attack = 80,
			Defense = 95,
			SpecialAttack = 90,
			SpecialDefense = 100,
			Speed = 50
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[0] = new List<Move>() { MoveFactory.PetalBlizzard, },
			[1] = new List<Move>() { MoveFactory.PetalBlizzard, MoveFactory.QuiverDance, MoveFactory.MegaDrain, MoveFactory.PoisonPowder, MoveFactory.StunSpore, MoveFactory.SleepPowder, MoveFactory.GigaDrain, MoveFactory.Toxic, MoveFactory.Moonblast, MoveFactory.GrassyTerrain, MoveFactory.Moonlight, MoveFactory.PetalDance, MoveFactory.Absorb, MoveFactory.Growth, MoveFactory.Acid, MoveFactory.SweetScent, },
		};
	}
}

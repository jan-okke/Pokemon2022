using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Exeggutor : Pokemon
	{
		public override string Name => "Exeggutor";
		public override int Generation => 1;
		public override string PokedexEntry => "Originally from the tropics, Exeggutor's heads grow larger with exposure to bright sunlight. It is said that when the heads fall, they group to form an Exeggcute.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Grass, PokemonType.Psychic };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Chlorophyll, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Harvest;
		public override Stats BaseStats => new Stats() {
			HP = 95,
			Attack = 95,
			Defense = 85,
			SpecialAttack = 125,
			SpecialDefense = 75,
			Speed = 55
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[0] = new List<Move>() { MoveFactory.Stomp, },
			[1] = new List<Move>() { MoveFactory.Stomp, MoveFactory.SeedBomb, MoveFactory.Psyshock, MoveFactory.WoodHammer, MoveFactory.LeafStorm, MoveFactory.MegaDrain, MoveFactory.Confusion, MoveFactory.Synthesis, MoveFactory.BulletSeed, MoveFactory.GigaDrain, MoveFactory.Extrasensory, MoveFactory.Uproar, MoveFactory.WorrySeed, MoveFactory.SolarBeam, MoveFactory.Absorb, MoveFactory.Hypnosis, MoveFactory.Reflect, MoveFactory.LeechSeed, },
		};
	}
}

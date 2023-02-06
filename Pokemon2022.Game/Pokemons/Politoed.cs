using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Politoed : Pokemon
	{
		public override string Name => "Politoed";
		public override int Generation => 2;
		public override string PokedexEntry => "The curled hair on its head proves its status as a king. It is said that the longer and curlier the hair, the more respect it earns from its peers.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Water };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.WaterAbsorb, AbilityFactory.Damp, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Drizzle;
		public override Stats BaseStats => new Stats() {
			HP = 90,
			Attack = 75,
			Defense = 75,
			SpecialAttack = 90,
			SpecialDefense = 100,
			Speed = 70
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[0] = new List<Move>() { MoveFactory.Bounce, },
			[1] = new List<Move>() { MoveFactory.Bounce, MoveFactory.Swagger, MoveFactory.HyperVoice, MoveFactory.PerishSong, MoveFactory.BubbleBeam, MoveFactory.RainDance, MoveFactory.BodySlam, MoveFactory.EarthPower, MoveFactory.HydroPump, MoveFactory.BellyDrum, MoveFactory.DoubleEdge, MoveFactory.WaterGun, MoveFactory.Hypnosis, MoveFactory.Pound, MoveFactory.MudShot, },
		};
	}
}

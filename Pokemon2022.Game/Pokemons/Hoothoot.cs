using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Hoothoot : Pokemon
	{
		public override string Name => "Hoothoot";
		public override int Generation => 2;
		public override string PokedexEntry => "It has an internal organ that senses the earth's rotation. Using this special organ, a Hoothoot begins hooting at precisely the same time every day.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Normal, PokemonType.Flying };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Insomnia, AbilityFactory.KeenEye, };
		public override Ability AvailableHiddenAbility => AbilityFactory.TintedLens;
		public override Stats BaseStats => new Stats() {
			HP = 60,
			Attack = 30,
			Defense = 30,
			SpecialAttack = 36,
			SpecialDefense = 56,
			Speed = 50
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Peck, MoveFactory.Growl, },
			[3] = new List<Move>() { MoveFactory.Tackle, },
			[6] = new List<Move>() { MoveFactory.EchoedVoice, },
			[9] = new List<Move>() { MoveFactory.Confusion, },
			[12] = new List<Move>() { MoveFactory.Reflect, },
			[15] = new List<Move>() { MoveFactory.PsychoShift, },
			[18] = new List<Move>() { MoveFactory.AirSlash, },
			[21] = new List<Move>() { MoveFactory.Extrasensory, },
			[24] = new List<Move>() { MoveFactory.TakeDown, },
			[27] = new List<Move>() { MoveFactory.Uproar, },
			[30] = new List<Move>() { MoveFactory.Roost, },
			[33] = new List<Move>() { MoveFactory.Moonblast, },
			[36] = new List<Move>() { MoveFactory.Hypnosis, },
			[39] = new List<Move>() { MoveFactory.DreamEater, },
		};
	}
}

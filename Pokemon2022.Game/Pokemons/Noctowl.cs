using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Noctowl : Pokemon
	{
		public override string Name => "Noctowl";
		public override int Generation => 2;
		public override string PokedexEntry => "It unfailingly catches prey in darkness. Noctowl owe their success to superior vision that allows them to see in minimal light, and to their supple and silent wings.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Normal, PokemonType.Flying };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Insomnia, AbilityFactory.KeenEye, };
		public override Ability AvailableHiddenAbility => AbilityFactory.TintedLens;
		public override Stats BaseStats => new Stats() {
			HP = 100,
			Attack = 50,
			Defense = 50,
			SpecialAttack = 86,
			SpecialDefense = 96,
			Speed = 70
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.SkyAttack, MoveFactory.Peck, MoveFactory.Growl, MoveFactory.Tackle, MoveFactory.EchoedVoice, },
			[9] = new List<Move>() { MoveFactory.Confusion, },
			[12] = new List<Move>() { MoveFactory.Reflect, },
			[15] = new List<Move>() { MoveFactory.PsychoShift, },
			[18] = new List<Move>() { MoveFactory.AirSlash, },
			[23] = new List<Move>() { MoveFactory.Extrasensory, },
			[28] = new List<Move>() { MoveFactory.TakeDown, },
			[33] = new List<Move>() { MoveFactory.Uproar, },
			[38] = new List<Move>() { MoveFactory.Roost, },
			[43] = new List<Move>() { MoveFactory.Moonblast, },
			[48] = new List<Move>() { MoveFactory.Hypnosis, },
			[53] = new List<Move>() { MoveFactory.DreamEater, },
		};
	}
}

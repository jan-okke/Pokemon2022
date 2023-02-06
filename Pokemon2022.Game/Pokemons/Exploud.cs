using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Exploud : Pokemon
	{
		public override string Name => "Exploud";
		public override int Generation => 3;
		public override string PokedexEntry => "It has sound-generating organs all over its body. It communicates with others by adjusting the tone and volume of the cries it emits.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Normal };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Soundproof, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Scrappy;
		public override Stats BaseStats => new Stats() {
			HP = 104,
			Attack = 91,
			Defense = 63,
			SpecialAttack = 91,
			SpecialDefense = 73,
			Speed = 68
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[0] = new List<Move>() { MoveFactory.Crunch, },
			[1] = new List<Move>() { MoveFactory.Crunch, MoveFactory.Bite, MoveFactory.IceFang, MoveFactory.FireFang, MoveFactory.ThunderFang, MoveFactory.Astonish, MoveFactory.Pound, MoveFactory.EchoedVoice, MoveFactory.Howl, },
			[15] = new List<Move>() { MoveFactory.Rest, MoveFactory.SleepTalk, },
			[23] = new List<Move>() { MoveFactory.Stomp, },
			[29] = new List<Move>() { MoveFactory.Roar, },
			[36] = new List<Move>() { MoveFactory.Supersonic, },
			[45] = new List<Move>() { MoveFactory.Uproar, },
			[54] = new List<Move>() { MoveFactory.Screech, },
			[63] = new List<Move>() { MoveFactory.HyperVoice, },
			[72] = new List<Move>() { MoveFactory.Boomburst, },
			[81] = new List<Move>() { MoveFactory.HyperBeam, },
		};
	}
}

using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Whismur : Pokemon
	{
		public override string Name => "Whismur";
		public override int Generation => 3;
		public override string PokedexEntry => "Its cries equal a jet plane in volume. It inhales through its ear canals. Because of this system, it can cry continually without having to catch its breath.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Normal };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Soundproof, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Rattled;
		public override Stats BaseStats => new Stats() {
			HP = 64,
			Attack = 51,
			Defense = 23,
			SpecialAttack = 51,
			SpecialDefense = 23,
			Speed = 28
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Astonish, MoveFactory.Pound, },
			[5] = new List<Move>() { MoveFactory.EchoedVoice, },
			[10] = new List<Move>() { MoveFactory.Howl, },
			[15] = new List<Move>() { MoveFactory.Rest, MoveFactory.SleepTalk, },
			[21] = new List<Move>() { MoveFactory.Stomp, },
			[25] = new List<Move>() { MoveFactory.Roar, },
			[30] = new List<Move>() { MoveFactory.Supersonic, },
			[35] = new List<Move>() { MoveFactory.Uproar, },
			[40] = new List<Move>() { MoveFactory.Screech, },
			[45] = new List<Move>() { MoveFactory.HyperVoice, },
		};
	}
}

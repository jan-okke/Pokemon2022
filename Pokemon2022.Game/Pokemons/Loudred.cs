using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Loudred : Pokemon
	{
		public override string Name => "Loudred";
		public override int Generation => 3;
		public override string PokedexEntry => "It positions the round speakers on its head to assail foes with ultrasonic waves at massive volume. It builds power by stomping the ground.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Normal };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Soundproof, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Scrappy;
		public override Stats BaseStats => new Stats() {
			HP = 84,
			Attack = 71,
			Defense = 43,
			SpecialAttack = 71,
			SpecialDefense = 43,
			Speed = 48
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[0] = new List<Move>() { MoveFactory.Bite, },
			[1] = new List<Move>() { MoveFactory.Bite, MoveFactory.Astonish, MoveFactory.Pound, MoveFactory.EchoedVoice, MoveFactory.Howl, },
			[15] = new List<Move>() { MoveFactory.Rest, MoveFactory.SleepTalk, },
			[23] = new List<Move>() { MoveFactory.Stomp, },
			[29] = new List<Move>() { MoveFactory.Roar, },
			[36] = new List<Move>() { MoveFactory.Supersonic, },
			[43] = new List<Move>() { MoveFactory.Uproar, },
			[50] = new List<Move>() { MoveFactory.Screech, },
			[57] = new List<Move>() { MoveFactory.HyperVoice, },
		};
	}
}

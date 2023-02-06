using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Minccino : Pokemon
	{
		public override string Name => "Minccino";
		public override int Generation => 5;
		public override string PokedexEntry => "These Pokémon prefer a tidy habitat. They are always sweeping and dusting, using their tails as brooms.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Normal };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.CuteCharm, AbilityFactory.Technician, };
		public override Ability AvailableHiddenAbility => AbilityFactory.SkillLink;
		public override Stats BaseStats => new Stats() {
			HP = 55,
			Attack = 50,
			Defense = 40,
			SpecialAttack = 40,
			SpecialDefense = 40,
			Speed = 75
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Pound, MoveFactory.BabyDollEyes, },
			[4] = new List<Move>() { MoveFactory.HelpingHand, },
			[8] = new List<Move>() { MoveFactory.EchoedVoice, },
			[12] = new List<Move>() { MoveFactory.Sing, },
			[16] = new List<Move>() { MoveFactory.Charm, },
			[20] = new List<Move>() { MoveFactory.Swift, },
			[24] = new List<Move>() { MoveFactory.Encore, },
			[28] = new List<Move>() { MoveFactory.AfterYou, },
			[32] = new List<Move>() { MoveFactory.TailSlap, },
			[36] = new List<Move>() { MoveFactory.Tickle, },
			[40] = new List<Move>() { MoveFactory.Slam, },
			[44] = new List<Move>() { MoveFactory.HyperVoice, },
			[48] = new List<Move>() { MoveFactory.LastResort, },
		};
	}
}

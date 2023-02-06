using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Jigglypuff : Pokemon
	{
		public override string Name => "Jigglypuff";
		public override int Generation => 1;
		public override string PokedexEntry => "Nothing can avoid falling asleep hearing a Jigglypuff's song. The sound waves of its singing voice match the brain waves of someone in a deep sleep.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Normal, PokemonType.Fairy };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.CuteCharm, AbilityFactory.Competitive, };
		public override Ability AvailableHiddenAbility => AbilityFactory.FriendGuard;
		public override Stats BaseStats => new Stats() {
			HP = 115,
			Attack = 45,
			Defense = 20,
			SpecialAttack = 45,
			SpecialDefense = 25,
			Speed = 20
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.SweetKiss, MoveFactory.DisarmingVoice, MoveFactory.Disable, MoveFactory.Charm, MoveFactory.Sing, MoveFactory.Pound, MoveFactory.Copycat, MoveFactory.DefenseCurl, },
			[4] = new List<Move>() { MoveFactory.EchoedVoice, },
			[8] = new List<Move>() { MoveFactory.Covet, },
			[12] = new List<Move>() { MoveFactory.Stockpile, MoveFactory.Swallow, MoveFactory.SpitUp, },
			[16] = new List<Move>() { MoveFactory.Round, },
			[20] = new List<Move>() { MoveFactory.Rest, },
			[24] = new List<Move>() { MoveFactory.BodySlam, },
			[28] = new List<Move>() { MoveFactory.Mimic, },
			[32] = new List<Move>() { MoveFactory.GyroBall, },
			[36] = new List<Move>() { MoveFactory.HyperVoice, },
			[40] = new List<Move>() { MoveFactory.PlayRough, },
			[44] = new List<Move>() { MoveFactory.DoubleEdge, },
		};
	}
}

using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Lickitung : Pokemon
	{
		public override string Name => "Lickitung";
		public override int Generation => 1;
		public override string PokedexEntry => "Whenever it sees something unfamiliar, it always licks the object because it memorizes things by texture and taste. It is somewhat put off by sour things.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Normal };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.OwnTempo, AbilityFactory.Oblivious, };
		public override Ability AvailableHiddenAbility => AbilityFactory.CloudNine;
		public override Stats BaseStats => new Stats() {
			HP = 90,
			Attack = 55,
			Defense = 75,
			SpecialAttack = 60,
			SpecialDefense = 75,
			Speed = 30
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Lick, MoveFactory.DefenseCurl, },
			[6] = new List<Move>() { MoveFactory.Rollout, },
			[12] = new List<Move>() { MoveFactory.Supersonic, },
			[18] = new List<Move>() { MoveFactory.Wrap, },
			[24] = new List<Move>() { MoveFactory.Disable, },
			[30] = new List<Move>() { MoveFactory.Stomp, },
			[36] = new List<Move>() { MoveFactory.KnockOff, },
			[42] = new List<Move>() { MoveFactory.Screech, },
			[48] = new List<Move>() { MoveFactory.Slam, },
			[54] = new List<Move>() { MoveFactory.PowerWhip, },
			[60] = new List<Move>() { MoveFactory.BellyDrum, },
		};
	}
}

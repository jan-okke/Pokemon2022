using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Lickilicky : Pokemon
	{
		public override string Name => "Lickilicky";
		public override int Generation => 4;
		public override string PokedexEntry => "It wraps things with its extensible tongue. Getting too close to it will leave you soaked with drool.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Normal };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.OwnTempo, AbilityFactory.Oblivious, };
		public override Ability AvailableHiddenAbility => AbilityFactory.CloudNine;
		public override Stats BaseStats => new Stats() {
			HP = 110,
			Attack = 85,
			Defense = 95,
			SpecialAttack = 80,
			SpecialDefense = 95,
			Speed = 50
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Lick, MoveFactory.DefenseCurl, MoveFactory.Rollout, MoveFactory.Supersonic, },
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

using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Happiny : Pokemon
	{
		public override string Name => "Happiny";
		public override int Generation => 4;
		public override string PokedexEntry => "It loves round white things. It carries an egg-shaped rock in imitation of Chansey.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Normal };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.NaturalCure, AbilityFactory.SereneGrace, };
		public override Ability AvailableHiddenAbility => AbilityFactory.FriendGuard;
		public override Stats BaseStats => new Stats() {
			HP = 100,
			Attack = 5,
			Defense = 5,
			SpecialAttack = 15,
			SpecialDefense = 65,
			Speed = 30
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Minimize, MoveFactory.Pound, MoveFactory.Copycat, },
			[4] = new List<Move>() { MoveFactory.DefenseCurl, },
			[8] = new List<Move>() { MoveFactory.SweetKiss, },
			[12] = new List<Move>() { MoveFactory.DisarmingVoice, },
			[16] = new List<Move>() { MoveFactory.Covet, },
			[20] = new List<Move>() { MoveFactory.Charm, },
		};
	}
}

using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Clefairy : Pokemon
	{
		public override string Name => "Clefairy";
		public override int Generation => 1;
		public override string PokedexEntry => "On every night of a full moon, they come out to play. When dawn arrives, the tired Clefairy go to sleep nestled up against each other in deep and quiet mountains.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Fairy };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.CuteCharm, AbilityFactory.MagicGuard, };
		public override Ability AvailableHiddenAbility => AbilityFactory.FriendGuard;
		public override Stats BaseStats => new Stats() {
			HP = 70,
			Attack = 45,
			Defense = 48,
			SpecialAttack = 60,
			SpecialDefense = 65,
			Speed = 35
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Sing, MoveFactory.SweetKiss, MoveFactory.DisarmingVoice, MoveFactory.Encore, MoveFactory.Charm, MoveFactory.Splash, MoveFactory.Pound, MoveFactory.Copycat, MoveFactory.Growl, MoveFactory.DefenseCurl, },
			[4] = new List<Move>() { MoveFactory.StoredPower, },
			[8] = new List<Move>() { MoveFactory.Minimize, },
			[12] = new List<Move>() { MoveFactory.AfterYou, },
			[16] = new List<Move>() { MoveFactory.LifeDew, },
			[20] = new List<Move>() { MoveFactory.Metronome, },
			[24] = new List<Move>() { MoveFactory.Moonlight, },
			[28] = new List<Move>() { MoveFactory.Gravity, },
			[32] = new List<Move>() { MoveFactory.MeteorMash, },
			[36] = new List<Move>() { MoveFactory.FollowMe, },
			[40] = new List<Move>() { MoveFactory.CosmicPower, },
			[44] = new List<Move>() { MoveFactory.Moonblast, },
			[48] = new List<Move>() { MoveFactory.HealingWish, },
		};
	}
}

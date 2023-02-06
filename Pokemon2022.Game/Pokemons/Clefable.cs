using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Clefable : Pokemon
	{
		public override string Name => "Clefable";
		public override int Generation => 1;
		public override string PokedexEntry => "A Clefable uses its wings to skip lightly as if it were flying. Its bouncy step lets it even walk on water. On quiet, moonlit nights, it strolls on lakes.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Fairy };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.CuteCharm, AbilityFactory.MagicGuard, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Unaware;
		public override Stats BaseStats => new Stats() {
			HP = 95,
			Attack = 70,
			Defense = 73,
			SpecialAttack = 95,
			SpecialDefense = 90,
			Speed = 60
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Sing, MoveFactory.SweetKiss, MoveFactory.DisarmingVoice, MoveFactory.Encore, MoveFactory.Charm, MoveFactory.StoredPower, MoveFactory.Minimize, MoveFactory.AfterYou, MoveFactory.LifeDew, MoveFactory.Metronome, MoveFactory.Moonlight, MoveFactory.Gravity, MoveFactory.MeteorMash, MoveFactory.FollowMe, MoveFactory.CosmicPower, MoveFactory.Moonblast, MoveFactory.HealingWish, MoveFactory.Splash, MoveFactory.Pound, MoveFactory.Copycat, MoveFactory.Growl, MoveFactory.DefenseCurl, },
		};
	}
}

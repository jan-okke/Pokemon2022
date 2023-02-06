using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Swablu : Pokemon
	{
		public override string Name => "Swablu";
		public override int Generation => 3;
		public override string PokedexEntry => "A Pokémon that has wings like cottony clouds. After enduring winter, in which little food is available, Swablu flocks move closer to towns in the spring.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Normal, PokemonType.Flying };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.NaturalCure, };
		public override Ability AvailableHiddenAbility => AbilityFactory.CloudNine;
		public override Stats BaseStats => new Stats() {
			HP = 45,
			Attack = 40,
			Defense = 60,
			SpecialAttack = 40,
			SpecialDefense = 75,
			Speed = 50
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Peck, MoveFactory.Growl, },
			[4] = new List<Move>() { MoveFactory.DisarmingVoice, },
			[8] = new List<Move>() { MoveFactory.Mist, },
			[12] = new List<Move>() { MoveFactory.FuryAttack, },
			[16] = new List<Move>() { MoveFactory.Round, },
			[20] = new List<Move>() { MoveFactory.DragonBreath, },
			[24] = new List<Move>() { MoveFactory.Safeguard, },
			[28] = new List<Move>() { MoveFactory.Sing, },
			[32] = new List<Move>() { MoveFactory.CottonGuard, },
			[36] = new List<Move>() { MoveFactory.TakeDown, },
			[40] = new List<Move>() { MoveFactory.Moonblast, },
			[44] = new List<Move>() { MoveFactory.PerishSong, },
		};
	}
}

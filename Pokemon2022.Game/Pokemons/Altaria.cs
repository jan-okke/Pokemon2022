using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Altaria : Pokemon
	{
		public override string Name => "Altaria";
		public override int Generation => 3;
		public override string PokedexEntry => "It hums in a beautiful soprano voice. It flies among white clouds in the blue sky. It launches intensely hot fireballs from its mouth.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Dragon, PokemonType.Flying };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.NaturalCure, };
		public override Ability AvailableHiddenAbility => AbilityFactory.CloudNine;
		public override Stats BaseStats => new Stats() {
			HP = 75,
			Attack = 70,
			Defense = 90,
			SpecialAttack = 70,
			SpecialDefense = 105,
			Speed = 80
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[0] = new List<Move>() { MoveFactory.DragonPulse, },
			[1] = new List<Move>() { MoveFactory.Hurricane, MoveFactory.DragonPulse, MoveFactory.Pluck, MoveFactory.Peck, MoveFactory.Growl, MoveFactory.DisarmingVoice, MoveFactory.Mist, },
			[12] = new List<Move>() { MoveFactory.FuryAttack, },
			[16] = new List<Move>() { MoveFactory.Round, },
			[20] = new List<Move>() { MoveFactory.DragonBreath, },
			[24] = new List<Move>() { MoveFactory.Safeguard, },
			[28] = new List<Move>() { MoveFactory.Sing, },
			[32] = new List<Move>() { MoveFactory.CottonGuard, },
			[38] = new List<Move>() { MoveFactory.TakeDown, },
			[44] = new List<Move>() { MoveFactory.Moonblast, },
			[50] = new List<Move>() { MoveFactory.PerishSong, },
			[56] = new List<Move>() { MoveFactory.SkyAttack, },
		};
	}
}

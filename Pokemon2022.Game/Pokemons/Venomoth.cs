using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Venomoth : Pokemon
	{
		public override string Name => "Venomoth";
		public override int Generation => 1;
		public override string PokedexEntry => "Venomoth are nocturnal--they only are active at night. Their favorite prey are insects that gather around streetlights, attracted by the light in the darkness.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Bug, PokemonType.Poison };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.ShieldDust, AbilityFactory.TintedLens, };
		public override Ability AvailableHiddenAbility => AbilityFactory.WonderSkin;
		public override Stats BaseStats => new Stats() {
			HP = 70,
			Attack = 65,
			Defense = 60,
			SpecialAttack = 90,
			SpecialDefense = 75,
			Speed = 90
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[0] = new List<Move>() { MoveFactory.Gust, },
			[1] = new List<Move>() { MoveFactory.Gust, MoveFactory.QuiverDance, MoveFactory.BugBuzz, MoveFactory.Whirlwind, MoveFactory.Tackle, MoveFactory.Disable, MoveFactory.StruggleBug, MoveFactory.Supersonic, },
			[5] = new List<Move>() { MoveFactory.Supersonic, },
			[11] = new List<Move>() { MoveFactory.Confusion, },
			[13] = new List<Move>() { MoveFactory.PoisonPowder, },
			[17] = new List<Move>() { MoveFactory.Psybeam, },
			[23] = new List<Move>() { MoveFactory.StunSpore, },
			[25] = new List<Move>() { MoveFactory.MegaDrain, },
			[29] = new List<Move>() { MoveFactory.SleepPowder, },
			[37] = new List<Move>() { MoveFactory.LeechLife, },
			[41] = new List<Move>() { MoveFactory.ZenHeadbutt, },
			[47] = new List<Move>() { MoveFactory.PoisonFang, },
			[55] = new List<Move>() { MoveFactory.Psychic, },
			[59] = new List<Move>() { MoveFactory.BugBuzz, },
			[63] = new List<Move>() { MoveFactory.QuiverDance, },
		};
	}
}

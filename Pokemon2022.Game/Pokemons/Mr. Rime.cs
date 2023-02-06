using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class MrRime : Pokemon
	{
		public override string Name => "Mr. Rime";
		public override int Generation => 8;
		public override string PokedexEntry => "Its amusing movements make it very popular. It releases its psychic power from the pattern on its belly.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Ice, PokemonType.Psychic };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.TangledFeet, AbilityFactory.ScreenCleaner, };
		public override Ability AvailableHiddenAbility => AbilityFactory.IceBody;
		public override Stats BaseStats => new Stats() {
			HP = 80,
			Attack = 85,
			Defense = 75,
			SpecialAttack = 110,
			SpecialDefense = 100,
			Speed = 70
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.FakeTears, MoveFactory.SlackOff, MoveFactory.AfterYou, MoveFactory.Block, MoveFactory.Copycat, MoveFactory.Encore, MoveFactory.RolePlay, MoveFactory.Protect, MoveFactory.Recycle, MoveFactory.Mimic, MoveFactory.LightScreen, MoveFactory.Reflect, MoveFactory.Safeguard, MoveFactory.DazzlingGleam, MoveFactory.MistyTerrain, MoveFactory.Pound, MoveFactory.RapidSpin, MoveFactory.BatonPass, MoveFactory.IceShard, },
			[12] = new List<Move>() { MoveFactory.Confusion, },
			[16] = new List<Move>() { MoveFactory.AllySwitch, },
			[20] = new List<Move>() { MoveFactory.IcyWind, },
			[24] = new List<Move>() { MoveFactory.DoubleKick, },
			[28] = new List<Move>() { MoveFactory.Psybeam, },
			[32] = new List<Move>() { MoveFactory.Hypnosis, },
			[36] = new List<Move>() { MoveFactory.MirrorCoat, },
			[40] = new List<Move>() { MoveFactory.SuckerPunch, },
			[44] = new List<Move>() { MoveFactory.FreezeDry, },
			[48] = new List<Move>() { MoveFactory.Psychic, },
			[52] = new List<Move>() { MoveFactory.TeeterDance, },
		};
	}
}

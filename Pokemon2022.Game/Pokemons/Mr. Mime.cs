using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class MrMime : Pokemon
	{
		public override string Name => "Mr. Mime";
		public override int Generation => 1;
		public override string PokedexEntry => "A Mr. Mime is a master of pantomime. It can convince others that something unseeable actually exists. Once believed, the imaginary object does become real.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Psychic, PokemonType.Fairy };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Soundproof, AbilityFactory.Filter, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Technician;
		public override Stats BaseStats => new Stats() {
			HP = 40,
			Attack = 45,
			Defense = 65,
			SpecialAttack = 100,
			SpecialDefense = 120,
			Speed = 90
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.QuickGuard, MoveFactory.WideGuard, MoveFactory.PowerSwap, MoveFactory.GuardSwap, MoveFactory.Pound, MoveFactory.Copycat, MoveFactory.BatonPass, MoveFactory.Encore, },
			[12] = new List<Move>() { MoveFactory.Confusion, },
			[16] = new List<Move>() { MoveFactory.RolePlay, },
			[20] = new List<Move>() { MoveFactory.Protect, },
			[24] = new List<Move>() { MoveFactory.Recycle, },
			[28] = new List<Move>() { MoveFactory.Psybeam, },
			[32] = new List<Move>() { MoveFactory.Mimic, },
			[36] = new List<Move>() { MoveFactory.LightScreen, MoveFactory.Reflect, MoveFactory.Safeguard, },
			[40] = new List<Move>() { MoveFactory.SuckerPunch, },
			[44] = new List<Move>() { MoveFactory.DazzlingGleam, },
			[48] = new List<Move>() { MoveFactory.Psychic, },
			[52] = new List<Move>() { MoveFactory.TeeterDance, },
		};
	}
}

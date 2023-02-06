using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class MimeJr : Pokemon
	{
		public override string Name => "Mime Jr.";
		public override int Generation => 4;
		public override string PokedexEntry => "It habitually mimics foes. Once mimicked, the foe cannot take its eyes off this Pokémon.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Psychic, PokemonType.Fairy };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Soundproof, AbilityFactory.Filter, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Technician;
		public override Stats BaseStats => new Stats() {
			HP = 20,
			Attack = 25,
			Defense = 45,
			SpecialAttack = 70,
			SpecialDefense = 90,
			Speed = 60
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Pound, MoveFactory.Copycat, },
			[4] = new List<Move>() { MoveFactory.BatonPass, },
			[8] = new List<Move>() { MoveFactory.Encore, },
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

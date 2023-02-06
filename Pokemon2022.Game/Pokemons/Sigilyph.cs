using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Sigilyph : Pokemon
	{
		public override string Name => "Sigilyph";
		public override int Generation => 5;
		public override string PokedexEntry => "The guardians of an ancient city, they use their psychic power to attack enemies that invade their territory.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Psychic, PokemonType.Flying };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.WonderSkin, AbilityFactory.MagicGuard, };
		public override Ability AvailableHiddenAbility => AbilityFactory.TintedLens;
		public override Stats BaseStats => new Stats() {
			HP = 72,
			Attack = 58,
			Defense = 80,
			SpecialAttack = 103,
			SpecialDefense = 80,
			Speed = 97
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Gust, MoveFactory.Confusion, },
			[5] = new List<Move>() { MoveFactory.Gravity, },
			[10] = new List<Move>() { MoveFactory.Hypnosis, },
			[15] = new List<Move>() { MoveFactory.AirCutter, },
			[20] = new List<Move>() { MoveFactory.Psybeam, },
			[25] = new List<Move>() { MoveFactory.Whirlwind, },
			[30] = new List<Move>() { MoveFactory.CosmicPower, },
			[35] = new List<Move>() { MoveFactory.AirSlash, },
			[40] = new List<Move>() { MoveFactory.Psychic, },
			[45] = new List<Move>() { MoveFactory.Tailwind, },
			[50] = new List<Move>() { MoveFactory.LightScreen, MoveFactory.Reflect, },
			[55] = new List<Move>() { MoveFactory.SkyAttack, },
			[60] = new List<Move>() { MoveFactory.SkillSwap, },
		};
	}
}

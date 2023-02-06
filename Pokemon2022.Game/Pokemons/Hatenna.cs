using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Hatenna : Pokemon
	{
		public override string Name => "Hatenna";
		public override int Generation => 8;
		public override string PokedexEntry => "Via the protrusion on its head, it senses other creatures' emotions. If you don't have a calm disposition, it will never warm up to you.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Psychic };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Healer, AbilityFactory.Anticipation, };
		public override Ability AvailableHiddenAbility => AbilityFactory.MagicBounce;
		public override Stats BaseStats => new Stats() {
			HP = 42,
			Attack = 30,
			Defense = 45,
			SpecialAttack = 56,
			SpecialDefense = 53,
			Speed = 39
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Confusion, MoveFactory.PlayNice, },
			[5] = new List<Move>() { MoveFactory.LifeDew, },
			[10] = new List<Move>() { MoveFactory.DisarmingVoice, },
			[15] = new List<Move>() { MoveFactory.Aromatherapy, },
			[20] = new List<Move>() { MoveFactory.Psybeam, },
			[25] = new List<Move>() { MoveFactory.HealPulse, },
			[30] = new List<Move>() { MoveFactory.DazzlingGleam, },
			[35] = new List<Move>() { MoveFactory.CalmMind, },
			[40] = new List<Move>() { MoveFactory.Psychic, },
			[45] = new List<Move>() { MoveFactory.HealingWish, },
		};
	}
}

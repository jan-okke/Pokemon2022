using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Hattrem : Pokemon
	{
		public override string Name => "Hattrem";
		public override int Generation => 8;
		public override string PokedexEntry => "Using the braids on its head, it pummels foes to get them to quiet down. One blow from those braids would knock out a professional boxer.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Psychic };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Healer, AbilityFactory.Anticipation, };
		public override Ability AvailableHiddenAbility => AbilityFactory.MagicBounce;
		public override Stats BaseStats => new Stats() {
			HP = 57,
			Attack = 40,
			Defense = 65,
			SpecialAttack = 86,
			SpecialDefense = 73,
			Speed = 49
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[0] = new List<Move>() { MoveFactory.BrutalSwing, },
			[1] = new List<Move>() { MoveFactory.BrutalSwing, MoveFactory.Confusion, MoveFactory.PlayNice, MoveFactory.LifeDew, MoveFactory.DisarmingVoice, },
			[15] = new List<Move>() { MoveFactory.Aromatherapy, },
			[20] = new List<Move>() { MoveFactory.Psybeam, },
			[25] = new List<Move>() { MoveFactory.HealPulse, },
			[30] = new List<Move>() { MoveFactory.DazzlingGleam, },
			[37] = new List<Move>() { MoveFactory.CalmMind, },
			[44] = new List<Move>() { MoveFactory.Psychic, },
			[51] = new List<Move>() { MoveFactory.HealingWish, },
		};
	}
}

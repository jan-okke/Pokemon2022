using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Hatterene : Pokemon
	{
		public override string Name => "Hatterene";
		public override int Generation => 8;
		public override string PokedexEntry => "It emits psychic power strong enough to cause headaches as a deterrent to the approach of others.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Psychic, PokemonType.Fairy };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Healer, AbilityFactory.Anticipation, };
		public override Ability AvailableHiddenAbility => AbilityFactory.MagicBounce;
		public override Stats BaseStats => new Stats() {
			HP = 57,
			Attack = 90,
			Defense = 95,
			SpecialAttack = 136,
			SpecialDefense = 103,
			Speed = 29
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[0] = new List<Move>() { MoveFactory.PsychoCut, },
			[1] = new List<Move>() { MoveFactory.PsychoCut, MoveFactory.BrutalSwing, MoveFactory.Confusion, MoveFactory.PlayNice, MoveFactory.LifeDew, MoveFactory.DisarmingVoice, },
			[15] = new List<Move>() { MoveFactory.Aromatherapy, },
			[20] = new List<Move>() { MoveFactory.Psybeam, },
			[25] = new List<Move>() { MoveFactory.HealPulse, },
			[30] = new List<Move>() { MoveFactory.DazzlingGleam, },
			[37] = new List<Move>() { MoveFactory.CalmMind, },
			[46] = new List<Move>() { MoveFactory.Psychic, },
			[55] = new List<Move>() { MoveFactory.HealingWish, },
			[64] = new List<Move>() { MoveFactory.MagicPowder, },
		};
	}
}

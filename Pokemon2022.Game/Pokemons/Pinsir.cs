using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Pinsir : Pokemon
	{
		public override string Name => "Pinsir";
		public override int Generation => 1;
		public override string PokedexEntry => "Their pincers are strong enough to shatter thick logs. Because they dislike cold, Pinsir burrow and sleep under the ground on chilly nights.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Bug };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.HyperCutter, AbilityFactory.MoldBreaker, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Moxie;
		public override Stats BaseStats => new Stats() {
			HP = 65,
			Attack = 125,
			Defense = 100,
			SpecialAttack = 55,
			SpecialDefense = 70,
			Speed = 85
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.ViseGrip, MoveFactory.Harden, },
			[4] = new List<Move>() { MoveFactory.FocusEnergy, },
			[8] = new List<Move>() { MoveFactory.Bind, },
			[12] = new List<Move>() { MoveFactory.SeismicToss, },
			[16] = new List<Move>() { MoveFactory.BugBite, },
			[20] = new List<Move>() { MoveFactory.StormThrow, },
			[24] = new List<Move>() { MoveFactory.DoubleHit, },
			[28] = new List<Move>() { MoveFactory.VitalThrow, },
			[32] = new List<Move>() { MoveFactory.XScissor, },
			[36] = new List<Move>() { MoveFactory.Strength, },
			[40] = new List<Move>() { MoveFactory.SwordsDance, },
			[44] = new List<Move>() { MoveFactory.Submission, },
			[48] = new List<Move>() { MoveFactory.Guillotine, },
			[52] = new List<Move>() { MoveFactory.Superpower, },
		};
	}
}

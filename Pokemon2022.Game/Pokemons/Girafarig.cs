using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Girafarig : Pokemon
	{
		public override string Name => "Girafarig";
		public override int Generation => 2;
		public override string PokedexEntry => "A Girafarig is an herbivore--it eats grass and tree shoots. While it is eating, its tail makes chewing and swallowing motions as if it were also eating.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Normal, PokemonType.Psychic };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.InnerFocus, AbilityFactory.EarlyBird, };
		public override Ability AvailableHiddenAbility => AbilityFactory.SapSipper;
		public override Stats BaseStats => new Stats() {
			HP = 70,
			Attack = 80,
			Defense = 65,
			SpecialAttack = 90,
			SpecialDefense = 65,
			Speed = 85
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.PowerSwap, MoveFactory.GuardSwap, MoveFactory.Astonish, MoveFactory.Tackle, MoveFactory.Growl, },
			[5] = new List<Move>() { MoveFactory.Confusion, },
			[10] = new List<Move>() { MoveFactory.Assurance, },
			[14] = new List<Move>() { MoveFactory.Stomp, },
			[19] = new List<Move>() { MoveFactory.Psybeam, },
			[23] = new List<Move>() { MoveFactory.Agility, },
			[28] = new List<Move>() { MoveFactory.DoubleHit, },
			[32] = new List<Move>() { MoveFactory.ZenHeadbutt, },
			[37] = new List<Move>() { MoveFactory.Crunch, },
			[41] = new List<Move>() { MoveFactory.BatonPass, },
			[46] = new List<Move>() { MoveFactory.NastyPlot, },
			[50] = new List<Move>() { MoveFactory.Psychic, },
		};
	}
}

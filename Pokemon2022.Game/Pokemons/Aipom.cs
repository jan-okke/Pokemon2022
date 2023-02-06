using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Aipom : Pokemon
	{
		public override string Name => "Aipom";
		public override int Generation => 2;
		public override string PokedexEntry => "Its tail ends with a dexterous, handlike appendage. However, because it uses the tail so much, Aipom's real hands have become rather clumsy.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Normal };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.RunAway, AbilityFactory.Pickup, };
		public override Ability AvailableHiddenAbility => AbilityFactory.SkillLink;
		public override Stats BaseStats => new Stats() {
			HP = 55,
			Attack = 70,
			Defense = 55,
			SpecialAttack = 40,
			SpecialDefense = 55,
			Speed = 85
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Scratch, MoveFactory.TailWhip, },
			[4] = new List<Move>() { MoveFactory.SandAttack, },
			[8] = new List<Move>() { MoveFactory.Astonish, },
			[11] = new List<Move>() { MoveFactory.BatonPass, },
			[15] = new List<Move>() { MoveFactory.Tickle, },
			[18] = new List<Move>() { MoveFactory.FurySwipes, },
			[22] = new List<Move>() { MoveFactory.Swift, },
			[25] = new List<Move>() { MoveFactory.Screech, },
			[29] = new List<Move>() { MoveFactory.Agility, },
			[32] = new List<Move>() { MoveFactory.DoubleHit, },
			[36] = new List<Move>() { MoveFactory.Fling, },
			[39] = new List<Move>() { MoveFactory.NastyPlot, },
			[43] = new List<Move>() { MoveFactory.LastResort, },
		};
	}
}

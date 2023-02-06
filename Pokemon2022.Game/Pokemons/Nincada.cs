using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Nincada : Pokemon
	{
		public override string Name => "Nincada";
		public override int Generation => 3;
		public override string PokedexEntry => "It makes its nest at the roots of a mighty tree. Using its whiskerlike antennae, it probes its surroundings in the pitch-black darkness of soil.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Bug, PokemonType.Ground };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.CompoundEyes, };
		public override Ability AvailableHiddenAbility => AbilityFactory.RunAway;
		public override Stats BaseStats => new Stats() {
			HP = 31,
			Attack = 45,
			Defense = 90,
			SpecialAttack = 30,
			SpecialDefense = 30,
			Speed = 40
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.SandAttack, MoveFactory.Scratch, },
			[5] = new List<Move>() { MoveFactory.Harden, },
			[10] = new List<Move>() { MoveFactory.FalseSwipe, },
			[15] = new List<Move>() { MoveFactory.MudSlap, },
			[21] = new List<Move>() { MoveFactory.Absorb, },
			[25] = new List<Move>() { MoveFactory.MetalClaw, },
			[30] = new List<Move>() { MoveFactory.FurySwipes, },
			[35] = new List<Move>() { MoveFactory.MindReader, },
			[40] = new List<Move>() { MoveFactory.Dig, },
		};
	}
}

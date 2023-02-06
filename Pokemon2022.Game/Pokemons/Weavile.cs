using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Weavile : Pokemon
	{
		public override string Name => "Weavile";
		public override int Generation => 4;
		public override string PokedexEntry => "They live in cold regions, forming groups of four or five that hunt prey with impressive coordination.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Dark, PokemonType.Ice };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Pressure, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Pickpocket;
		public override Stats BaseStats => new Stats() {
			HP = 70,
			Attack = 120,
			Defense = 65,
			SpecialAttack = 45,
			SpecialDefense = 85,
			Speed = 125
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Revenge, MoveFactory.Assurance, MoveFactory.QuickAttack, MoveFactory.BeatUp, MoveFactory.Agility, MoveFactory.Slash, MoveFactory.Scratch, MoveFactory.Leer, MoveFactory.Taunt, MoveFactory.IceShard, },
			[18] = new List<Move>() { MoveFactory.MetalClaw, },
			[24] = new List<Move>() { MoveFactory.IcyWind, },
			[30] = new List<Move>() { MoveFactory.FurySwipes, },
			[36] = new List<Move>() { MoveFactory.HoneClaws, },
			[42] = new List<Move>() { MoveFactory.Fling, },
			[48] = new List<Move>() { MoveFactory.NastyPlot, },
			[54] = new List<Move>() { MoveFactory.Screech, },
			[60] = new List<Move>() { MoveFactory.NightSlash, },
			[66] = new List<Move>() { MoveFactory.DarkPulse, },
		};
	}
}

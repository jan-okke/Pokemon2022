using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Cresselia : Pokemon
	{
		public override string Name => "Cresselia";
		public override int Generation => 4;
		public override string PokedexEntry => "Shiny particles are released from its wings like a veil. It is said to represent the crescent moon.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Psychic };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Levitate, };
		public override Stats BaseStats => new Stats() {
			HP = 120,
			Attack = 70,
			Defense = 120,
			SpecialAttack = 75,
			SpecialDefense = 130,
			Speed = 85
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Confusion, MoveFactory.DoubleTeam, },
			[6] = new List<Move>() { MoveFactory.Mist, },
			[12] = new List<Move>() { MoveFactory.AuroraBeam, },
			[18] = new List<Move>() { MoveFactory.Psybeam, },
			[24] = new List<Move>() { MoveFactory.PsychoShift, },
			[30] = new List<Move>() { MoveFactory.Slash, },
			[36] = new List<Move>() { MoveFactory.PsychoCut, },
			[42] = new List<Move>() { MoveFactory.Moonlight, },
			[48] = new List<Move>() { MoveFactory.Safeguard, },
			[54] = new List<Move>() { MoveFactory.Psychic, },
			[60] = new List<Move>() { MoveFactory.Moonblast, },
			[66] = new List<Move>() { MoveFactory.FutureSight, },
			[72] = new List<Move>() { MoveFactory.LunarDance, },
		};
	}
}

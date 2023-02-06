using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Joltik : Pokemon
	{
		public override string Name => "Joltik";
		public override int Generation => 5;
		public override string PokedexEntry => "They attach themselves to large-bodied Pokémon and absorb static electricity, which they store in an electric pouch.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Bug, PokemonType.Electric };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.CompoundEyes, AbilityFactory.Unnerve, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Swarm;
		public override Stats BaseStats => new Stats() {
			HP = 50,
			Attack = 47,
			Defense = 50,
			SpecialAttack = 57,
			SpecialDefense = 50,
			Speed = 65
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Absorb, MoveFactory.FuryCutter, },
			[4] = new List<Move>() { MoveFactory.Electroweb, },
			[8] = new List<Move>() { MoveFactory.BugBite, },
			[12] = new List<Move>() { MoveFactory.StringShot, },
			[16] = new List<Move>() { MoveFactory.ThunderWave, },
			[20] = new List<Move>() { MoveFactory.ElectroBall, },
			[24] = new List<Move>() { MoveFactory.Agility, },
			[28] = new List<Move>() { MoveFactory.SuckerPunch, },
			[32] = new List<Move>() { MoveFactory.Slash, },
			[37] = new List<Move>() { MoveFactory.Discharge, },
			[40] = new List<Move>() { MoveFactory.Screech, },
			[44] = new List<Move>() { MoveFactory.GastroAcid, },
			[48] = new List<Move>() { MoveFactory.BugBuzz, },
		};
	}
}

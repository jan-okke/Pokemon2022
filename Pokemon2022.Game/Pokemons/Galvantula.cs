using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Galvantula : Pokemon
	{
		public override string Name => "Galvantula";
		public override int Generation => 5;
		public override string PokedexEntry => "They employ an electrically charged web to trap their prey. While it is immobilized by shock, they leisurely consume it.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Bug, PokemonType.Electric };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.CompoundEyes, AbilityFactory.Unnerve, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Swarm;
		public override Stats BaseStats => new Stats() {
			HP = 70,
			Attack = 77,
			Defense = 60,
			SpecialAttack = 97,
			SpecialDefense = 60,
			Speed = 108
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[0] = new List<Move>() { MoveFactory.StickyWeb, },
			[1] = new List<Move>() { MoveFactory.StickyWeb, MoveFactory.Absorb, MoveFactory.FuryCutter, MoveFactory.Electroweb, MoveFactory.BugBite, },
			[12] = new List<Move>() { MoveFactory.StringShot, },
			[16] = new List<Move>() { MoveFactory.ThunderWave, },
			[20] = new List<Move>() { MoveFactory.ElectroBall, },
			[24] = new List<Move>() { MoveFactory.Agility, },
			[28] = new List<Move>() { MoveFactory.SuckerPunch, },
			[32] = new List<Move>() { MoveFactory.Slash, },
			[39] = new List<Move>() { MoveFactory.Discharge, },
			[44] = new List<Move>() { MoveFactory.Screech, },
			[50] = new List<Move>() { MoveFactory.GastroAcid, },
			[56] = new List<Move>() { MoveFactory.BugBuzz, },
		};
	}
}

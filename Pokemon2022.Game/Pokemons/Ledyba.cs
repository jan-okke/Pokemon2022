using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Ledyba : Pokemon
	{
		public override string Name => "Ledyba";
		public override int Generation => 2;
		public override string PokedexEntry => "Ledyba communicate using a fluid that they secrete from where the legs join the body. They are said to convey feelings to others by altering the fluid's scent.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Bug, PokemonType.Flying };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Swarm, AbilityFactory.EarlyBird, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Rattled;
		public override Stats BaseStats => new Stats() {
			HP = 40,
			Attack = 20,
			Defense = 30,
			SpecialAttack = 40,
			SpecialDefense = 80,
			Speed = 55
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Tackle, },
			[5] = new List<Move>() { MoveFactory.Supersonic, },
			[8] = new List<Move>() { MoveFactory.Swift, },
			[12] = new List<Move>() { MoveFactory.LightScreen, MoveFactory.Reflect, MoveFactory.Safeguard, },
			[15] = new List<Move>() { MoveFactory.MachPunch, },
			[19] = new List<Move>() { MoveFactory.Roost, },
			[22] = new List<Move>() { MoveFactory.StruggleBug, },
			[26] = new List<Move>() { MoveFactory.BatonPass, },
			[29] = new List<Move>() { MoveFactory.Agility, },
			[33] = new List<Move>() { MoveFactory.BugBuzz, },
			[36] = new List<Move>() { MoveFactory.AirSlash, },
			[40] = new List<Move>() { MoveFactory.DoubleEdge, },
		};
	}
}

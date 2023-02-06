using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Ledian : Pokemon
	{
		public override string Name => "Ledian";
		public override int Generation => 2;
		public override string PokedexEntry => "It is said that in lands with clean air, where the stars fill the sky, there live many Ledian. For good reason, they use the light of the stars as energy.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Bug, PokemonType.Flying };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Swarm, AbilityFactory.EarlyBird, };
		public override Ability AvailableHiddenAbility => AbilityFactory.IronFist;
		public override Stats BaseStats => new Stats() {
			HP = 55,
			Attack = 35,
			Defense = 50,
			SpecialAttack = 55,
			SpecialDefense = 110,
			Speed = 85
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Tackle, MoveFactory.Supersonic, MoveFactory.Swift, },
			[5] = new List<Move>() { MoveFactory.Supersonic, },
			[8] = new List<Move>() { MoveFactory.Swift, },
			[12] = new List<Move>() { MoveFactory.LightScreen, MoveFactory.Reflect, MoveFactory.Safeguard, },
			[15] = new List<Move>() { MoveFactory.MachPunch, },
			[20] = new List<Move>() { MoveFactory.Roost, },
			[24] = new List<Move>() { MoveFactory.StruggleBug, },
			[29] = new List<Move>() { MoveFactory.BatonPass, },
			[33] = new List<Move>() { MoveFactory.Agility, },
			[38] = new List<Move>() { MoveFactory.BugBuzz, },
			[42] = new List<Move>() { MoveFactory.AirSlash, },
			[47] = new List<Move>() { MoveFactory.DoubleEdge, },
		};
	}
}

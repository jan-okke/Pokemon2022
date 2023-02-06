using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Durant : Pokemon
	{
		public override string Name => "Durant";
		public override int Generation => 5;
		public override string PokedexEntry => "Durant dig nests in mountains. They build their complicated, interconnected tunnels in mazes.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Bug, PokemonType.Steel };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Swarm, AbilityFactory.Hustle, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Truant;
		public override Stats BaseStats => new Stats() {
			HP = 58,
			Attack = 109,
			Defense = 112,
			SpecialAttack = 48,
			SpecialDefense = 48,
			Speed = 109
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.FuryCutter, MoveFactory.SandAttack, },
			[4] = new List<Move>() { MoveFactory.ViseGrip, },
			[8] = new List<Move>() { MoveFactory.MetalClaw, },
			[12] = new List<Move>() { MoveFactory.BeatUp, },
			[16] = new List<Move>() { MoveFactory.BugBite, },
			[20] = new List<Move>() { MoveFactory.Bite, },
			[24] = new List<Move>() { MoveFactory.Agility, },
			[28] = new List<Move>() { MoveFactory.Dig, },
			[32] = new List<Move>() { MoveFactory.XScissor, },
			[36] = new List<Move>() { MoveFactory.Crunch, },
			[40] = new List<Move>() { MoveFactory.MetalSound, },
			[44] = new List<Move>() { MoveFactory.IronHead, },
			[48] = new List<Move>() { MoveFactory.Entrainment, },
			[52] = new List<Move>() { MoveFactory.IronDefense, },
			[56] = new List<Move>() { MoveFactory.Guillotine, },
		};
	}
}

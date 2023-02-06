using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Escavalier : Pokemon
	{
		public override string Name => "Escavalier";
		public override int Generation => 5;
		public override string PokedexEntry => "These Pokémon evolve by wearing the shell covering of a Shelmet. The steel armor protects their whole body.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Bug, PokemonType.Steel };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Swarm, AbilityFactory.ShellArmor, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Overcoat;
		public override Stats BaseStats => new Stats() {
			HP = 70,
			Attack = 135,
			Defense = 105,
			SpecialAttack = 60,
			SpecialDefense = 105,
			Speed = 20
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.FellStinger, MoveFactory.Endure, MoveFactory.Flail, MoveFactory.ScaryFace, MoveFactory.TakeDown, MoveFactory.DoubleEdge, MoveFactory.Peck, MoveFactory.Leer, MoveFactory.FuryCutter, MoveFactory.QuickGuard, },
			[12] = new List<Move>() { MoveFactory.FalseSwipe, },
			[16] = new List<Move>() { MoveFactory.AcidSpray, },
			[20] = new List<Move>() { MoveFactory.Headbutt, },
			[24] = new List<Move>() { MoveFactory.Reversal, },
			[28] = new List<Move>() { MoveFactory.IronDefense, },
			[32] = new List<Move>() { MoveFactory.XScissor, },
			[36] = new List<Move>() { MoveFactory.SwordsDance, },
			[40] = new List<Move>() { MoveFactory.IronHead, },
			[44] = new List<Move>() { MoveFactory.BugBuzz, },
			[48] = new List<Move>() { MoveFactory.GigaImpact, },
			[52] = new List<Move>() { MoveFactory.MetalBurst, },
		};
	}
}

using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Kabuto : Pokemon
	{
		public override string Name => "Kabuto";
		public override int Generation => 1;
		public override string PokedexEntry => "This Pokémon has been regenerated from a fossil. However, in rare cases, living examples have been discovered. Kabuto have not changed for 300 million years.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Rock, PokemonType.Water };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.SwiftSwim, AbilityFactory.BattleArmor, };
		public override Ability AvailableHiddenAbility => AbilityFactory.WeakArmor;
		public override Stats BaseStats => new Stats() {
			HP = 30,
			Attack = 80,
			Defense = 90,
			SpecialAttack = 55,
			SpecialDefense = 45,
			Speed = 55
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Absorb, MoveFactory.Harden, },
			[5] = new List<Move>() { MoveFactory.Scratch, },
			[10] = new List<Move>() { MoveFactory.SandAttack, },
			[15] = new List<Move>() { MoveFactory.AquaJet, },
			[20] = new List<Move>() { MoveFactory.Leer, },
			[25] = new List<Move>() { MoveFactory.MudShot, },
			[30] = new List<Move>() { MoveFactory.AncientPower, },
			[35] = new List<Move>() { MoveFactory.Brine, },
			[41] = new List<Move>() { MoveFactory.Protect, },
			[45] = new List<Move>() { MoveFactory.LeechLife, },
			[50] = new List<Move>() { MoveFactory.Liquidation, },
			[55] = new List<Move>() { MoveFactory.MetalSound, },
			[60] = new List<Move>() { MoveFactory.StoneEdge, },
		};
	}
}

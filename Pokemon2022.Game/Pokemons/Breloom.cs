using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Breloom : Pokemon
	{
		public override string Name => "Breloom";
		public override int Generation => 3;
		public override string PokedexEntry => "It scatters spores from holes in the cap on its head. It loves warm and humid climates. It feeds on trees and plants in fields and forests.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Grass, PokemonType.Fighting };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.EffectSpore, AbilityFactory.PoisonHeal, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Technician;
		public override Stats BaseStats => new Stats() {
			HP = 60,
			Attack = 130,
			Defense = 80,
			SpecialAttack = 60,
			SpecialDefense = 60,
			Speed = 70
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[0] = new List<Move>() { MoveFactory.MachPunch, },
			[1] = new List<Move>() { MoveFactory.MachPunch, MoveFactory.Absorb, MoveFactory.Tackle, MoveFactory.StunSpore, MoveFactory.LeechSeed, },
			[5] = new List<Move>() { MoveFactory.StunSpore, },
			[8] = new List<Move>() { MoveFactory.LeechSeed, },
			[12] = new List<Move>() { MoveFactory.MegaDrain, },
			[15] = new List<Move>() { MoveFactory.Headbutt, },
			[19] = new List<Move>() { MoveFactory.Feint, },
			[22] = new List<Move>() { MoveFactory.Counter, },
			[28] = new List<Move>() { MoveFactory.ForcePalm, },
			[33] = new List<Move>() { MoveFactory.MindReader, },
			[39] = new List<Move>() { MoveFactory.DrainPunch, },
			[44] = new List<Move>() { MoveFactory.SeedBomb, },
			[50] = new List<Move>() { MoveFactory.DynamicPunch, },
		};
	}
}

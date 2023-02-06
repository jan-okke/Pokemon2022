using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Anorith : Pokemon
	{
		public override string Name => "Anorith";
		public override int Generation => 3;
		public override string PokedexEntry => "It was resurrected from a fossil using the power of science. It swims by undulating the wings at its sides. They were feet that adapted to life in the sea.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Rock, PokemonType.Bug };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.BattleArmor, };
		public override Ability AvailableHiddenAbility => AbilityFactory.SwiftSwim;
		public override Stats BaseStats => new Stats() {
			HP = 45,
			Attack = 95,
			Defense = 50,
			SpecialAttack = 40,
			SpecialDefense = 50,
			Speed = 75
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.FuryCutter, MoveFactory.Harden, },
			[4] = new List<Move>() { MoveFactory.WaterGun, },
			[8] = new List<Move>() { MoveFactory.SmackDown, },
			[12] = new List<Move>() { MoveFactory.MetalClaw, },
			[16] = new List<Move>() { MoveFactory.AncientPower, },
			[20] = new List<Move>() { MoveFactory.BugBite, },
			[24] = new List<Move>() { MoveFactory.Brine, },
			[28] = new List<Move>() { MoveFactory.Slash, },
			[32] = new List<Move>() { MoveFactory.CrushClaw, },
			[36] = new List<Move>() { MoveFactory.RockBlast, },
			[41] = new List<Move>() { MoveFactory.Protect, },
			[44] = new List<Move>() { MoveFactory.XScissor, },
		};
	}
}

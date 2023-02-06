using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Armaldo : Pokemon
	{
		public override string Name => "Armaldo";
		public override int Generation => 3;
		public override string PokedexEntry => "Armaldo usually lives on land. However, when it hunts for prey, it dives beneath the ocean. It swims around using its two large wings.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Rock, PokemonType.Bug };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.BattleArmor, };
		public override Ability AvailableHiddenAbility => AbilityFactory.SwiftSwim;
		public override Stats BaseStats => new Stats() {
			HP = 75,
			Attack = 125,
			Defense = 100,
			SpecialAttack = 70,
			SpecialDefense = 80,
			Speed = 45
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.FuryCutter, MoveFactory.Harden, MoveFactory.WaterGun, MoveFactory.SmackDown, },
			[12] = new List<Move>() { MoveFactory.MetalClaw, },
			[16] = new List<Move>() { MoveFactory.AncientPower, },
			[20] = new List<Move>() { MoveFactory.BugBite, },
			[24] = new List<Move>() { MoveFactory.Brine, },
			[28] = new List<Move>() { MoveFactory.Slash, },
			[32] = new List<Move>() { MoveFactory.CrushClaw, },
			[36] = new List<Move>() { MoveFactory.RockBlast, },
			[43] = new List<Move>() { MoveFactory.Protect, },
			[48] = new List<Move>() { MoveFactory.XScissor, },
		};
	}
}

using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Ferrothorn : Pokemon
	{
		public override string Name => "Ferrothorn";
		public override int Generation => 5;
		public override string PokedexEntry => "They attach themselves to cave ceilings, firing steel spikes at targets passing beneath them.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Grass, PokemonType.Steel };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.IronBarbs, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Anticipation;
		public override Stats BaseStats => new Stats() {
			HP = 74,
			Attack = 94,
			Defense = 131,
			SpecialAttack = 54,
			SpecialDefense = 116,
			Speed = 20
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[0] = new List<Move>() { MoveFactory.PowerWhip, },
			[1] = new List<Move>() { MoveFactory.PowerWhip, MoveFactory.Tackle, MoveFactory.Harden, MoveFactory.MetalClaw, MoveFactory.PinMissile, },
			[15] = new List<Move>() { MoveFactory.Ingrain, },
			[20] = new List<Move>() { MoveFactory.FlashCannon, },
			[25] = new List<Move>() { MoveFactory.IronHead, },
			[30] = new List<Move>() { MoveFactory.SelfDestruct, },
			[35] = new List<Move>() { MoveFactory.IronDefense, },
			[43] = new List<Move>() { MoveFactory.Curse, },
			[49] = new List<Move>() { MoveFactory.GyroBall, },
			[56] = new List<Move>() { MoveFactory.Explosion, },
		};
	}
}

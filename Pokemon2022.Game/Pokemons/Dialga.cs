using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Dialga : Pokemon
	{
		public override string Name => "Dialga";
		public override int Generation => 4;
		public override string PokedexEntry => "It has the power to control time. It appears in Sinnoh-region myths as an ancient deity.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Steel, PokemonType.Dragon };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Pressure, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Telepathy;
		public override Stats BaseStats => new Stats() {
			HP = 100,
			Attack = 120,
			Defense = 120,
			SpecialAttack = 150,
			SpecialDefense = 100,
			Speed = 90
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.ScaryFace, MoveFactory.MetalClaw, },
			[8] = new List<Move>() { MoveFactory.DragonBreath, },
			[16] = new List<Move>() { MoveFactory.AncientPower, },
			[24] = new List<Move>() { MoveFactory.Slash, },
			[32] = new List<Move>() { MoveFactory.FlashCannon, },
			[40] = new List<Move>() { MoveFactory.RoarofTime, },
			[48] = new List<Move>() { MoveFactory.DragonClaw, },
			[56] = new List<Move>() { MoveFactory.AuraSphere, },
			[64] = new List<Move>() { MoveFactory.PowerGem, },
			[72] = new List<Move>() { MoveFactory.MetalBurst, },
			[80] = new List<Move>() { MoveFactory.EarthPower, },
			[88] = new List<Move>() { MoveFactory.IronTail, },
		};
	}
}

using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Solgaleo : Pokemon
	{
		public override string Name => "Solgaleo";
		public override int Generation => 7;
		public override string PokedexEntry => "It is said to live in another world. The intense light it radiates from the surface of its body can make the darkest of nights light up like midday.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Psychic, PokemonType.Steel };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.FullMetalBody, };
		public override Stats BaseStats => new Stats() {
			HP = 137,
			Attack = 137,
			Defense = 107,
			SpecialAttack = 113,
			SpecialDefense = 89,
			Speed = 97
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[0] = new List<Move>() { MoveFactory.SunsteelStrike, },
			[1] = new List<Move>() { MoveFactory.SunsteelStrike, MoveFactory.CosmicPower, MoveFactory.Teleport, MoveFactory.MetalClaw, MoveFactory.NobleRoar, },
			[7] = new List<Move>() { MoveFactory.IronHead, },
			[14] = new List<Move>() { MoveFactory.MetalSound, },
			[21] = new List<Move>() { MoveFactory.ZenHeadbutt, },
			[28] = new List<Move>() { MoveFactory.FlashCannon, },
			[35] = new List<Move>() { MoveFactory.MorningSun, },
			[42] = new List<Move>() { MoveFactory.Crunch, },
			[49] = new List<Move>() { MoveFactory.MetalBurst, },
			[56] = new List<Move>() { MoveFactory.WildCharge, },
			[63] = new List<Move>() { MoveFactory.SolarBeam, },
			[70] = new List<Move>() { MoveFactory.FlareBlitz, },
			[77] = new List<Move>() { MoveFactory.WideGuard, },
			[84] = new List<Move>() { MoveFactory.GigaImpact, },
		};
	}
}

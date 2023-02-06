using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Duraludon : Pokemon
	{
		public override string Name => "Duraludon";
		public override int Generation => 8;
		public override string PokedexEntry => "Its body resembles polished metal, and it's both lightweight and strong. The only drawback is that it rusts easily.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Steel, PokemonType.Dragon };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.LightMetal, AbilityFactory.HeavyMetal, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Stalwart;
		public override Stats BaseStats => new Stats() {
			HP = 70,
			Attack = 95,
			Defense = 115,
			SpecialAttack = 120,
			SpecialDefense = 50,
			Speed = 85
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.MetalClaw, MoveFactory.Leer, },
			[6] = new List<Move>() { MoveFactory.RockSmash, },
			[12] = new List<Move>() { MoveFactory.HoneClaws, },
			[18] = new List<Move>() { MoveFactory.MetalSound, },
			[24] = new List<Move>() { MoveFactory.BreakingSwipe, },
			[30] = new List<Move>() { MoveFactory.DragonTail, },
			[36] = new List<Move>() { MoveFactory.IronDefense, },
			[42] = new List<Move>() { MoveFactory.LaserFocus, },
			[48] = new List<Move>() { MoveFactory.DragonClaw, },
			[54] = new List<Move>() { MoveFactory.FlashCannon, },
			[60] = new List<Move>() { MoveFactory.MetalBurst, },
			[66] = new List<Move>() { MoveFactory.HyperBeam, },
		};
	}
}

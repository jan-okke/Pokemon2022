using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Palkia : Pokemon
	{
		public override string Name => "Palkia";
		public override int Generation => 4;
		public override string PokedexEntry => "It has the ability to distort space. It is described as a deity in Sinnoh-region mythology.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Water, PokemonType.Dragon };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Pressure, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Telepathy;
		public override Stats BaseStats => new Stats() {
			HP = 90,
			Attack = 120,
			Defense = 100,
			SpecialAttack = 150,
			SpecialDefense = 120,
			Speed = 100
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.ScaryFace, MoveFactory.WaterPulse, },
			[8] = new List<Move>() { MoveFactory.DragonBreath, },
			[16] = new List<Move>() { MoveFactory.AncientPower, },
			[24] = new List<Move>() { MoveFactory.Slash, },
			[32] = new List<Move>() { MoveFactory.AquaRing, },
			[40] = new List<Move>() { MoveFactory.SpacialRend, },
			[48] = new List<Move>() { MoveFactory.DragonClaw, },
			[56] = new List<Move>() { MoveFactory.AuraSphere, },
			[64] = new List<Move>() { MoveFactory.PowerGem, },
			[72] = new List<Move>() { MoveFactory.AquaTail, },
			[80] = new List<Move>() { MoveFactory.EarthPower, },
			[88] = new List<Move>() { MoveFactory.HydroPump, },
		};
	}
}

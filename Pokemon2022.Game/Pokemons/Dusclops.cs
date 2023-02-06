using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Dusclops : Pokemon
	{
		public override string Name => "Dusclops";
		public override int Generation => 3;
		public override string PokedexEntry => "It is thought that its body is hollow with only a spectral ball of fire burning inside. However, no one has been able to confirm this theory as fact.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Ghost };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Pressure, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Frisk;
		public override Stats BaseStats => new Stats() {
			HP = 40,
			Attack = 70,
			Defense = 130,
			SpecialAttack = 60,
			SpecialDefense = 130,
			Speed = 25
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[0] = new List<Move>() { MoveFactory.ShadowPunch, },
			[1] = new List<Move>() { MoveFactory.ShadowPunch, MoveFactory.FirePunch, MoveFactory.IcePunch, MoveFactory.ThunderPunch, MoveFactory.Gravity, MoveFactory.Bind, MoveFactory.Astonish, MoveFactory.Leer, MoveFactory.Disable, MoveFactory.ShadowSneak, },
			[12] = new List<Move>() { MoveFactory.ConfuseRay, },
			[16] = new List<Move>() { MoveFactory.NightShade, },
			[20] = new List<Move>() { MoveFactory.Payback, },
			[24] = new List<Move>() { MoveFactory.WillOWisp, },
			[28] = new List<Move>() { MoveFactory.MeanLook, },
			[32] = new List<Move>() { MoveFactory.Hex, },
			[36] = new List<Move>() { MoveFactory.Curse, },
			[42] = new List<Move>() { MoveFactory.ShadowBall, },
			[48] = new List<Move>() { MoveFactory.FutureSight, },
		};
	}
}

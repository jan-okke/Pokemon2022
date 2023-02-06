using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Dusknoir : Pokemon
	{
		public override string Name => "Dusknoir";
		public override int Generation => 4;
		public override string PokedexEntry => "The antenna on its head captures radio waves from the world of spirits that command it to take people there.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Ghost };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Pressure, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Frisk;
		public override Stats BaseStats => new Stats() {
			HP = 45,
			Attack = 100,
			Defense = 135,
			SpecialAttack = 65,
			SpecialDefense = 135,
			Speed = 45
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
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
			[54] = new List<Move>() { MoveFactory.DestinyBond, },
		};
	}
}

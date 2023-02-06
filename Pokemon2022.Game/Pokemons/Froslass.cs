using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Froslass : Pokemon
	{
		public override string Name => "Froslass";
		public override int Generation => 4;
		public override string PokedexEntry => "It freezes foes with an icy breath nearly -60 degrees F. What seems to be its body is actually hollow.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Ice, PokemonType.Ghost };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.SnowCloak, };
		public override Ability AvailableHiddenAbility => AbilityFactory.CursedBody;
		public override Stats BaseStats => new Stats() {
			HP = 70,
			Attack = 80,
			Defense = 70,
			SpecialAttack = 80,
			SpecialDefense = 70,
			Speed = 110
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[0] = new List<Move>() { MoveFactory.Hex, },
			[1] = new List<Move>() { MoveFactory.Hex, MoveFactory.DestinyBond, MoveFactory.Protect, MoveFactory.Bite, MoveFactory.IceFang, MoveFactory.Headbutt, MoveFactory.Crunch, MoveFactory.PowderSnow, MoveFactory.Astonish, MoveFactory.Leer, MoveFactory.DoubleTeam, },
			[15] = new List<Move>() { MoveFactory.IceShard, },
			[20] = new List<Move>() { MoveFactory.DrainingKiss, },
			[25] = new List<Move>() { MoveFactory.IcyWind, },
			[30] = new List<Move>() { MoveFactory.FrostBreath, },
			[35] = new List<Move>() { MoveFactory.ConfuseRay, },
			[40] = new List<Move>() { MoveFactory.Hail, },
			[47] = new List<Move>() { MoveFactory.WillOWisp, },
			[54] = new List<Move>() { MoveFactory.AuroraVeil, },
			[61] = new List<Move>() { MoveFactory.ShadowBall, },
			[68] = new List<Move>() { MoveFactory.Blizzard, },
		};
	}
}

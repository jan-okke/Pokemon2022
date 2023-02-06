using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Regice : Pokemon
	{
		public override string Name => "Regice";
		public override int Generation => 3;
		public override string PokedexEntry => "Its entire body is made of Antarctic ice. After extensive studies, researchers believe the ice was formed during an ice age.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Ice };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.ClearBody, };
		public override Ability AvailableHiddenAbility => AbilityFactory.IceBody;
		public override Stats BaseStats => new Stats() {
			HP = 80,
			Attack = 50,
			Defense = 100,
			SpecialAttack = 100,
			SpecialDefense = 200,
			Speed = 50
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.ChargeBeam, MoveFactory.IcyWind, },
			[6] = new List<Move>() { MoveFactory.Bulldoze, },
			[12] = new List<Move>() { MoveFactory.AncientPower, },
			[18] = new List<Move>() { MoveFactory.Stomp, },
			[24] = new List<Move>() { MoveFactory.IceBeam, },
			[30] = new List<Move>() { MoveFactory.Curse, },
			[36] = new List<Move>() { MoveFactory.Amnesia, },
			[42] = new List<Move>() { MoveFactory.HammerArm, },
			[48] = new List<Move>() { MoveFactory.Blizzard, },
			[54] = new List<Move>() { MoveFactory.Superpower, },
			[60] = new List<Move>() { MoveFactory.LockOn, },
			[66] = new List<Move>() { MoveFactory.ZapCannon, },
			[72] = new List<Move>() { MoveFactory.HyperBeam, },
			[78] = new List<Move>() { MoveFactory.Explosion, },
		};
	}
}

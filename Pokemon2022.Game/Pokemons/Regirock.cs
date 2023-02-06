using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Regirock : Pokemon
	{
		public override string Name => "Regirock";
		public override int Generation => 3;
		public override string PokedexEntry => "A Pokémon that is made entirely of rocks and boulders. If parts of its body chip off in battle, Regirock repairs itself by adding new rocks.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Rock };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.ClearBody, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Sturdy;
		public override Stats BaseStats => new Stats() {
			HP = 80,
			Attack = 100,
			Defense = 200,
			SpecialAttack = 50,
			SpecialDefense = 100,
			Speed = 50
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.ChargeBeam, MoveFactory.RockThrow, },
			[6] = new List<Move>() { MoveFactory.Bulldoze, },
			[12] = new List<Move>() { MoveFactory.AncientPower, },
			[18] = new List<Move>() { MoveFactory.Stomp, },
			[24] = new List<Move>() { MoveFactory.RockSlide, },
			[30] = new List<Move>() { MoveFactory.Curse, },
			[36] = new List<Move>() { MoveFactory.IronDefense, },
			[42] = new List<Move>() { MoveFactory.HammerArm, },
			[48] = new List<Move>() { MoveFactory.StoneEdge, },
			[54] = new List<Move>() { MoveFactory.Superpower, },
			[60] = new List<Move>() { MoveFactory.LockOn, },
			[66] = new List<Move>() { MoveFactory.ZapCannon, },
			[72] = new List<Move>() { MoveFactory.HyperBeam, },
			[78] = new List<Move>() { MoveFactory.Explosion, },
		};
	}
}

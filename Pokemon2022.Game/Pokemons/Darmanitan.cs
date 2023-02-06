using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Darmanitan : Pokemon
	{
		public override string Name => "Darmanitan";
		public override int Generation => 5;
		public override string PokedexEntry => "When weakened in battle, it transforms into a stone statue. Then it sharpens its mind and fights on mentally.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Fire };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.SheerForce, };
		public override Ability AvailableHiddenAbility => AbilityFactory.ZenMode;
		public override Stats BaseStats => new Stats() {
			HP = 105,
			Attack = 140,
			Defense = 55,
			SpecialAttack = 30,
			SpecialDefense = 55,
			Speed = 95
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[0] = new List<Move>() { MoveFactory.HammerArm, },
			[1] = new List<Move>() { MoveFactory.HammerArm, MoveFactory.Ember, MoveFactory.Tackle, MoveFactory.Taunt, MoveFactory.Bite, },
			[12] = new List<Move>() { MoveFactory.Incinerate, },
			[16] = new List<Move>() { MoveFactory.WorkUp, },
			[20] = new List<Move>() { MoveFactory.FireFang, },
			[24] = new List<Move>() { MoveFactory.Headbutt, },
			[28] = new List<Move>() { MoveFactory.FirePunch, },
			[32] = new List<Move>() { MoveFactory.Uproar, },
			[38] = new List<Move>() { MoveFactory.BellyDrum, },
			[44] = new List<Move>() { MoveFactory.FlareBlitz, },
			[50] = new List<Move>() { MoveFactory.Thrash, },
			[56] = new List<Move>() { MoveFactory.Superpower, },
		};
	}
}

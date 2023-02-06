using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Flapple : Pokemon
	{
		public override string Name => "Flapple";
		public override int Generation => 8;
		public override string PokedexEntry => "It ate a sour apple, and that induced its evolution. In its cheeks, it stores an acid capable of causing chemical burns.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Grass, PokemonType.Dragon };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Ripen, AbilityFactory.Gluttony, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Hustle;
		public override Stats BaseStats => new Stats() {
			HP = 70,
			Attack = 110,
			Defense = 80,
			SpecialAttack = 95,
			SpecialDefense = 60,
			Speed = 70
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[0] = new List<Move>() { MoveFactory.WingAttack, },
			[1] = new List<Move>() { MoveFactory.WingAttack, MoveFactory.Recycle, MoveFactory.Withdraw, MoveFactory.Astonish, MoveFactory.Growth, MoveFactory.Twister, },
			[4] = new List<Move>() { MoveFactory.AcidSpray, },
			[8] = new List<Move>() { MoveFactory.Acrobatics, },
			[12] = new List<Move>() { MoveFactory.LeechSeed, },
			[16] = new List<Move>() { MoveFactory.Protect, },
			[20] = new List<Move>() { MoveFactory.DragonBreath, },
			[24] = new List<Move>() { MoveFactory.DragonDance, },
			[28] = new List<Move>() { MoveFactory.DragonPulse, },
			[32] = new List<Move>() { MoveFactory.GravApple, },
			[36] = new List<Move>() { MoveFactory.IronDefense, },
			[40] = new List<Move>() { MoveFactory.Fly, },
			[44] = new List<Move>() { MoveFactory.DragonRush, },
		};
	}
}

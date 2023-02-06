using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Crustle : Pokemon
	{
		public override string Name => "Crustle";
		public override int Generation => 5;
		public override string PokedexEntry => "It possesses legs of enormous strength, enabling it to carry heavy slabs for many days, even when crossing arid land.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Bug, PokemonType.Rock };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Sturdy, AbilityFactory.ShellArmor, };
		public override Ability AvailableHiddenAbility => AbilityFactory.WeakArmor;
		public override Stats BaseStats => new Stats() {
			HP = 70,
			Attack = 105,
			Defense = 125,
			SpecialAttack = 65,
			SpecialDefense = 75,
			Speed = 45
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.FuryCutter, MoveFactory.SandAttack, MoveFactory.Withdraw, MoveFactory.SmackDown, },
			[12] = new List<Move>() { MoveFactory.BugBite, },
			[16] = new List<Move>() { MoveFactory.Flail, },
			[20] = new List<Move>() { MoveFactory.Slash, },
			[24] = new List<Move>() { MoveFactory.RockSlide, },
			[28] = new List<Move>() { MoveFactory.StealthRock, },
			[32] = new List<Move>() { MoveFactory.RockBlast, },
			[38] = new List<Move>() { MoveFactory.XScissor, },
			[44] = new List<Move>() { MoveFactory.RockPolish, },
			[50] = new List<Move>() { MoveFactory.ShellSmash, },
			[56] = new List<Move>() { MoveFactory.RockWrecker, },
		};
	}
}

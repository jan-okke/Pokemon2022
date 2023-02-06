using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Dwebble : Pokemon
	{
		public override string Name => "Dwebble";
		public override int Generation => 5;
		public override string PokedexEntry => "It makes a hole in a suitable rock. If that rock breaks, the Pokémon remains agitated until it locates a replacement.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Bug, PokemonType.Rock };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Sturdy, AbilityFactory.ShellArmor, };
		public override Ability AvailableHiddenAbility => AbilityFactory.WeakArmor;
		public override Stats BaseStats => new Stats() {
			HP = 50,
			Attack = 65,
			Defense = 85,
			SpecialAttack = 35,
			SpecialDefense = 35,
			Speed = 55
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.FuryCutter, MoveFactory.SandAttack, },
			[4] = new List<Move>() { MoveFactory.Withdraw, },
			[8] = new List<Move>() { MoveFactory.SmackDown, },
			[12] = new List<Move>() { MoveFactory.BugBite, },
			[16] = new List<Move>() { MoveFactory.Flail, },
			[20] = new List<Move>() { MoveFactory.Slash, },
			[24] = new List<Move>() { MoveFactory.RockSlide, },
			[28] = new List<Move>() { MoveFactory.StealthRock, },
			[32] = new List<Move>() { MoveFactory.RockBlast, },
			[36] = new List<Move>() { MoveFactory.XScissor, },
			[40] = new List<Move>() { MoveFactory.RockPolish, },
			[44] = new List<Move>() { MoveFactory.ShellSmash, },
			[48] = new List<Move>() { MoveFactory.RockWrecker, },
		};
	}
}

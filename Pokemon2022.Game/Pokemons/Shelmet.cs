using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Shelmet : Pokemon
	{
		public override string Name => "Shelmet";
		public override int Generation => 5;
		public override string PokedexEntry => "It evolves when bathed in an electric-like energy along with Karrablast. The reason is still unknown.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Bug };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.Hydration, AbilityFactory.ShellArmor, };
		public override Ability AvailableHiddenAbility => AbilityFactory.Overcoat;
		public override Stats BaseStats => new Stats() {
			HP = 50,
			Attack = 40,
			Defense = 85,
			SpecialAttack = 40,
			SpecialDefense = 65,
			Speed = 25
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Absorb, MoveFactory.Protect, },
			[4] = new List<Move>() { MoveFactory.Acid, },
			[8] = new List<Move>() { MoveFactory.Curse, },
			[12] = new List<Move>() { MoveFactory.MegaDrain, },
			[16] = new List<Move>() { MoveFactory.StruggleBug, },
			[20] = new List<Move>() { MoveFactory.Yawn, },
			[24] = new List<Move>() { MoveFactory.AcidArmor, },
			[28] = new List<Move>() { MoveFactory.GigaDrain, },
			[32] = new List<Move>() { MoveFactory.GuardSwap, },
			[36] = new List<Move>() { MoveFactory.BodySlam, },
			[40] = new List<Move>() { MoveFactory.Recover, },
			[44] = new List<Move>() { MoveFactory.BugBuzz, },
			[48] = new List<Move>() { MoveFactory.FinalGambit, },
		};
	}
}

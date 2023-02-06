using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Omastar : Pokemon
	{
		public override string Name => "Omastar";
		public override int Generation => 1;
		public override string PokedexEntry => "An Omastar uses its tentacles to capture its prey. It is believed to have become extinct because its shell grew too large, making its movements slow and ponderous.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Rock, PokemonType.Water };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.SwiftSwim, AbilityFactory.ShellArmor, };
		public override Ability AvailableHiddenAbility => AbilityFactory.WeakArmor;
		public override Stats BaseStats => new Stats() {
			HP = 70,
			Attack = 60,
			Defense = 125,
			SpecialAttack = 115,
			SpecialDefense = 70,
			Speed = 55
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[0] = new List<Move>() { MoveFactory.Crunch, },
			[1] = new List<Move>() { MoveFactory.Crunch, MoveFactory.Bind, MoveFactory.Withdraw, MoveFactory.Rollout, MoveFactory.SandAttack, },
			[15] = new List<Move>() { MoveFactory.WaterGun, },
			[20] = new List<Move>() { MoveFactory.Leer, },
			[25] = new List<Move>() { MoveFactory.MudShot, },
			[30] = new List<Move>() { MoveFactory.AncientPower, },
			[35] = new List<Move>() { MoveFactory.Brine, },
			[43] = new List<Move>() { MoveFactory.Protect, },
			[49] = new List<Move>() { MoveFactory.RockBlast, },
			[56] = new List<Move>() { MoveFactory.Surf, },
			[63] = new List<Move>() { MoveFactory.ShellSmash, },
			[70] = new List<Move>() { MoveFactory.HydroPump, },
		};
	}
}

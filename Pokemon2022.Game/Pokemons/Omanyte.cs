using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System.Collections.Generic;

namespace Pokemon2022.Game.Pokemons
{
	public class Omanyte : Pokemon
	{
		public override string Name => "Omanyte";
		public override int Generation => 1;
		public override string PokedexEntry => "One of the ancient and long-since-extinct Pokémon that have been regenerated from fossils by humans. If attacked, it withdraws into its hard shell.";
		public override PokemonType[] Types => new PokemonType[] {PokemonType.Rock, PokemonType.Water };
		public override List<Ability> AvailableAbilities => new List<Ability>() { AbilityFactory.SwiftSwim, AbilityFactory.ShellArmor, };
		public override Ability AvailableHiddenAbility => AbilityFactory.WeakArmor;
		public override Stats BaseStats => new Stats() {
			HP = 35,
			Attack = 40,
			Defense = 100,
			SpecialAttack = 90,
			SpecialDefense = 55,
			Speed = 35
		};
		public override Dictionary<int, List<Move>> LevelUpLearnset => new Dictionary<int, List<Move>>()
		{
			[1] = new List<Move>() { MoveFactory.Bind, MoveFactory.Withdraw, },
			[5] = new List<Move>() { MoveFactory.Rollout, },
			[10] = new List<Move>() { MoveFactory.SandAttack, },
			[15] = new List<Move>() { MoveFactory.WaterGun, },
			[20] = new List<Move>() { MoveFactory.Leer, },
			[25] = new List<Move>() { MoveFactory.MudShot, },
			[30] = new List<Move>() { MoveFactory.AncientPower, },
			[35] = new List<Move>() { MoveFactory.Brine, },
			[41] = new List<Move>() { MoveFactory.Protect, },
			[45] = new List<Move>() { MoveFactory.RockBlast, },
			[50] = new List<Move>() { MoveFactory.Surf, },
			[55] = new List<Move>() { MoveFactory.ShellSmash, },
			[60] = new List<Move>() { MoveFactory.HydroPump, },
		};
	}
}
